using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class CitaLogica
    {
        private CitaDatos citaDatos = new CitaDatos();

        public List<Cita> Listar()
        {
            return citaDatos.Listar();
        }

        public bool Confirmar(int idCita)
        {
            if (idCita <= 0) return false;
            return citaDatos.Confirmar(idCita);
        }

        public bool Cancelar(int idCita)
        {
            if (idCita <= 0) return false;
            return citaDatos.Cancelar(idCita);
        }

        public bool Agendar(int idMascota, int idVeterinario, DateTime fechaHora, string motivo)
        {
            motivo = motivo.Trim();
            if (idMascota <= 0 || idVeterinario <= 0 || motivo.Length > 200)
                return false;

            DateTime horario = new DateTime(fechaHora.Year, fechaHora.Month, fechaHora.Day,
                fechaHora.Hour, fechaHora.Minute, 0);
            Cita cita = new Cita(0, idMascota, idVeterinario, horario, "Pendiente", motivo);
            return citaDatos.Agendar(cita);
        }
    }
}
