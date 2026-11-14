using System.Globalization;
using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmServicios : Form
    {
        private ServicioLogica servicioLogica = new ServicioLogica();
        private int idServicioSeleccionado = 0;

        public FrmServicios()
        {
            InitializeComponent();
            lstEstado.SelectedIndex = 0;
        }

        private void FrmServicios_Load(object? sender, EventArgs e)
        {
            CargarServicios();
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            CargarServicios();
            txtBuscar.Focus();
        }

        private void CargarServicios()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                    dgvServicios.DataSource = servicioLogica.Listar();
                else
                    dgvServicios.DataSource = servicioLogica.Buscar(txtBuscar.Text);
                foreach (DataGridViewColumn columna in dgvServicios.Columns)
                {
                    switch (columna.Name)
                    {
                        case "IdServicio": columna.HeaderText = "Código"; break;
                        case "Descripcion": columna.HeaderText = "Descripción"; break;
                        case "Estado": columna.HeaderText = "Activo"; break;
                        case "Precio": columna.DefaultCellStyle.Format = "N2"; break;
                    }
                }
                LimpiarCampos();
                lblResultados.Text = "Resultados: " + dgvServicios.Rows.Count;
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo cargar la lista de servicios.", "Consulta de servicios");
            }
        }

        private bool MostrarValidacion(Control campo, Label etiqueta, string mensaje)
        {
            etiqueta.Text = mensaje;
            errorProvider.SetError(campo, mensaje);
            if (mensaje == "") return true;
            campo.Focus();
            return false;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            GuardarServicio(false);
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            if (idServicioSeleccionado > 0) GuardarServicio(true);
        }

        private void dgvServicios_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Servicio? servicio = dgvServicios.Rows[e.RowIndex].DataBoundItem as Servicio;
            if (servicio == null) return;

            LimpiarErrores();
            idServicioSeleccionado = servicio.IdServicio;
            txtNombre.Text = servicio.Nombre;
            txtDescripcion.Text = servicio.Descripcion;
            txtPrecio.Text = servicio.Precio.ToString("0.00", CultureInfo.InvariantCulture);
            lstEstado.SelectedIndex = servicio.Estado ? 0 : 1;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void GuardarServicio(bool modificar)
        {
            LimpiarErrores();
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            if (!MostrarValidacion(txtNombre, lblErrorNombre, servicioLogica.ValidarNombre(nombre))) return;
            if (!MostrarValidacion(txtDescripcion, lblErrorDescripcion, servicioLogica.ValidarDescripcion(descripcion))) return;

            string textoPrecio = txtPrecio.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(textoPrecio, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture, out decimal precio))
            {
                MostrarValidacion(txtPrecio, lblErrorPrecio, "Escribe un precio sin separadores de miles.");
                return;
            }
            if (!MostrarValidacion(txtPrecio, lblErrorPrecio, servicioLogica.ValidarPrecio(precio))) return;

            Servicio servicio = new Servicio(idServicioSeleccionado, nombre, descripcion, precio, lstEstado.SelectedIndex == 0);
            try
            {
                bool resultado;
                if (modificar)
                    resultado = servicioLogica.Modificar(servicio);
                else
                    resultado = servicioLogica.Guardar(servicio);
                if (resultado)
                {
                    MessageBox.Show(modificar ? "Servicio modificado correctamente." : "Servicio guardado correctamente.");
                    LimpiarCampos();
                    CargarServicios();
                }
                else
                    MessageBox.Show("No se guardó el servicio. Revisa los datos.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MostrarValidacion(txtNombre, lblErrorNombre, "Ya existe un servicio con este nombre.");
                else
                    MessageBox.Show("No se pudo guardar el servicio.", "Error al guardar");
            }
        }

        private void LimpiarErrores()
        {
            errorProvider.Clear();
            lblErrorNombre.Text = "";
            lblErrorDescripcion.Text = "";
            lblErrorPrecio.Text = "";
        }

        private void LimpiarCampos()
        {
            idServicioSeleccionado = 0;
            dgvServicios.ClearSelection();
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            LimpiarErrores();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            lstEstado.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
            txtBuscar.Clear();
            CargarServicios();
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}