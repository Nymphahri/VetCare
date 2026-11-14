using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class ServicioLogica
    {
        private ServicioDatos servicioDatos = new ServicioDatos();

        public List<Servicio> Listar()
        {
            return servicioDatos.Listar();
        }

        public List<Servicio> ListarActivos()
        {
            return Listar().FindAll(servicio => servicio.Estado);
        }

        public string ValidarPrecio(string texto, out decimal precio)
        {
            string normalizado = texto.Trim().Replace(',', '.');
            if (!decimal.TryParse(normalizado, System.Globalization.NumberStyles.AllowDecimalPoint |
                System.Globalization.NumberStyles.AllowLeadingSign, System.Globalization.CultureInfo.InvariantCulture, out precio))
                return "Escribe un precio sin separadores de miles.";

            return ValidarPrecio(precio);
        }

        public string ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return "El nombre es obligatorio.";
            if (nombre.Length > 60) return "El nombre admite máximo 60 caracteres.";
            return "";
        }

        public List<Servicio> Buscar(string texto)
        {
            return servicioDatos.Buscar(texto.Trim());
        }

        public string ValidarDescripcion(string descripcion)
        {
            if (descripcion.Length > 200) return "La descripción admite máximo 200 caracteres.";
            return "";
        }

        public string ValidarPrecio(decimal precio)
        {
            if (precio < 0) return "El precio debe ser cero o mayor.";
            if (precio > 99999999.99m) return "El precio admite máximo ocho dígitos enteros.";
            if (decimal.Round(precio, 2) != precio) return "El precio admite máximo dos decimales.";
            return "";
        }

        public bool Guardar(Servicio servicio)
        {
            if (!EsValido(servicio)) return false;
            return servicioDatos.Guardar(servicio);
        }

        public bool Modificar(Servicio servicio)
        {
            if (servicio.IdServicio <= 0 || !EsValido(servicio)) return false;
            return servicioDatos.Modificar(servicio);
        }

        private bool EsValido(Servicio servicio)
        {
            servicio.Nombre = servicio.Nombre.Trim();
            servicio.Descripcion = servicio.Descripcion.Trim();
            if (ValidarNombre(servicio.Nombre) != "" ||
                ValidarDescripcion(servicio.Descripcion) != "" ||
                ValidarPrecio(servicio.Precio) != "")
                return false;

            return true;
        }
    }
}
