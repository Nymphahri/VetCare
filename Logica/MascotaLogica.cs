using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class MascotaLogica
    {
        private MascotaDatos mascotaDatos = new MascotaDatos();

        public List<Mascota> Listar()
        {
            return mascotaDatos.Listar();
        }

        public string ValidarPropietario(int idPropietario)
        {
            if (idPropietario <= 0) return "Selecciona un propietario registrado.";
            return "";
        }

        public string ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return "El nombre es obligatorio.";
            if (nombre.Length > 50) return "El nombre admite máximo 50 caracteres.";
            return "";
        }

        public string ValidarEspecie(string especie)
        {
            if (string.IsNullOrWhiteSpace(especie)) return "La especie es obligatoria.";
            if (especie.Length > 30) return "La especie admite máximo 30 caracteres.";
            return "";
        }

        public string ValidarRaza(string raza)
        {
            if (raza.Length > 50) return "La raza admite máximo 50 caracteres.";
            return "";
        }

        public string ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            if (fechaNacimiento.Date > DateTime.Today)
                return "La fecha de nacimiento no puede ser mayor a la fecha actual.";
            return "";
        }

        public bool Guardar(Mascota mascota)
        {
            if (!EsValida(mascota)) return false;
            return mascotaDatos.Guardar(mascota);
        }

        public bool Eliminar(int idMascota)
        {
            if (idMascota <= 0) return false;
            return mascotaDatos.Eliminar(idMascota);
        }

        public bool Modificar(Mascota mascota)
        {
            if (mascota.IdMascota <= 0 || !EsValida(mascota)) return false;
            return mascotaDatos.Modificar(mascota);
        }

        private bool EsValida(Mascota mascota)
        {
            mascota.Nombre = mascota.Nombre.Trim();
            mascota.Especie = mascota.Especie.Trim();
            mascota.Raza = mascota.Raza.Trim();

            if (ValidarPropietario(mascota.IdPropietario) != "" ||
                ValidarNombre(mascota.Nombre) != "" ||
                ValidarEspecie(mascota.Especie) != "" ||
                ValidarRaza(mascota.Raza) != "" ||
                ValidarFechaNacimiento(mascota.FechaNacimiento) != "")
                return false;

            return true;
        }
    }
}
