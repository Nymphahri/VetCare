namespace VetCare.UI.Modelos
{
    // Representa una cita asignada a una mascota y a un veterinario.
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdMascota { get; set; }
        public int IdVeterinario { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
        public List<DetalleCita> Detalles { get; set; }

        // Suma los subtotales de todos los servicios aplicados.
        public decimal Total
        {
            get
            {
                decimal total = 0;

                foreach (DetalleCita detalle in Detalles)
                {
                    total = total + detalle.Subtotal;
                }

                return total;
            }
        }

        public Cita(int idCita, int idMascota, int idVeterinario,
            DateTime fechaHora, string estado, string motivo)
        {
            IdCita = idCita;
            IdMascota = idMascota;
            IdVeterinario = idVeterinario;
            FechaHora = fechaHora;
            Estado = estado;
            Motivo = motivo;
            Detalles = new List<DetalleCita>();
        }

        public void AgregarDetalle(DetalleCita detalle)
        {
            Detalles.Add(detalle);
        }
    }
}
