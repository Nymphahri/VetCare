using System.Data;
using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    public class ServicioDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Servicio> Listar()
        {
            List<Servicio> servicios = new List<Servicio>();
            string consulta = "SELECT IdServicio, Nombre, Descripcion, Precio, Estado " +
                "FROM Servicio ORDER BY IdServicio DESC";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                string descripcion = "";
                if (!lector.IsDBNull(2)) descripcion = lector.GetString(2);

                servicios.Add(new Servicio(lector.GetInt32(0), lector.GetString(1),
                    descripcion, lector.GetDecimal(3), lector.GetBoolean(4)));
            }
            return servicios;
        }

        public bool Guardar(Servicio servicio)
        {
            string consulta = "INSERT INTO Servicio (Nombre, Descripcion, Precio, Estado) " +
                "VALUES (@Nombre, @Descripcion, @Precio, @Estado)";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            AgregarParametros(comando, servicio);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        public bool Modificar(Servicio servicio)
        {
            string consulta = "UPDATE Servicio SET Nombre = @Nombre, Descripcion = @Descripcion, " +
                "Precio = @Precio, Estado = @Estado WHERE IdServicio = @IdServicio";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@IdServicio", SqlDbType.Int).Value = servicio.IdServicio;
            AgregarParametros(comando, servicio);
            conexionSql.Open();
            return comando.ExecuteNonQuery() > 0;
        }

        private void AgregarParametros(SqlCommand comando, Servicio servicio)
        {
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 60).Value = servicio.Nombre;
            SqlParameter descripcion = comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 200);
            if (string.IsNullOrWhiteSpace(servicio.Descripcion))
                descripcion.Value = DBNull.Value;
            else
                descripcion.Value = servicio.Descripcion;

            SqlParameter precio = comando.Parameters.Add("@Precio", SqlDbType.Decimal);
            precio.Precision = 10;
            precio.Scale = 2;
            precio.Value = servicio.Precio;
            comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = servicio.Estado;
        }
    }
}
