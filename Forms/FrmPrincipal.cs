using VetCare.UI.Modelos;
using VetCare.UI.Logica;
using Microsoft.Data.SqlClient;

namespace VetCare
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            lblSesion.Text = $"{usuario.NombreUsuario} ({usuario.Rol})";
            bool esAdministrador = usuario.Rol == "Administrador";
            btnVeterinarios.Enabled = esAdministrador;
            btnServicios.Enabled = esAdministrador;
            btnUsuarios.Enabled = esAdministrador;
        }

        private void CargarAgenda(object? sender, EventArgs e)
        {
            dgvAgenda.Rows.Clear();
            try
            {
                List<Cita> citas = new CitaLogica().Listar(fecha: dtpAgenda.Value.Date);
                citas.Reverse();
                foreach (Cita cita in citas)
                    dgvAgenda.Rows.Add(cita.FechaHora.ToString("HH:mm"), cita.NombreMascota, cita.Motivo, cita.Estado);
                lblResultado.Text = citas.Count == 0 ? "No hay citas registradas para esta fecha." : $"Citas registradas: {citas.Count}";
                dgvAgenda.ClearSelection();
            }
            catch (SqlException)
            {
                lblResultado.Text = "No se pudo cargar la agenda. Comprueba la conexión y pulsa Actualizar.";
            }
        }

        private void btnPropietarios_Click(object? sender, EventArgs e)
        {
            using FrmPropietarios formulario = new FrmPropietarios();
            formulario.ShowDialog(this);
        }

        private void btnMascotas_Click(object? sender, EventArgs e)
        {
            using FrmMascotas formulario = new FrmMascotas();
            formulario.ShowDialog(this);
        }

        private void btnCitas_Click(object? sender, EventArgs e)
        {
            using FrmCitas formulario = new FrmCitas();
            formulario.ShowDialog(this);
            CargarAgenda(this, EventArgs.Empty);
        }

        private void btnVeterinarios_Click(object? sender, EventArgs e)
        {
            using FrmVeterinarios formulario = new FrmVeterinarios();
            formulario.ShowDialog(this);
        }

        private void btnUsuarios_Click(object? sender, EventArgs e)
        {
            using FrmUsuarios formulario = new FrmUsuarios();
            formulario.ShowDialog(this);
        }

        private void btnServicios_Click(object? sender, EventArgs e)
        {
            using FrmServicios formulario = new FrmServicios();
            formulario.ShowDialog(this);
        }
    }
}
