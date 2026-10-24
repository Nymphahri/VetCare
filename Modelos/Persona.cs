namespace VetCare.UI.Modelos
{
    // Esta clase representa a una persona con propiedades básicas como nombre, apellidos y teléfono.
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellidos}"; }
        }

        protected Persona(string nombre, string apellidos, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
        }
    }
}
