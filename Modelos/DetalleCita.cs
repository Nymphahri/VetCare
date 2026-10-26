namespace VetCare.UI.Modelos
{
    // Representa un servicio aplicado dentro de una cita.
    public class DetalleCita
    {
        public int IdDetalle { get; set; }
        public int IdCita { get; set; }
        public int IdServicio { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioAplicado { get; set; }

        // Es un atributo calculado: no se guarda, se obtiene al multiplicar.
        public decimal Subtotal
        {
            get
            {
                return Cantidad * PrecioAplicado;
            }
        }

        public DetalleCita(int idDetalle, int idCita, int idServicio,
            int cantidad, decimal precioAplicado)
        {
            IdDetalle = idDetalle;
            IdCita = idCita;
            IdServicio = idServicio;
            Cantidad = cantidad;
            PrecioAplicado = precioAplicado;
        }
    }
}
