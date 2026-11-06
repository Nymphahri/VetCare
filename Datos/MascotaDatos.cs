using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    public class MascotaDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Mascota> Listar()
        {
            return Buscar("");
        }

        public List<Mascota> Buscar(string texto)
        {
            List<Mascota> mascotas = new List<Mascota>();
            string consulta = "SELECT IdMascota, IdPropietario, Nombre, Especie, Raza, " +
                "FechaNacimiento, FechaRegistro FROM Mascota " +
                "WHERE @Busqueda = '' OR CHARINDEX(@Busqueda, Nombre) > 0 OR " +
                "CHARINDEX(@Busqueda, Especie) > 0 OR CHARINDEX(@Busqueda, Raza) > 0 " +
                "ORDER BY IdMascota DESC";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@Busqueda", System.Data.SqlDbType.VarChar, 50).Value = texto;
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                string raza = "";
                if (!lector.IsDBNull(4)) raza = lector.GetString(4);

                mascotas.Add(new Mascota(
                    lector.GetInt32(0), lector.GetInt32(1), lector.GetString(2),
                    lector.GetString(3), raza, lector.GetDateTime(5), lector.GetDateTime(6)));
            }

            return mascotas;
        }

        public bool Eliminar(int idMascota)
        {
            string consulta = "DELETE FROM Mascota WHERE IdMascota = @IdMascota";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdMascota", idMascota);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        public bool Modificar(Mascota mascota)
        {
            string consulta = "UPDATE Mascota SET IdPropietario = @IdPropietario, Nombre = @Nombre, " +
                "Especie = @Especie, Raza = @Raza, FechaNacimiento = @FechaNacimiento " +
                "WHERE IdMascota = @IdMascota";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdMascota", mascota.IdMascota);
            comando.Parameters.AddWithValue("@IdPropietario", mascota.IdPropietario);
            comando.Parameters.AddWithValue("@Nombre", mascota.Nombre);
            comando.Parameters.AddWithValue("@Especie", mascota.Especie);
            if (string.IsNullOrWhiteSpace(mascota.Raza))
                comando.Parameters.AddWithValue("@Raza", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@Raza", mascota.Raza);
            comando.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.Date).Value = mascota.FechaNacimiento.Date;

            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        public bool Guardar(Mascota mascota)
        {
            string consulta = "INSERT INTO Mascota " +
                "(IdPropietario, Nombre, Especie, Raza, FechaNacimiento, FechaRegistro) " +
                "VALUES (@IdPropietario, @Nombre, @Especie, @Raza, @FechaNacimiento, @FechaRegistro)";

            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@IdPropietario", mascota.IdPropietario);
            comando.Parameters.AddWithValue("@Nombre", mascota.Nombre);
            comando.Parameters.AddWithValue("@Especie", mascota.Especie);
            if (string.IsNullOrWhiteSpace(mascota.Raza))
                comando.Parameters.AddWithValue("@Raza", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@Raza", mascota.Raza);
            comando.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.Date).Value = mascota.FechaNacimiento.Date;
            comando.Parameters.AddWithValue("@FechaRegistro", mascota.FechaRegistro);

            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }
    }
}
