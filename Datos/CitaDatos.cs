using System.Data;
using Microsoft.Data.SqlClient;
using VetCare.UI.Modelos;

namespace VetCare.UI.Datos
{
    public class CitaDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Cita> Listar(string nombreMascota = "", DateTime? fecha = null, string estado = "")
        {
            List<Cita> citas = new List<Cita>();
            string consulta = "SELECT c.IdCita, c.IdMascota, c.IdVeterinario, c.FechaHora, c.Estado, c.Motivo " +
                "FROM Cita c INNER JOIN Mascota m ON m.IdMascota = c.IdMascota " +
                "WHERE (@Nombre = '' OR CHARINDEX(@Nombre, m.Nombre) > 0) " +
                "AND (@Fecha IS NULL OR CAST(c.FechaHora AS date) = @Fecha) " +
                "AND (@Estado = '' OR c.Estado = @Estado) " +
                "ORDER BY c.FechaHora DESC, c.IdCita DESC";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombreMascota;
            comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = (object?)fecha ?? DBNull.Value;
            comando.Parameters.Add("@Estado", SqlDbType.VarChar, 15).Value = estado;
            conexionSql.Open();
            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                string motivo = "";
                if (!lector.IsDBNull(5)) motivo = lector.GetString(5);
                citas.Add(new Cita(lector.GetInt32(0), lector.GetInt32(1), lector.GetInt32(2),
                    lector.GetDateTime(3), lector.GetString(4), motivo));
            }
            return citas;
        }

        public bool Confirmar(int idCita)
        {
            string consulta = "UPDATE Cita SET Estado = 'Confirmada' " +
                "WHERE IdCita = @IdCita AND Estado = 'Pendiente'";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita;
            conexionSql.Open();
            return comando.ExecuteNonQuery() == 1;
        }

        public bool Atender(int idCita)
        {
            string consulta = "UPDATE Cita SET Estado = 'Atendida' WHERE IdCita = @IdCita " +
                "AND Estado IN ('Pendiente', 'Confirmada')";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita;
            conexionSql.Open();
            return comando.ExecuteNonQuery() == 1;
        }

        public bool Cancelar(int idCita)
        {
            string consulta = "UPDATE Cita SET Estado = 'Cancelada' WHERE IdCita = @IdCita " +
                "AND Estado IN ('Pendiente', 'Confirmada')";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita;
            conexionSql.Open();
            return comando.ExecuteNonQuery() == 1;
        }

        public bool Agendar(Cita cita)
        {
            string consulta = "INSERT INTO Cita (IdMascota, IdVeterinario, FechaHora, Estado, Motivo) " +
                "VALUES (@Mascota, @Veterinario, @FechaHora, @Estado, @Motivo)";
            using SqlConnection conexionSql = conexion.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.Add("@Mascota", SqlDbType.Int).Value = cita.IdMascota;
            comando.Parameters.Add("@Veterinario", SqlDbType.Int).Value = cita.IdVeterinario;
            comando.Parameters.Add("@FechaHora", SqlDbType.DateTime).Value = cita.FechaHora;
            comando.Parameters.Add("@Estado", SqlDbType.VarChar, 15).Value = cita.Estado;
            SqlParameter motivo = comando.Parameters.Add("@Motivo", SqlDbType.VarChar, 200);
            if (cita.Motivo == "") motivo.Value = DBNull.Value;
            else motivo.Value = cita.Motivo;
            conexionSql.Open();
            return comando.ExecuteNonQuery() == 1;
        }
    }
}
