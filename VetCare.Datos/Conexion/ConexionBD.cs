using System.Data.SqlClient;

namespace VetCare.Datos.Conexion
{
    public class ConexionBD
    {
        private readonly string cadenaConexion =
            @"Server=GRACY\SQLEXPRESS;Database=VetCareDB;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}