using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    // Contiene las consultas SQL relacionadas con propietarios.
    public class PropietarioDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Propietario> Listar()
        {
            return Buscar("");
        }

        public List<Propietario> Buscar(string texto)
        {
            List<Propietario> propietarios = new List<Propietario>();
            string consulta = "SELECT IdPropietario, Cedula, Nombre, Apellidos, Telefono, Correo, FechaRegistro " +
                "FROM Propietario WHERE @Busqueda = '' OR " +
                "CHARINDEX(@Busqueda, Cedula) > 0 OR CHARINDEX(@Busqueda, Nombre) > 0 OR " +
                "CHARINDEX(@Busqueda, Apellidos) > 0 ORDER BY IdPropietario DESC";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@Busqueda", System.Data.SqlDbType.VarChar, 80).Value = texto;
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                string correo = "";
                if (!lector.IsDBNull(5)) correo = lector.GetString(5);
                propietarios.Add(new Propietario(
                    lector.GetInt32(0), lector.GetString(1), lector.GetString(2),
                    lector.GetString(3), lector.GetString(4), correo, lector.GetDateTime(6)));
            }
            return propietarios;
        }

        public bool Eliminar(int idPropietario)
        {
            string consulta = "DELETE FROM Propietario WHERE IdPropietario = @IdPropietario";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdPropietario", idPropietario);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        public bool Modificar(Propietario propietario)
        {
            string consulta = "UPDATE Propietario SET Cedula = @Cedula, Nombre = @Nombre, " +
                "Apellidos = @Apellidos, Telefono = @Telefono, Correo = @Correo " +
                "WHERE IdPropietario = @IdPropietario";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdPropietario", propietario.IdPropietario);
            comando.Parameters.AddWithValue("@Cedula", propietario.Cedula);
            comando.Parameters.AddWithValue("@Nombre", propietario.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", propietario.Apellidos);
            comando.Parameters.AddWithValue("@Telefono", propietario.Telefono);
            if (string.IsNullOrWhiteSpace(propietario.Correo))
                comando.Parameters.AddWithValue("@Correo", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@Correo", propietario.Correo);

            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

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
            if (string.IsNullOrWhiteSpace(propietario.Correo))
            {
                comando.Parameters.AddWithValue("@Correo", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@Correo", propietario.Correo);
            }
            comando.Parameters.AddWithValue("@FechaRegistro", propietario.FechaRegistro);

            conexionSql.Open();

            int filasAfectadas = comando.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
    }
}
