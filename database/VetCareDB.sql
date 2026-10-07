/*
 * VetCareDB: script de creación.
 * Se puede ejecutar varias veces: solo crea lo que no existe
 * y no borra los datos.
 */

/* Crea la base si no existe.
*/
IF DB_ID('VetCareDB') IS NULL
    CREATE DATABASE VetCareDB;
GO

USE VetCareDB;
GO

/*
* Crea una tabla sólo si no existe.
*/
IF OBJECT_ID('dbo.Propietario', 'U') IS NULL
BEGIN
    CREATE TABLE Propietario (
        IdPropietario INT IDENTITY(1,1) NOT NULL,
        Cedula        VARCHAR(20)  NOT NULL,
        Nombre        VARCHAR(50)  NOT NULL,
        Apellidos     VARCHAR(80)  NOT NULL,
        Telefono      VARCHAR(20)  NOT NULL,
        Correo        VARCHAR(100) NULL,
        FechaRegistro DATETIME     NOT NULL
            CONSTRAINT DF_Propietario_FechaRegistro DEFAULT GETDATE(),
            CONSTRAINT PK_Propietario PRIMARY KEY (IdPropietario),
            CONSTRAINT UQ_Propietario_Cedula UNIQUE (Cedula)
    );
END
GO

IF OBJECT_ID('dbo.Veterinario', 'U') IS NULL
BEGIN
    CREATE TABLE Veterinario (
        IdVeterinario INT IDENTITY(1,1) NOT NULL,
        Nombre        VARCHAR(50) NOT NULL,
        Apellidos     VARCHAR(80) NOT NULL,
        Especialidad  VARCHAR(60) NOT NULL,
        Telefono      VARCHAR(20) NOT NULL,
            CONSTRAINT PK_Veterinario PRIMARY KEY (IdVeterinario)
    );
END
GO

IF OBJECT_ID('dbo.Servicio', 'U') IS NULL
BEGIN
    CREATE TABLE Servicio (
        IdServicio  INT IDENTITY(1,1) NOT NULL,
        Nombre      VARCHAR(60)   NOT NULL,
        Descripcion VARCHAR(200)  NULL,
        Precio      DECIMAL(10,2) NOT NULL,
            CONSTRAINT PK_Servicio PRIMARY KEY (IdServicio),
            CONSTRAINT UQ_Servicio_Nombre UNIQUE (Nombre),
            CONSTRAINT CK_Servicio_Precio CHECK (Precio >= 0)
    );
END
GO

IF OBJECT_ID('dbo.Usuario', 'U') IS NULL
BEGIN
    CREATE TABLE Usuario (
        IdUsuario      INT IDENTITY(1,1) NOT NULL,
        NombreUsuario  VARCHAR(30) NOT NULL,
        ContrasenaHash VARCHAR(64) NOT NULL,
        Rol            VARCHAR(20) NOT NULL,
            CONSTRAINT PK_Usuario PRIMARY KEY (IdUsuario),
            CONSTRAINT UQ_Usuario_NombreUsuario UNIQUE (NombreUsuario),
            CONSTRAINT CK_Usuario_Rol
                CHECK (Rol IN ('Administrador', 'Recepcionista'))
    );
END
GO

/* Tablas que dependen de las anteriores.
*/

IF OBJECT_ID('dbo.Mascota', 'U') IS NULL
BEGIN
    CREATE TABLE Mascota (
        IdMascota       INT IDENTITY(1,1) NOT NULL,
        IdPropietario   INT         NOT NULL,
        Nombre          VARCHAR(50) NOT NULL,
        Especie         VARCHAR(30) NOT NULL,
        Raza            VARCHAR(50) NULL,
        FechaNacimiento DATE        NOT NULL,
        FechaRegistro   DATETIME    NOT NULL
            CONSTRAINT DF_Mascota_FechaRegistro DEFAULT GETDATE(),
            CONSTRAINT PK_Mascota PRIMARY KEY (IdMascota),
            CONSTRAINT FK_Mascota_Propietario FOREIGN KEY (IdPropietario)
                REFERENCES Propietario (IdPropietario),
            CONSTRAINT CK_Mascota_FechaNacimiento
                CHECK (FechaNacimiento <= CAST(GETDATE() AS DATE))
    );
END
GO

IF OBJECT_ID('dbo.Cita', 'U') IS NULL
BEGIN
    CREATE TABLE Cita (
        IdCita        INT IDENTITY(1,1) NOT NULL,
        IdMascota     INT          NOT NULL,
        IdVeterinario INT          NOT NULL,
        FechaHora     DATETIME     NOT NULL,
        Estado        VARCHAR(15)  NOT NULL
            CONSTRAINT DF_Cita_Estado DEFAULT 'Pendiente',
        Motivo        VARCHAR(200) NULL,
            CONSTRAINT PK_Cita PRIMARY KEY (IdCita),
            CONSTRAINT FK_Cita_Mascota FOREIGN KEY (IdMascota)
                REFERENCES Mascota (IdMascota),
            CONSTRAINT FK_Cita_Veterinario FOREIGN KEY (IdVeterinario)
                REFERENCES Veterinario (IdVeterinario),
            CONSTRAINT CK_Cita_Estado CHECK
                (Estado IN ('Pendiente', 'Confirmada', 'Atendida', 'Cancelada'))
    );
END
GO

/* Un veterinario no puede tener dos citas a la misma hora
 * (las canceladas no cuentan).
*/
IF NOT EXISTS (SELECT 1 FROM sys.indexes
               WHERE name = 'UX_Cita_Veterinario_FechaHora'
                 AND object_id = OBJECT_ID('dbo.Cita'))
BEGIN
    CREATE UNIQUE INDEX UX_Cita_Veterinario_FechaHora
        ON Cita (IdVeterinario, FechaHora)
        WHERE Estado <> 'Cancelada';
END
GO

IF OBJECT_ID('dbo.DetalleCita', 'U') IS NULL
BEGIN
    CREATE TABLE DetalleCita (
        IdDetalle      INT IDENTITY(1,1) NOT NULL,
        IdCita         INT           NOT NULL,
        IdServicio     INT           NOT NULL,
        Cantidad       INT           NOT NULL,
        PrecioAplicado DECIMAL(10,2) NOT NULL,
            CONSTRAINT PK_DetalleCita PRIMARY KEY (IdDetalle),
            CONSTRAINT FK_DetalleCita_Cita FOREIGN KEY (IdCita)
                REFERENCES Cita (IdCita) ON DELETE CASCADE,
            CONSTRAINT FK_DetalleCita_Servicio FOREIGN KEY (IdServicio)
                REFERENCES Servicio (IdServicio),
            CONSTRAINT CK_DetalleCita_Cantidad CHECK (Cantidad > 0),
            CONSTRAINT CK_DetalleCita_Precio CHECK (PrecioAplicado >= 0)
    );
END
GO

/* Un servicio no se repite en la misma cita: si se aplica varias
 * veces, se usa el campo Cantidad. Se agrega aparte para que también
 * funcione si DetalleCita ya existía.
*/
IF NOT EXISTS (SELECT 1 FROM sys.key_constraints
               WHERE name = 'UQ_DetalleCita_Cita_Servicio'
                 AND parent_object_id = OBJECT_ID('dbo.DetalleCita'))
BEGIN
    ALTER TABLE DetalleCita
        ADD CONSTRAINT UQ_DetalleCita_Cita_Servicio UNIQUE (IdCita, IdServicio);
END
GO

/* Usuarios para iniciar sesión. Se crean aparte de los demás datos de
 * prueba para que siempre exista al menos un usuario con el que entrar.
 * Solo se insertan si la tabla Usuario está vacía.
*/
IF NOT EXISTS (SELECT 1 FROM Usuario)
BEGIN
    INSERT INTO Usuario (NombreUsuario, ContrasenaHash, Rol)
    VALUES ('admin',     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Administrador'),
           ('recepcion', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'recep123'), 2), 'Recepcionista');
END
GO

/* Datos ficticios para probar la base (no corresponden a personas reales).
 * Solo se insertan si las tablas están vacías, así que volver a
 * ejecutar el script no duplica ni borra nada.
*/
IF NOT EXISTS (SELECT 1 FROM Propietario)
   AND NOT EXISTS (SELECT 1 FROM Veterinario)
   AND NOT EXISTS (SELECT 1 FROM Servicio)
BEGIN
    DECLARE @IdPropietario INT,
            @IdVeterinario INT,
            @IdMascota     INT,
            @IdCita1       INT,
            @IdCita2       INT;

    INSERT INTO Propietario (Cedula, Nombre, Apellidos, Telefono, Correo)
    VALUES ('1-1234-5678', 'Carlos', 'Mora Jiménez', '8888-1234', 'carlos.mora@example.com');
        SET @IdPropietario = SCOPE_IDENTITY();

    INSERT INTO Veterinario (Nombre, Apellidos, Especialidad, Telefono)
    VALUES ('Andrea', 'Vargas Solís', 'Medicina general', '8800-0088');
        SET @IdVeterinario = SCOPE_IDENTITY();

    INSERT INTO Servicio (Nombre, Descripcion, Precio)
    VALUES ('Consulta general',     'Revisión general de la mascota', 15000.00),
           ('Vacunación',           'Aplicación de vacuna',           12000.00),
           ('Baño y corte de pelo', 'Servicio de estética',           10000.00),
           ('Desparasitación',      'Tratamiento antiparasitario',     8000.00);

    INSERT INTO Mascota (IdPropietario, Nombre, Especie, Raza, FechaNacimiento)
    VALUES (@IdPropietario, 'Max', 'Perro', 'Labrador', '2020-05-10');
        SET @IdMascota = SCOPE_IDENTITY();

    INSERT INTO Cita (IdMascota, IdVeterinario, FechaHora, Estado, Motivo)
    VALUES (@IdMascota, @IdVeterinario, '2026-10-15 09:00', 'Confirmada', 'Control anual');
        SET @IdCita1 = SCOPE_IDENTITY();

    INSERT INTO Cita (IdMascota, IdVeterinario, FechaHora, Estado, Motivo)
    VALUES (@IdMascota, @IdVeterinario, '2026-10-15 10:00', 'Pendiente', 'Vacuna anual');
        SET @IdCita2 = SCOPE_IDENTITY();

    /* El precio se copia del catálogo en el momento de la cita.
    */
    INSERT INTO DetalleCita (IdCita, IdServicio, Cantidad, PrecioAplicado)
    SELECT @IdCita1, IdServicio, 1, Precio
    FROM Servicio
    WHERE Nombre = 'Consulta general';

    INSERT INTO DetalleCita (IdCita, IdServicio, Cantidad, PrecioAplicado)
    SELECT @IdCita2, IdServicio, 1, Precio
    FROM Servicio
    WHERE Nombre IN ('Vacunación', 'Desparasitación');
END
GO

/* Deben aparecer las 7 tablas exactamente.
*/
SELECT name FROM sys.tables ORDER BY name;
GO