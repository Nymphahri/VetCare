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

            byte[] caracteres = Encoding.UTF8.GetBytes(contrasena);
            string hash = Convert.ToHexString(SHA256.HashData(caracteres));
            return usuarioDatos.BuscarPorCredenciales(nombre, hash);
        }
    }
}
