namespace VetCare.UI.Modelos
{
    // Esta clase representa a un veterinario, que hereda de la clase Persona y añade atributos propios.
    public class Veterinario : Persona
    {
        public int IdVeterinario { get; set; }
        public string Especialidad { get; set; }

        public Veterinario(
            int idVeterinario,
            string nombre,
            string apellidos,
            string especialidad,
            string telefono)
            : base(nombre, apellidos, telefono)
        {
            IdVeterinario = idVeterinario;
            Especialidad = especialidad;
        }
    }
}
