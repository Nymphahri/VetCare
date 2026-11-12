using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmUsuarios : Form
    {
        private UsuarioLogica usuarioLogica = new UsuarioLogica();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object? sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void MostrarError(Control campo, string mensaje)
        {
            errorProvider.SetError(campo, mensaje);
            lblError.Location = new Point(campo.Right + 25, campo.Top);
            lblError.Text = mensaje;
            campo.Focus();
        }

        private void btnRegistrar_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            lblError.Text = "";
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError(txtNombre, "Escribe el nombre de usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MostrarError(txtContrasena, "Escribe una contraseña.");
                return;
            }
            if (cboRol.SelectedItem is not string rol)
            {
                MostrarError(cboRol, "Selecciona el rol de la cuenta.");
                return;
            }
            try
            {
                if (!usuarioLogica.Registrar(txtNombre.Text, txtContrasena.Text, rol))
                {
                    MessageBox.Show("Revisa los datos de la cuenta.", "Usuarios");
                    return;
                }
                txtNombre.Clear();
                txtContrasena.Clear();
                cboRol.SelectedIndex = -1;
                txtNombre.Focus();
                CargarUsuarios();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MostrarError(txtNombre, "Ese nombre de usuario ya está registrado.");
                else
                    MessageBox.Show("No se pudo registrar la cuenta. Comprueba la conexión con VetCareDB.", "Usuarios");
            }
        }

        private void dgvUsuarios_SelectionChanged(object? sender, EventArgs e)
        {
            cboNuevoRol.Enabled = dgvUsuarios.SelectedRows.Count == 1;
            if (cboNuevoRol.Enabled && dgvUsuarios.SelectedRows[0].DataBoundItem is Usuario usuario)
                cboNuevoRol.SelectedItem = usuario.Rol;
            else
                cboNuevoRol.SelectedIndex = -1;
            btnCambiarRol.Enabled = false;
        }

        private void cboNuevoRol_SelectedIndexChanged(object? sender, EventArgs e)
        {
            btnCambiarRol.Enabled = dgvUsuarios.SelectedRows.Count == 1
                && dgvUsuarios.SelectedRows[0].DataBoundItem is Usuario usuario
                && cboNuevoRol.SelectedItem is string rol && rol != usuario.Rol;
        }

        private void btnCambiarRol_Click(object? sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count != 1 ||
                dgvUsuarios.SelectedRows[0].DataBoundItem is not Usuario usuario ||
                cboNuevoRol.SelectedItem is not string rol) return;
            try
            {
                if (!usuarioLogica.CambiarRol(usuario, rol))
                    MessageBox.Show("La cuenta cambió. Revisa el listado actualizado.", "Usuarios");
                CargarUsuarios();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo actualizar el rol. Comprueba la conexión con VetCareDB.", "Usuarios");
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = usuarioLogica.Listar();
                dgvUsuarios.ClearSelection();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo cargar la lista de usuarios. Revisa la conexión con VetCareDB.", "Usuarios");
            }
        }
    }
}
