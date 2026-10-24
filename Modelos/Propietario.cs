namespace VetCare.UI.Modelos
{
    // Esta clase representa a un propietario, que hereda de la clase Persona y añade atributos propios.

    public class Propietario : Persona
    {
        public int IdPropietario { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Propietario(
            int idPropietario,
            string cedula,
            string nombre,
            string apellidos,
            string telefono,
            string correo,
            DateTime fechaRegistro)
            : base(nombre, apellidos, telefono)
        {
            IdPropietario = idPropietario;
            Cedula = cedula;
            Correo = correo;
            FechaRegistro = fechaRegistro;
        }
    }
}
