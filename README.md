# VetCare

Sistema de escritorio para la administración de una clínica veterinaria. Permite registrar propietarios y mascotas, gestionar veterinarios y servicios, y llevar una agenda de citas. En cada cita se guarda la cantidad y el precio aplicado de cada servicio para calcular el total de la visita.

Proyecto individual de Grace Romero Sanabria para el curso ISB-13 Programación II.

## Requisitos

- Windows y Visual Studio con la carga de trabajo **Desarrollo de escritorio de .NET**, soporte para .NET 10 y para soluciones `.slnx`.
- SDK de .NET 10.
- Una instancia de SQL Server en ejecución. La configuración del proyecto utiliza SQL Server Express en `.\SQLEXPRESS` con autenticación de Windows.
- SQL Server Management Studio (SSMS) para ejecutar el script. La cuenta de Windows que lo ejecuta necesita permisos para crear la base. La cuenta que ejecuta VetCare necesita acceso a los datos.

La aplicación está escrita en C# con Windows Forms. Utiliza **Guna.UI2.WinForms** para los controles visuales y **Microsoft.Data.SqlClient** para enviar consultas parametrizadas a SQL Server. Las versiones están declaradas en [VetCare.UI.csproj](VetCare.UI.csproj).

## Instalar la base y ejecutar VetCare

1. Descarga o clona el repositorio. Abre SSMS y conéctate a la instancia `.\SQLEXPRESS` con **Autenticación de Windows**.
2. Abre [database/VetCareDB.sql](database/VetCareDB.sql) y ejecuta el archivo completo con **F5**. En una instalación nueva crea la base `VetCareDB`, siete tablas y datos de ejemplo.
3. En el Explorador de objetos de SSMS, actualiza **Bases de datos** y expande **VetCareDB → Tablas**. Si utilizas otra instancia, ajusta el valor de `Server` en [Datos/ConexionBD.cs](Datos/ConexionBD.cs) para que coincida con el servidor de SSMS.
4. Abre [VetCare.slnx](VetCare.slnx) en Visual Studio. Restaura los paquetes NuGet de la solución y pulsa **F5**. Aparecerá el formulario de inicio de sesión.

### Cuentas para la demostración

El script crea estas cuentas cuando la tabla de usuarios está vacía.

| Usuario | Contraseña de prueba | Rol |
|---|---|---|
| `admin` | `admin123` | Administrador |
| `recepcion` | `recep123` | Recepcionista |

Ambos roles pueden registrar propietarios y mascotas, agendar citas y agregar servicios a una cita. El administrador también gestiona los catálogos de veterinarios y servicios y las cuentas de usuario.

### Consultar citas y registrar servicios

1. Abre **Recepción → Citas** para consultar citas de cualquier fecha. Puedes filtrar por mascota, fecha o estado.
2. Selecciona una cita y pulsa **Servicios de la cita** para consultar su detalle o agregar un servicio con su cantidad. **Volver a citas** recupera la selección y los filtros.
3. Para programar desde la agenda, selecciona el día y pulsa **+ Agendar una cita**. El formulario se abre con ese día seleccionado y la lista filtrada por fecha.

En **Administración → Servicios**, el administrador mantiene los precios y la disponibilidad del catálogo. Al desactivar un servicio se conserva su historial. Al cancelar una cita se conserva el registro y se libera el horario del veterinario.

El [manual técnico de VetCare](Documentos/Manual%20tecnico%20de%20VetCare.docx) incluye el modelo de clases, el diagrama entidad-relación, el modelo relacional y el diccionario de datos.

El [manual de usuario](Documentos/Manual%20de%20usuario.docx) explica cómo trabajar con la agenda, registrar pacientes y administrar el catálogo.

## Organización del proyecto

| Carpeta | Responsabilidad |
|---|---|
| `UI` | Interfaz visual. `UI/Forms` contiene los formularios con su diseñador y recursos. `SelectorFecha` es el control de fecha compartido. |
| `Modelos` | Clases que representan personas, mascotas, citas, servicios y usuarios. Incluye los cálculos de edad, subtotal y total. |
| `Logica` | Validación de datos y reglas que se aplican antes de guardar cambios. |
| `Datos` | Conexión con SQL Server y consultas para leer y modificar registros. |
| `database` | Script de creación de la base de datos y registros de ejemplo. |

## Uso de inteligencia artificial

Se utilizó OpenAI Codex como apoyo para explicar conceptos del curso, escribir y revisar código de formularios, validaciones y acceso a datos, preparar el script de instalación, ejecutar pruebas y redactar este README. Se comprobó desde Windows Forms que una cita en la base de prueba conservaba sus servicios, cantidades y total después de cerrar y volver a abrir el detalle.
