using System.Security.Cryptography;
using System.Text;
using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class UsuarioLogica
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

        public List<Usuario> Listar()
        {
            return usuarioDatos.Listar();
        }

        public Usuario? IniciarSesion(string nombre, string contrasena)
        {
            nombre = nombre.Trim();
            if (nombre.Length == 0 || nombre.Length > 30 || string.IsNullOrEmpty(contrasena))
                return null;

            return usuarioDatos.BuscarPorCredenciales(nombre, CalcularHash(contrasena));
        }

        public bool Registrar(string nombre, string contrasena, string rol)
        {
            nombre = nombre.Trim();
            if (nombre.Length == 0 || nombre.Length > 30 || string.IsNullOrWhiteSpace(contrasena))
                return false;
            if (rol != "Administrador" && rol != "Recepcionista") return false;
            return usuarioDatos.Registrar(nombre, CalcularHash(contrasena), rol);
        }

        private string CalcularHash(string contrasena)
        {
            byte[] caracteres = Encoding.UTF8.GetBytes(contrasena);
            return Convert.ToHexString(SHA256.HashData(caracteres));
        }
    }
}
