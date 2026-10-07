USE VetCareDB;
GO

/* ===== 1. Cuántas filas hay en cada tabla ===== */
SELECT 'Propietario' AS Tabla, COUNT(*) AS Filas FROM Propietario
UNION ALL SELECT 'Veterinario', COUNT(*) FROM Veterinario
UNION ALL SELECT 'Servicio',    COUNT(*) FROM Servicio
UNION ALL SELECT 'Usuario',     COUNT(*) FROM Usuario
UNION ALL SELECT 'Mascota',     COUNT(*) FROM Mascota
UNION ALL SELECT 'Cita',        COUNT(*) FROM Cita
UNION ALL SELECT 'DetalleCita', COUNT(*) FROM DetalleCita;

/* ===== 2. Contenido de cada tabla ===== */
SELECT * FROM Propietario;
SELECT * FROM Veterinario;
SELECT * FROM Servicio;
SELECT IdUsuario, NombreUsuario, Rol FROM Usuario;   -- sin el hash
SELECT * FROM Mascota;
SELECT * FROM Cita;
SELECT * FROM DetalleCita;

/* ===== 3. Mascotas con su dueño y su edad ===== */
SELECT  m.IdMascota,
        m.Nombre                         AS Mascota,
        m.Especie,
        m.Raza,
        p.Nombre + ' ' + p.Apellidos     AS Propietario,
        DATEDIFF(YEAR, m.FechaNacimiento, GETDATE())
          - CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, m.FechaNacimiento, GETDATE()),
                              m.FechaNacimiento) > CAST(GETDATE() AS DATE)
                 THEN 1 ELSE 0 END       AS Edad
FROM Mascota m
INNER JOIN Propietario p ON p.IdPropietario = m.IdPropietario;

/* ===== 4. Citas con mascota, veterinario y total ===== */
SELECT  c.IdCita,
        c.FechaHora,
        c.Estado,
        m.Nombre                         AS Mascota,
        v.Nombre + ' ' + v.Apellidos     AS Veterinario,
        c.Motivo,
        ISNULL(SUM(d.Cantidad * d.PrecioAplicado), 0) AS Total
FROM Cita c
INNER JOIN Mascota     m ON m.IdMascota     = c.IdMascota
INNER JOIN Veterinario v ON v.IdVeterinario = c.IdVeterinario
LEFT  JOIN DetalleCita d ON d.IdCita        = c.IdCita
GROUP BY c.IdCita, c.FechaHora, c.Estado, m.Nombre,
         v.Nombre, v.Apellidos, c.Motivo
ORDER BY c.FechaHora;

/* ===== 5. Servicios aplicados en cada cita ===== */
SELECT  d.IdCita,
        s.Nombre                         AS Servicio,
        d.Cantidad,
        d.PrecioAplicado,
        d.Cantidad * d.PrecioAplicado    AS Subtotal
FROM DetalleCita d
INNER JOIN Servicio s ON s.IdServicio = d.IdServicio
ORDER BY d.IdCita;