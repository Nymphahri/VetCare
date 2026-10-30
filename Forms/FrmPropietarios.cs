using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmPropietarios : Form
    {
        private PropietarioLogica propietarioLogica = new PropietarioLogica();
        private int idPropietarioSeleccionado = 0;
        private DateTime fechaRegistroSeleccionada;

        public FrmPropietarios()
        {
            InitializeComponent();
            txtCedula.MaxLength = 20;
            txtNombre.MaxLength = 50;
            txtApellidos.MaxLength = 80;
            txtTelefono.MaxLength = 20;
            txtCorreo.MaxLength = 100;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            GuardarPropietario(false);
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            if (idPropietarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un propietario de la tabla.");
                return;
            }
            GuardarPropietario(true);
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (idPropietarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un propietario de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Deseas eliminar el propietario seleccionado, con el código " + idPropietarioSeleccionado +
                "? Esta acción elimina su registro de la base de datos.",
                "Confirmar eliminación", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                if (propietarioLogica.Eliminar(idPropietarioSeleccionado))
                    MessageBox.Show("Propietario eliminado correctamente.");
                else
                    MessageBox.Show("El propietario ya no existe. Se actualizará la lista.");

                LimpiarCampos();
                CargarPropietarios();
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar este propietario porque tiene mascotas registradas.",
                        "Propietario con mascotas", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo eliminar el propietario. Comprueba la conexión con SQL Server.", "Error al eliminar");
            }

            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al eliminar el propietario.", "Error");
            }
        }

        private void GuardarPropietario(bool modificar)
        {
            LimpiarErrores();
            txtCedula.Text = txtCedula.Text.Trim();
            txtNombre.Text = txtNombre.Text.Trim();
            txtApellidos.Text = txtApellidos.Text.Trim();
            txtTelefono.Text = txtTelefono.Text.Trim();
            txtCorreo.Text = txtCorreo.Text.Trim();

            if (!MostrarValidacion(txtCedula, lblErrorCedula, propietarioLogica.ValidarCedula(txtCedula.Text))) return;
            if (!MostrarValidacion(txtNombre, lblErrorNombre, propietarioLogica.ValidarTexto(txtNombre.Text, "nombre", 50))) return;
            if (!MostrarValidacion(txtApellidos, lblErrorApellidos, propietarioLogica.ValidarTexto(txtApellidos.Text, "apellidos", 80))) return;
            if (!MostrarValidacion(txtTelefono, lblErrorTelefono, propietarioLogica.ValidarTelefono(txtTelefono.Text))) return;
            if (!MostrarValidacion(txtCorreo, lblErrorCorreo, propietarioLogica.ValidarCorreo(txtCorreo.Text))) return;

            int id = 0;

            DateTime fechaRegistro = DateTime.Now;
            if (modificar)
            {
                id = idPropietarioSeleccionado;
                fechaRegistro = fechaRegistroSeleccionada;
            }
            Propietario propietario = new Propietario(id, txtCedula.Text, txtNombre.Text,
                txtApellidos.Text, txtTelefono.Text, txtCorreo.Text, fechaRegistro);

            try
            {
                bool resultado;
                if (modificar)
                    resultado = propietarioLogica.Modificar(propietario);

                else
                    resultado = propietarioLogica.Guardar(propietario);

                if (resultado)
                {
                    if (modificar)
                        MessageBox.Show("Propietario modificado correctamente.");
                    else
                        MessageBox.Show("Propietario guardado correctamente.");
                    LimpiarCampos();
                    CargarPropietarios();
                }

                else
                {
                    MessageBox.Show("No se guardó el propietario. Revisa los datos e inténtalo nuevamente.");
                }
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MostrarValidacion(txtCedula, lblErrorCedula, "Ya existe un propietario con este documento.");
                }

                else
                {
                    MessageBox.Show("No se pudo guardar. Comprueba la conexión con SQL Server.", "Error al guardar");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar el propietario.", "Error");
            }
        }

        private void FrmPropietarios_Load(object? sender, EventArgs e)
        {
            CargarPropietarios();
        }

        private void dgvPropietarios_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Propietario? propietario = dgvPropietarios.Rows[e.RowIndex].DataBoundItem as Propietario;

            if (propietario == null) return;

            LimpiarErrores();
            idPropietarioSeleccionado = propietario.IdPropietario;
            fechaRegistroSeleccionada = propietario.FechaRegistro;
            txtCedula.Text = propietario.Cedula;
            txtNombre.Text = propietario.Nombre;
            txtApellidos.Text = propietario.Apellidos;
            txtTelefono.Text = propietario.Telefono;
            txtCorreo.Text = propietario.Correo;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void CargarPropietarios()
        {
            try
            {
                dgvPropietarios.DataSource = propietarioLogica.Listar();
                foreach (DataGridViewColumn columna in dgvPropietarios.Columns)
                {
                    switch (columna.Name)
                    {
                        case "IdPropietario": columna.HeaderText = "Código"; break;
                        case "Cedula": columna.HeaderText = "Cédula"; break;
                        case "Telefono": columna.HeaderText = "Teléfono"; break;
                        case "FechaRegistro": columna.HeaderText = "Fecha de registro"; break;
                        case "NombreCompleto": columna.Visible = false; break;
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo cargar la lista de propietarios. Comprueba la conexión con SQL Server.", 
                    "Consulta de propietarios"
                    );
            }
        }

        private bool MostrarValidacion(Control control, Label etiqueta, string mensaje)
        {
            etiqueta.Text = mensaje;
            if (mensaje != "")
            {
                errorProvider.SetError(control, mensaje);
                control.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idPropietarioSeleccionado = 0;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvPropietarios.ClearSelection();
            LimpiarErrores();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCedula.Focus();
        }

        private void LimpiarErrores()
        {
            errorProvider.Clear();
            lblErrorCedula.Text = "";
            lblErrorNombre.Text = "";
            lblErrorApellidos.Text = "";
            lblErrorTelefono.Text = "";
            lblErrorCorreo.Text = "";
        }
    }
}
