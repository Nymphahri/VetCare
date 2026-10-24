namespace VetCare.UI.Modelos
{
    public class Servicio
    {
        // Propiedades de la clase Servicio
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }

        public Servicio(
            int idServicio,
            string nombre,
            string descripcion,
            decimal precio,
            bool estado)
        {
            IdServicio = idServicio;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Estado = estado;
        }
    }
}
