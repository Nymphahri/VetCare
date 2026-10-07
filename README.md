# VetCare

Sistema de escritorio para administrar una clínica veterinaria poco conocida:
propietarios, mascotas, veterinarios, servicios y citas.

Primer avance (diseño y base de datos). La aplicación aún está en desarrollo.

***

## Descripción

VetCare centraliza la información básica de una clínica veterinaria pequeña
para que recepción pueda consultarla y actualizarla sin cuadernos ni hojas de
cálculo. También controla el estado de las citas, los servicios aplicados en
cada una y el cálculo de los montos.

## Funcionalidades previstas

- Inicio de sesión con los roles **Administrador** y **Recepcionista**.
- Registro, consulta, modificación y eliminación de propietarios, mascotas y veterinarios.
- Administración del catálogo de servicios.
- Programación de citas con control de estado: Pendiente, Confirmada, Atendida y Cancelada.
- Control para que un veterinario no tenga dos citas a la misma hora.
- Registro de los servicios aplicados en cada cita, con subtotales y total.
- Búsqueda y filtrado de información.
- Validación de datos y mensajes de confirmación, advertencia y error.

## Avance entregado

- Análisis del problema, objetivos, alcance y requisitos funcionales.
- Diseño preliminar de la solución.
- Diagrama de clases, modelo entidad-relación y modelo relacional.
- Diccionario de datos.
- Script de creación de la base de datos (`database/VetCareDB.sql`).
- Estructura inicial de la solución en tres capas.

El documento completo está en [`docs/avance.pdf`](docs/avance.pdf).

## Diagramas

[`docs/diagramas/`](docs/diagramas/).

## Arquitectura

La solución se divide en tres capas:

| Proyecto | Capa | Contenido |
|---|---|---|
| `VetCare.UI` | Presentación | Formularios y controles de Windows Forms. |
| `VetCare.Logica` | Lógica | Clases, reglas del negocio y validaciones. |
| `VetCare.Datos` | Acceso a datos | Conexión y consultas a SQL Server. |

Los formularios no hablan directamente con la base de datos:

```
VetCare.UI  ->  VetCare.Logica  ->  VetCare.Datos  ->  SQL Server
```

## Estructura del repositorio

```
VetCare/
├── database/
│   ├── Consultas.sql
│   └── VetCareDB.sql
│
├── docs/
│   ├── diagramas/
│   │   ├── DiagramaClases.png
│   │   ├── DiagramaER.png
│   │   └── ModeloRelacionalVetCareDB.png
│   └── avance.pdf
│
├── VetCare.Datos/
│   └── Conexion/
│       └── ConexionBD.cs
│
├── VetCare.Logica/
├── VetCare.UI/
├── .gitattributes
├── .gitignore
├── README.md
└── VetCare.slnx
```

## Requisitos

- Windows 10 u 11.
- Visual Studio 2022 (versión 17.13 o superior, por el formato `.slnx`) con la carga de trabajo **Desarrollo de escritorio con .NET**.
- .NET Framework 4.8. Es la versión compatible con el entorno del curso.
- SQL Server Express (instancia `SQLEXPRESS`).
- SQL Server Management Studio (SSMS).

## Cómo crear la base de datos

1. Abrir SSMS y conectarse a la instancia `.\SQLEXPRESS`.
2. Abrir el archivo `database/VetCareDB.sql`.
3. Ejecutar el script completo.
4. Verificar que existan las siete tablas: `Cita`, `DetalleCita`, `Mascota`, `Propietario`, `Servicio`, `Usuario` y `Veterinario`.
5. Para ver el contenido de las tablas, ejecutar el script en `database/Consultas.sql`.

El script se puede ejecutar más de una vez: solo crea lo que no existe y no borra datos.

## Usuarios de prueba

El script crea dos usuarios para poder probar el inicio de sesión. Son solo para pruebas.

| Usuario | Contraseña | Rol |
|---|---|---|
| `admin` | `admin123` | Administrador |
| `recepcion` | `recep123` | Recepcionista |

Las contraseñas se guardan como hash SHA-256, no en texto plano para evitar riesgos en la seguridad.

## Cómo ejecutar la aplicación

1. Abrir `VetCare.slnx` en Visual Studio.
2. Establecer `VetCare.UI` como proyecto de inicio.
3. Ejecutar con `F5`.

### Conexión a SQL Server

La cadena de conexión está en `VetCare.Datos/Conexion/ConexionBD.cs` y usa
autenticación de Windows contra `.\SQLEXPRESS`:

```
Server=.\SQLEXPRESS;Database=VetCareDB;Integrated Security=True;
```

Si la instancia de SQL Server tiene otro nombre, hay que cambiar el valor de
`Server` en ese archivo.

## Autoría

Grace Romero Sanabria, estudiante de Ingeniería de Sistemas.

## Uso de inteligencia artificial

La declaración completa está en el documento [`docs/avance.pdf`](docs/avance.pdf).

## Repositorio

https://github.com/Nymphahri/VetCare

```
   |\---/|
   | ,_, |
    \_`_/-..----.
 ___/ `   ' ,""+ \  GRS ♥
(__...'   __\    |`.___.';
  (_,...'(_,.`__)/'.....+
```