namespace VetCare.UI.Modelos
{
    // Representa a la persona que inicia sesión en el sistema.
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        public Usuario(int idUsuario, string nombreUsuario, string contrasena, string rol)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Rol = rol;
        }

        public bool ValidarContrasena(string contrasenaIngresada)
        {
            if (Contrasena == contrasenaIngresada)
            {
                return true;
            }

            return false;
        }
    }
}
