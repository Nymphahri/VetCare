using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    // Contiene las consultas SQL relacionadas con propietarios.
    public class PropietarioDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Guardar(Propietario propietario)
        {
            string consulta = "INSERT INTO Propietario " +
                "(Cedula, Nombre, Apellidos, Telefono, Correo, FechaRegistro) " +
                "VALUES (@Cedula, @Nombre, @Apellidos, @Telefono, @Correo, @FechaRegistro)";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);

            comando.Parameters.AddWithValue("@Cedula", propietario.Cedula);
            comando.Parameters.AddWithValue("@Nombre", propietario.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", propietario.Apellidos);
            comando.Parameters.AddWithValue("@Telefono", propietario.Telefono);
            comando.Parameters.AddWithValue("@Correo", propietario.Correo);
            comando.Parameters.AddWithValue("@FechaRegistro", propietario.FechaRegistro);

            conexionSql.Open();

            int filasAfectadas = comando.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }
}
