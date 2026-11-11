using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    public class DetalleCitaDatos
    {
        private ConexionBD conexionBD = new ConexionBD();

        public List<DetalleCita> Listar(int idCita)
        {
            const string consulta = @"SELECT d.IdDetalle, d.IdServicio, d.Cantidad, d.PrecioAplicado, s.Nombre
                FROM DetalleCita d INNER JOIN Servicio s ON s.IdServicio = d.IdServicio
                WHERE d.IdCita = @IdCita ORDER BY d.IdDetalle";
            using SqlConnection conexion = conexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdCita", idCita);
            conexion.Open();
            using SqlDataReader lector = comando.ExecuteReader();
            List<DetalleCita> detalles = new List<DetalleCita>();
            while (lector.Read())
            {
                DetalleCita detalle = new DetalleCita(lector.GetInt32(0), idCita,
                    lector.GetInt32(1), lector.GetInt32(2), lector.GetDecimal(3));
                detalle.NombreServicio = lector.GetString(4);
                detalles.Add(detalle);
            }
            return detalles;
        }

        public bool Agregar(int idCita, int idServicio, int cantidad)
        {
            const string consulta = @"INSERT INTO DetalleCita (IdCita, IdServicio, Cantidad, PrecioAplicado)
                SELECT @IdCita, IdServicio, @Cantidad, Precio FROM Servicio
                WHERE IdServicio = @IdServicio AND Estado = 1";
            using SqlConnection conexion = conexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdCita", idCita);
            comando.Parameters.AddWithValue("@IdServicio", idServicio);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            conexion.Open();
            return comando.ExecuteNonQuery() == 1;
        }
    }
}
