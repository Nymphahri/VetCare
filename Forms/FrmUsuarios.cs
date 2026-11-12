using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;

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

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = usuarioLogica.Listar();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo cargar la lista de usuarios. Revisa la conexión con VetCareDB.", "Usuarios");
            }
        }
    }
}
