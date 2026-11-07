using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    public class VeterinarioDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Veterinario> Listar()
        {
            return Buscar("");
        }

        public List<Veterinario> Buscar(string texto)
        {
            List<Veterinario> veterinarios = new List<Veterinario>();
            string consulta = "SELECT IdVeterinario, Nombre, Apellidos, Especialidad, Telefono " +
                "FROM Veterinario WHERE @Busqueda = '' OR CHARINDEX(@Busqueda, Nombre) > 0 " +
                "OR CHARINDEX(@Busqueda, Apellidos) > 0 OR CHARINDEX(@Busqueda, Especialidad) > 0 " +
                "ORDER BY IdVeterinario DESC";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@Busqueda", System.Data.SqlDbType.VarChar, 80).Value = texto;
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                veterinarios.Add(new Veterinario(
                    lector.GetInt32(0), lector.GetString(1), lector.GetString(2),
                    lector.GetString(3), lector.GetString(4)));
            }
            return veterinarios;
        }

        public bool Eliminar(int idVeterinario)
        {
            string consulta = "DELETE FROM Veterinario WHERE IdVeterinario = @IdVeterinario";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdVeterinario", idVeterinario);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        public bool Modificar(Veterinario veterinario)
        {
            string consulta = "UPDATE Veterinario SET Nombre = @Nombre, Apellidos = @Apellidos, " +
                "Especialidad = @Especialidad, Telefono = @Telefono WHERE IdVeterinario = @IdVeterinario";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdVeterinario", veterinario.IdVeterinario);
            comando.Parameters.AddWithValue("@Nombre", veterinario.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", veterinario.Apellidos);
            comando.Parameters.AddWithValue("@Especialidad", veterinario.Especialidad);
            comando.Parameters.AddWithValue("@Telefono", veterinario.Telefono);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        public bool Guardar(Veterinario veterinario)
        {
            string consulta = "INSERT INTO Veterinario (Nombre, Apellidos, Especialidad, Telefono) " +
                "VALUES (@Nombre, @Apellidos, @Especialidad, @Telefono)";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@Nombre", veterinario.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", veterinario.Apellidos);
            comando.Parameters.AddWithValue("@Especialidad", veterinario.Especialidad);
            comando.Parameters.AddWithValue("@Telefono", veterinario.Telefono);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }
    }
}
