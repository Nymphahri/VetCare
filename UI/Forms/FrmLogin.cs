using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmLogin : Form
    {
        private UsuarioLogica usuarioLogica = new UsuarioLogica();
        public Usuario? UsuarioAutenticado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void MostrarError(Control campo, string mensaje)
        {
            errorProvider.SetError(campo, mensaje);
            lblError.Location = new Point(campo.Right + 24, campo.Top);
            lblError.Text = mensaje;
            campo.Focus();
        }

        private void btnIngresar_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            lblError.Text = "";
            if (!UsuarioLogica.NombreValido(txtUsuario.Text))
            {
                MostrarError(txtUsuario, "Escriba su nombre de usuario.");
                return;
            }
            if (txtContrasena.Text.Length == 0)
            {
                MostrarError(txtContrasena, "Escriba su contraseña.");
                return;
            }
            try
            {
                UsuarioAutenticado = usuarioLogica.IniciarSesion(txtUsuario.Text, txtContrasena.Text);
                txtContrasena.Clear();
                if (UsuarioAutenticado == null)
                    MostrarError(txtContrasena, "Usuario o contraseña incorrectos.");
                else if (!UsuarioLogica.EsRolValido(UsuarioAutenticado.Rol))
                {
                    UsuarioAutenticado = null;
                    MostrarError(txtUsuario, "Esta cuenta no tiene un rol con acceso a VetCare.");
                }
                else
                    DialogResult = DialogResult.OK;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar con VetCareDB. Revisa la conexión e intenta de nuevo.", "Inicio de sesión");
            }
        }
    }
}
