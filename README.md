# VetCare

Sistema CRUD para administrar una clínica veterinaria pequeña,
permitiendo gestionar propietarios, mascotas, veterinarios, servicios y citas.

Proyecto de Programación II  

> **Estado:** Primer avance (diseño y base de datos).  
> La aplicación se encuentra actualmente en desarrollo.

---

## Descripción

VetCare es un sistema de escritorio desarrollado para organizar la
información básica de una clínica veterinaria pequeña.

El sistema busca centralizar los datos de propietarios, mascotas,
veterinarios, servicios y citas, facilitando la consulta y actualización
de la información.

También se contempla el control de los estados de las citas, la
administración de los servicios aplicados y el cálculo de los montos
correspondientes.

---

### Estado actual del proyecto

Actualmente el proyecto se encuentra en la etapa de diseño y base de
datos.
En esta etapa se han desarrollado:
- Análisis del problema.
- Objetivos.
- Alcance.
- Requisitos funcionales.
- Diseño preliminar.
- Modelo entidad-relación.
- Modelo relacional.
- Diccionario de datos.
- Script de creación de la base de datos.
- Diagrama de clases.
- Organización inicial del proyecto.
- Estructura de las capas.
- Repositorio de GitHub.

## Funcionalidades previstas

- Inicio de sesión con los roles **Administrador** y **Recepcionista**.
- Registro de propietarios.
- Consulta, modificación y eliminación de propietarios.
- Registro de mascotas asociadas a un propietario.
- Consulta, modificación y eliminación de mascotas.
- Registro, consulta, modificación y eliminación de veterinarios.
- Administración del catálogo de servicios.
- Programación de citas.
- Control de estados de las citas:
  - Pendiente
  - Confirmada
  - Atendida
  - Cancelada
- Control para evitar dos citas a la misma hora para un mismo veterinario.
- Registro de servicios aplicados en cada cita.
- Cálculo de subtotales y totales.
- Búsqueda y filtrado de información.
- Validación de datos ingresados por el usuario.
- Mensajes de confirmación, advertencia y error.

---

## Arquitectura del proyecto

El proyecto está organizado mediante tres capas:

### VetCare.UI

Corresponde a la capa de presentación.

Contiene los formularios y controles utilizados para interactuar con el
usuario.

### VetCare.Logica

Corresponde a la capa de lógica.

Contiene las clases, reglas, validaciones y procesamiento de la
información del sistema.

### VetCare.Datos

Corresponde a la capa de acceso a datos.

Contiene la conexión con SQL Server y las operaciones necesarias para
trabajar con la base de datos.

La comunicación entre las capas seguirá el siguiente esquema:

```
VetCare.UI
    ↓
VetCare.Logica
    ↓
VetCare.Datos
    ↓
SQL Server
```

### Estructura del proyecto

VetCare/
│
├── database/
│   └── VetCareDB.sql
│
├── docs/
│   ├── diagramas/
│   │   ├── DiagramaClases.png
│   │   ├── DiagramaER.png
│   │   └── ModeloRelacionalVetCareDB.png
│   │
│   └── avance.pdf
│
├── VetCare.Datos/
│   ├── Conexion/
│   │   └── ConexionBD.cs
│   └── ...
│
├── VetCare.Logica/
│   └── ...
│
├── VetCare.UI/
│   ├── Properties/
│   ├── App.config
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── VetCare.UI.csproj
│
├── .gitignore
├── README.md
└── VetCare.slnx

### Base de datos

El script de creación de la base de datos se encuentra en: database/VetCareDB.sql

### Cómo ejecutar la base de datos y las tecnologías utilizadas

Requisitos
- **C#**
- **Windows Forms**
- **Visual Studio**
- **Microsoft SQL Server**
- **SQL Server Management Studio (SSMS)**
- **Git**
- **GitHub**
- **Framework .NET 4.8** (La versión de .NET utilizada debe ser compatible con el entorno
proporcionado por el docente. No se pudo utilizar la versión más reciente.)

Pasos
1. Abrir SQL Server Management Studio.
2. Conectarse a la instancia de SQL Server correspondiente.
3. Abrir el archivo: database/VetCareDB.sql
4. Ejecutar el script.
5. Comprobar que la base de datos VetCareDB haya sido creada correctamente.
6. Verificar que existan las siete tablas del sistema.
El script está diseñado para poder ejecutarse nuevamente sin eliminar
los datos existentes.

### Cómo ejecutar la aplicación

1. Abrir el archivo:
VetCare.slnx

2. Esperar a que Visual Studio cargue los tres proyectos:
VetCare.Datos
VetCare.Logica
VetCare.UI

3. Establecer VetCare.UI como proyecto de inicio.
4. Ejecutar la aplicación desde Visual Studio.

### Autoría

Grace Romero Sanabria
Estudiante de Ingeniería de Sistemas.

### Uso de inteligencia artificial

Ver en el documento: docs/avance.pdf.

### Repositorio

Repositorio del proyecto:
https://github.com/Nymphahri/VetCare

```
   |\---/|
   | ,_, |
    \_`_/-..----.
 ___/ `   ' ,""+ \  GRS ♥
(__...'   __\    |`.___.';
  (_,...'(_,.`__)/'.....+
```