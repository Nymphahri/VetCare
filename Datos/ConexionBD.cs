using Microsoft.Data.SqlClient;

namespace VetCare.UI.Datos
{
    // Centraliza la cadena y la creación de conexiones con SQL Server.
    public class ConexionBD
    {
        private string cadenaConexion =
            "Server=.\\SQLEXPRESS;Database=VetCareDB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
