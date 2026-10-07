using System.Data.SqlClient;

namespace VetCare.Datos.Conexion
{
    public class ConexionBD
    {
        // El punto (.) significa "este equipo". Si la instancia de SQL Server
        // se llama distinto, solo hay que cambiar esta línea.
        private const string CadenaConexion =
            @"Server=.\SQLEXPRESS;Database=VetCareDB;Integrated Security=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}