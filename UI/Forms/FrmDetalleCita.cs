using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmDetalleCita : Form
    {
        private Cita cita;

        private void btnVolver_Click(object? sender, EventArgs e)
        {
            Close();
        }
        private DetalleCitaLogica logica = new DetalleCitaLogica();

        public FrmDetalleCita(Cita cita)
        {
            InitializeComponent();
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Servicio", HeaderText = "Servicio", DataPropertyName = nameof(DetalleCita.NombreServicio) });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Cantidad", HeaderText = "Cantidad", DataPropertyName = nameof(DetalleCita.Cantidad) });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Precio", HeaderText = "Precio aplicado (₡)", DataPropertyName = nameof(DetalleCita.PrecioAplicado),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Subtotal", HeaderText = "Subtotal (₡)", DataPropertyName = nameof(DetalleCita.Subtotal),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
            this.cita = cita;
            lblCita.Text = $"Cita {cita.IdCita}   ·   {cita.NombreMascota}   ·   {cita.FechaHora:dd/MM/yyyy HH:mm}";
            Text = $"Servicios de la cita {cita.IdCita} · {cita.FechaHora:dd/MM/yyyy HH:mm}";
        }

        private void FrmDetalleCita_Load(object? sender, EventArgs e)
        {
            CargarDetalles();
            if (!CitaLogica.PermiteAgregarServicios(cita))
            {
                lblCita.Text += "   ·   Cancelada (solo consulta)";
                lstServicios.Enabled = false;
                txtCantidad.Enabled = false;
                btnAgregarServicio.Enabled = false;
                return;
            }
            try
            {
                foreach (Servicio servicio in new ServicioLogica().ListarActivos())
                {
                    lstServicios.Items.Add(servicio);
                }
                btnAgregarServicio.Enabled = lstServicios.Items.Count > 0;
                if (!btnAgregarServicio.Enabled) MostrarError(lstServicios, "No hay servicios activos.");
            }
            catch (SqlException)
            {
                MostrarError(lstServicios, "No se pudo cargar el catálogo.");
            }
        }

        private void CargarDetalles()
        {
            try
            {
                cita.Detalles = logica.Listar(cita.IdCita);
                dgvDetalles.DataSource = cita.Detalles;
                lblTotal.Text = $"Total de la cita   ₡{cita.Total:N2}";
            }
            catch (SqlException)
            {
                dgvDetalles.DataSource = null;
                lblTotal.Text = "Total sin consultar";
                MessageBox.Show("No se pudieron consultar los servicios registrados.", "Servicios de la cita");
            }
        }

        private void MostrarError(Control campo, string mensaje)
        {
            errorProvider.SetError(campo, mensaje);
            lblError.Location = new Point(campo.Right + 25, campo.Top);
            lblError.Text = mensaje;
            campo.Focus();
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            lblError.Text = "";
            if (lstServicios.SelectedItem is not Servicio servicio)
            {
                MostrarError(lstServicios, "Selecciona un servicio.");
                return;
            }
            string mensaje = logica.ValidarCantidad(txtCantidad.Text, out int cantidad);
            if (mensaje != "")
            {
                MostrarError(txtCantidad, mensaje);
                return;
            }
            try
            {
                if (!logica.Agregar(cita.IdCita, servicio.IdServicio, cantidad))
                {
                    MessageBox.Show("Revisa el estado de la cita y la disponibilidad del servicio antes de reintentar.",
                        "No se agregó el servicio");
                    return;
                }
                txtCantidad.Text = "1";
                lstServicios.ClearSelected();
                CargarDetalles();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MostrarError(lstServicios, "Este servicio ya está registrado en la cita.");
                else
                    MessageBox.Show("No se pudo registrar el servicio. Consulta el detalle antes de reintentar.", "Servicios de la cita");
            }
        }
    }
}
