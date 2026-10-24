namespace VetCare.UI.Modelos
{
    public class Mascota
    {
        // Propiedades de la clase Mascota
        public int IdMascota { get; set; }
        public int IdPropietario { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - FechaNacimiento.Year;

                if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }

                return edad;
            }
        }

        // Constructor de la clase Mascota
        public Mascota(
            int idMascota,
            int idPropietario,
            string nombre,
            string especie,
            string raza,
            DateTime fechaNacimiento,
            DateTime fechaRegistro)
        {
            IdMascota = idMascota;
            IdPropietario = idPropietario;
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
        }
    }
}
