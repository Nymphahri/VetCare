using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class DetalleCitaLogica
    {
        private DetalleCitaDatos datos = new DetalleCitaDatos();

        public List<DetalleCita> Listar(int idCita)
        {
            return datos.Listar(idCita);
        }

        public string ValidarCantidad(string texto, out int cantidad)
        {
            if (!int.TryParse(texto, out cantidad) || cantidad <= 0)
                return "Escribe un número entero mayor que cero.";
            return "";
        }

        public bool Agregar(int idCita, int idServicio, int cantidad)
        {
            if (idCita <= 0 || idServicio <= 0 || cantidad <= 0) return false;
            return datos.Agregar(idCita, idServicio, cantidad);
        }
    }
}
