using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmVeterinarios : Form
    {
        private VeterinarioLogica veterinarioLogica = new VeterinarioLogica();
        private int idVeterinarioSeleccionado = 0;

        public FrmVeterinarios()
        {
            InitializeComponent();
            txtNombre.MaxLength = 50;
            txtApellidos.MaxLength = 80;
            txtEspecialidad.MaxLength = 60;
            txtTelefono.MaxLength = 20;
        }

        private void FrmVeterinarios_Load(object? sender, EventArgs e)
        {
            CargarVeterinarios();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            GuardarVeterinario(false);
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            if (idVeterinarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un veterinario de la tabla.");
                return;
            }
            GuardarVeterinario(true);
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (idVeterinarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un veterinario de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Deseas eliminar el veterinario seleccionado, con el código " + idVeterinarioSeleccionado +
                "? Esta acción elimina su registro de la base de datos.",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                if (veterinarioLogica.Eliminar(idVeterinarioSeleccionado))
                    MessageBox.Show("Veterinario eliminado correctamente.");
                else
                    MessageBox.Show("El veterinario ya no existe. Se actualizará la lista.");

                LimpiarCampos();
                CargarVeterinarios();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar este veterinario porque tiene citas registradas.",
                        "Veterinario con citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo eliminar el veterinario. Comprueba la conexión con SQL Server.", "Error al eliminar");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al eliminar el veterinario.", "Error");
            }
        }

        private void GuardarVeterinario(bool modificar)
        {
            LimpiarErrores();
            txtNombre.Text = txtNombre.Text.Trim();
            txtApellidos.Text = txtApellidos.Text.Trim();
            txtEspecialidad.Text = txtEspecialidad.Text.Trim();
            txtTelefono.Text = txtTelefono.Text.Trim();

            if (!MostrarValidacion(txtNombre, lblErrorNombre, veterinarioLogica.ValidarTexto(txtNombre.Text, "nombre", 50))) return;
            if (!MostrarValidacion(txtApellidos, lblErrorApellidos, veterinarioLogica.ValidarTexto(txtApellidos.Text, "apellidos", 80))) return;
            if (!MostrarValidacion(txtEspecialidad, lblErrorEspecialidad, veterinarioLogica.ValidarTexto(txtEspecialidad.Text, "especialidad", 60))) return;
            if (!MostrarValidacion(txtTelefono, lblErrorTelefono, veterinarioLogica.ValidarTelefono(txtTelefono.Text))) return;

            int idVeterinario = 0;
            if (modificar) idVeterinario = idVeterinarioSeleccionado;
            Veterinario veterinario = new Veterinario(idVeterinario, txtNombre.Text, txtApellidos.Text,
                txtEspecialidad.Text, txtTelefono.Text);
            try
            {
                bool resultado;
                if (modificar)
                    resultado = veterinarioLogica.Modificar(veterinario);
                else
                    resultado = veterinarioLogica.Guardar(veterinario);

                if (resultado)
                {
                    if (modificar)
                        MessageBox.Show("Veterinario modificado correctamente.");
                    else
                        MessageBox.Show("Veterinario guardado correctamente.");
                    LimpiarCampos();
                    CargarVeterinarios();
                }
                else
                    MessageBox.Show("No se guardaron los cambios. Revisa los datos; si el registro ya no existe, cierra y vuelve a abrir esta pantalla.");
            }
            catch (Microsoft.Data.SqlClient.SqlException)
            {
                MessageBox.Show("No se pudo guardar el veterinario. Comprueba la conexión con SQL Server.", "Error al guardar");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar el veterinario.", "Error");
            }
        }

        private void dgvVeterinarios_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Veterinario? veterinario = dgvVeterinarios.Rows[e.RowIndex].DataBoundItem as Veterinario;
            if (veterinario == null) return;

            LimpiarErrores();
            idVeterinarioSeleccionado = veterinario.IdVeterinario;
            txtNombre.Text = veterinario.Nombre;
            txtApellidos.Text = veterinario.Apellidos;
            txtEspecialidad.Text = veterinario.Especialidad;
            txtTelefono.Text = veterinario.Telefono;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            CargarVeterinarios();
            txtBuscar.Focus();
        }

        private void CargarVeterinarios()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                    dgvVeterinarios.DataSource = veterinarioLogica.Listar();
                else
                    dgvVeterinarios.DataSource = veterinarioLogica.Buscar(txtBuscar.Text);
                foreach (DataGridViewColumn columna in dgvVeterinarios.Columns)
                {
                    switch (columna.Name)
                    {
                        case "IdVeterinario": columna.HeaderText = "Código"; break;
                        case "Telefono": columna.HeaderText = "Teléfono"; break;
                        case "NombreCompleto": columna.Visible = false; break;
                    }
                }
                LimpiarCampos();
                lblResultados.Text = "Resultados: " + dgvVeterinarios.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la lista de veterinarios. Comprueba la conexión con SQL Server.", "Consulta de veterinarios");
            }
        }

        private bool MostrarValidacion(Control control, Label etiqueta, string mensaje)
        {
            etiqueta.Text = mensaje;
            errorProvider.SetError(control, mensaje);
            if (mensaje != "")
            {
                control.Focus();
                return false;
            }
            return true;
        }

        private void LimpiarErrores()
        {
            errorProvider.Clear();
            lblErrorNombre.Text = "";
            lblErrorApellidos.Text = "";
            lblErrorEspecialidad.Text = "";
            lblErrorTelefono.Text = "";
        }

        private void LimpiarCampos()
        {
            idVeterinarioSeleccionado = 0;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvVeterinarios.ClearSelection();
            LimpiarErrores();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEspecialidad.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
            txtBuscar.Clear();
            CargarVeterinarios();
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
