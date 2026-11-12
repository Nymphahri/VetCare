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
