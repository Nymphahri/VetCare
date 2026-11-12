using VetCare.UI.Modelos;

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
