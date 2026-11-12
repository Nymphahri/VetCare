using System.Data;
using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    public class UsuarioDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Usuario> Listar()
        {
            const string consulta = "SELECT IdUsuario, NombreUsuario, Rol FROM dbo.Usuario ORDER BY NombreUsuario";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();
            List<Usuario> usuarios = new List<Usuario>();
            while (lector.Read())
                usuarios.Add(new Usuario(lector.GetInt32(0), lector.GetString(1), lector.GetString(2)));
            return usuarios;
        }

        public Usuario? BuscarPorCredenciales(string nombre, string hash)
        {
            if (nombre.Length > 30 || hash.Length != 64) return null;
            const string consulta = "SELECT IdUsuario, NombreUsuario, Rol FROM dbo.Usuario " +
                "WHERE NombreUsuario = @Nombre AND UPPER(ContrasenaHash) = @Hash";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = nombre;
            comando.Parameters.Add("@Hash", SqlDbType.VarChar, 64).Value = hash;
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();
            if (!lector.Read()) return null;
            return new Usuario(lector.GetInt32(0), lector.GetString(1), lector.GetString(2));
        }
    }
}
