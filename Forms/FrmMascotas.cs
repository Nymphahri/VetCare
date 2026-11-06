using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmMascotas : Form
    {
        private MascotaLogica mascotaLogica = new MascotaLogica();
        private PropietarioLogica propietarioLogica = new PropietarioLogica();
        private int idMascotaSeleccionada = 0;
        private DateTime fechaRegistroSeleccionada;

        public FrmMascotas()
        {
            InitializeComponent();
            txtNombre.MaxLength = 50;
            txtEspecie.MaxLength = 30;
            txtRaza.MaxLength = 50;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void FrmMascotas_Load(object? sender, EventArgs e)
        {
            try
            {
                List<Propietario> propietarios = propietarioLogica.Listar();
                lstPropietarios.DisplayMember = "NombreCompleto";
                lstPropietarios.ValueMember = "IdPropietario";
                lstPropietarios.DataSource = propietarios;
                lstPropietarios.SelectedIndex = -1;
                btnGuardar.Enabled = propietarios.Count > 0;
                if (propietarios.Count == 0)
                    MessageBox.Show("Registra un propietario antes de registrar su mascota.");
            }
            catch (Exception)
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("No se pudieron cargar los propietarios. Comprueba la conexión con SQL Server.", "Propietarios");
            }
            CargarMascotas();
        }

        private void lstPropietarios_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Propietario? propietario = lstPropietarios.SelectedItem as Propietario;
            lblCedulaPropietario.Text = "";
            if (propietario != null)
                lblCedulaPropietario.Text = "Cédula: " + propietario.Cedula;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            GuardarMascota(false);
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            if (idMascotaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una mascota de la tabla.");
                return;
            }
            GuardarMascota(true);
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (idMascotaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una mascota de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Deseas eliminar la mascota seleccionada, con el código " + idMascotaSeleccionada +
                "? Esta acción elimina su registro de la base de datos.",
                "Confirmar eliminación", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                if (mascotaLogica.Eliminar(idMascotaSeleccionada))
                    MessageBox.Show("Mascota eliminada correctamente.");
                else
                    MessageBox.Show("La mascota ya no existe. Se actualizará la lista.");

                LimpiarCampos();
                CargarMascotas();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar esta mascota porque tiene citas registradas.",
                        "Mascota con citas", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo eliminar la mascota. Comprueba la conexión con SQL Server.", "Error al eliminar");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al eliminar la mascota.", "Error");
            }
        }

        private void GuardarMascota(bool modificar)
        {
            LimpiarErrores();
            int idPropietario = 0;
            Propietario? propietario = lstPropietarios.SelectedItem as Propietario;
            if (propietario != null) idPropietario = propietario.IdPropietario;

            txtNombre.Text = txtNombre.Text.Trim();
            txtEspecie.Text = txtEspecie.Text.Trim();
            txtRaza.Text = txtRaza.Text.Trim();
            if (!MostrarValidacion(lstPropietarios, lblErrorPropietario, mascotaLogica.ValidarPropietario(idPropietario))) return;
            if (!MostrarValidacion(txtNombre, lblErrorNombre, mascotaLogica.ValidarNombre(txtNombre.Text))) return;
            if (!MostrarValidacion(txtEspecie, lblErrorEspecie, mascotaLogica.ValidarEspecie(txtEspecie.Text))) return;
            if (!MostrarValidacion(txtRaza, lblErrorRaza, mascotaLogica.ValidarRaza(txtRaza.Text))) return;
            if (!MostrarValidacion(dtpFechaNacimiento, lblErrorFecha, mascotaLogica.ValidarFechaNacimiento(dtpFechaNacimiento.Value))) return;

            int idMascota = 0;
            DateTime fechaRegistro = DateTime.Now;
            if (modificar)
            {
                idMascota = idMascotaSeleccionada;
                fechaRegistro = fechaRegistroSeleccionada;
            }
            Mascota mascota = new Mascota(idMascota, idPropietario, txtNombre.Text, txtEspecie.Text,
                txtRaza.Text, dtpFechaNacimiento.Value.Date, fechaRegistro);
            try
            {
                bool resultado;
                if (modificar)
                    resultado = mascotaLogica.Modificar(mascota);
                else
                    resultado = mascotaLogica.Guardar(mascota);

                if (resultado)
                {
                    if (modificar)
                        MessageBox.Show("Mascota modificada correctamente.");
                    else
                        MessageBox.Show("Mascota guardada correctamente.");
                    LimpiarCampos();
                    CargarMascotas();
                }
                else
                    MessageBox.Show("No se guardaron los cambios. Revisa los datos; si el registro ya no existe, cierra y vuelve a abrir esta pantalla.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MostrarValidacion(lstPropietarios, lblErrorPropietario,
                        "El propietario ya no existe. Cierra y vuelve a abrir esta pantalla para actualizar la lista.");
                else
                    MessageBox.Show("No se pudo guardar la mascota. Comprueba la conexión con SQL Server.", "Error al guardar");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar la mascota.", "Error");
            }
        }

        private void dgvMascotas_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Mascota? mascota = dgvMascotas.Rows[e.RowIndex].DataBoundItem as Mascota;
            if (mascota == null) return;
            if (mascota.FechaNacimiento < dtpFechaNacimiento.MinDate ||
                mascota.FechaNacimiento > dtpFechaNacimiento.MaxDate)
            {
                MessageBox.Show("La fecha de esta mascota está fuera del rango del selector de fechas.");
                return;
            }

            LimpiarErrores();
            idMascotaSeleccionada = mascota.IdMascota;
            fechaRegistroSeleccionada = mascota.FechaRegistro;
            lstPropietarios.SelectedValue = mascota.IdPropietario;
            txtNombre.Text = mascota.Nombre;
            txtEspecie.Text = mascota.Especie;
            txtRaza.Text = mascota.Raza;
            dtpFechaNacimiento.Value = mascota.FechaNacimiento;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void CargarMascotas()
        {
            try
            {
                dgvMascotas.DataSource = mascotaLogica.Listar();
                foreach (DataGridViewColumn columna in dgvMascotas.Columns)
                {
                    switch (columna.Name)
                    {
                        case "IdMascota": columna.HeaderText = "Código"; break;
                        case "IdPropietario": columna.HeaderText = "Código propietario"; break;
                        case "FechaNacimiento":
                            columna.HeaderText = "Fecha de nacimiento";
                            columna.DefaultCellStyle.Format = "dd/MM/yyyy";
                            break;
                        case "FechaRegistro": columna.HeaderText = "Fecha de registro"; break;
                        case "Edad": columna.HeaderText = "Edad (años cumplidos)"; break;
                    }
                }
                dgvMascotas.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la lista de mascotas. Comprueba la conexión con SQL Server.", "Consulta de mascotas");
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
            lblErrorPropietario.Text = "";
            lblErrorNombre.Text = "";
            lblErrorEspecie.Text = "";
            lblErrorRaza.Text = "";
            lblErrorFecha.Text = "";
        }

        private void LimpiarCampos()
        {
            idMascotaSeleccionada = 0;
            btnGuardar.Enabled = lstPropietarios.Items.Count > 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvMascotas.ClearSelection();
            LimpiarErrores();
            lstPropietarios.SelectedIndex = -1;
            txtNombre.Clear();
            txtEspecie.Clear();
            txtRaza.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            lstPropietarios.Focus();
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
