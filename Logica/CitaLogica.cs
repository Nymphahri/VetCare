using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class CitaLogica
    {
        private CitaDatos citaDatos = new CitaDatos();

        public List<Cita> Listar(string nombreMascota = "", DateTime? fecha = null, string estado = "")
        {
            return citaDatos.Listar(nombreMascota.Trim(), fecha, estado);
        }

        public bool Confirmar(int idCita)
        {
            if (idCita <= 0) return false;
            return citaDatos.Confirmar(idCita);
        }

        public bool Atender(int idCita)
        {
            if (idCita <= 0) return false;
            return citaDatos.Atender(idCita);
        }

        public bool Cancelar(int idCita)
        {
            if (idCita <= 0) return false;
            return citaDatos.Cancelar(idCita);
        }

        public static DateTime HorarioAlMinuto(DateTime fechaHora)
        {
            return new DateTime(fechaHora.Year, fechaHora.Month, fechaHora.Day,
                fechaHora.Hour, fechaHora.Minute, 0);
        }

        public bool Reprogramar(Cita cita, DateTime fechaHora)
        {
            if (cita.IdCita <= 0) return false;
            return citaDatos.Reprogramar(cita, HorarioAlMinuto(fechaHora));
        }

        public bool Agendar(int idMascota, int idVeterinario, DateTime fechaHora, string motivo)
        {
            motivo = motivo.Trim();
            if (idMascota <= 0 || idVeterinario <= 0 || motivo.Length > 200)
                return false;

            DateTime horario = HorarioAlMinuto(fechaHora);
            Cita cita = new Cita(0, idMascota, idVeterinario, horario, "Pendiente", motivo);
            return citaDatos.Agendar(cita);
        }
    }
}
