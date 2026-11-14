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
            if (!NombreValido(nombre) || string.IsNullOrEmpty(contrasena))
                return null;

            return usuarioDatos.BuscarPorCredenciales(nombre, CalcularHash(contrasena));
        }

        public bool Registrar(string nombre, string contrasena, string rol)
        {
            nombre = nombre.Trim();
            if (!NombreValido(nombre) || !ContrasenaRegistroValida(contrasena))
                return false;
            if (!EsRolValido(rol)) return false;
            return usuarioDatos.Registrar(nombre, CalcularHash(contrasena), rol);
        }

        public bool CambiarRol(Usuario usuario, string nuevoRol)
        {
            if (!PuedeCambiarRol(usuario, nuevoRol))
                return false;
            return usuarioDatos.CambiarRol(usuario, nuevoRol);
        }

        public static bool NombreValido(string nombre) => nombre.Trim().Length > 0 && nombre.Trim().Length <= 30;

        public static bool ContrasenaRegistroValida(string contrasena) => !string.IsNullOrWhiteSpace(contrasena);

        public static bool PuedeCambiarRol(Usuario usuario, string nuevoRol) =>
            usuario.IdUsuario > 0 && EsRolValido(nuevoRol) && usuario.Rol != nuevoRol;

        public static bool EsRolValido(string rol)
        {
            return rol == "Administrador" || rol == "Recepcionista";
        }

        private string CalcularHash(string contrasena)
        {
            byte[] caracteres = Encoding.UTF8.GetBytes(contrasena);
            return Convert.ToHexString(SHA256.HashData(caracteres));
        }
    }
}
