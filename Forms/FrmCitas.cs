using Microsoft.Data.SqlClient;
using VetCare.UI.Logica;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmCitas : Form
    {
        private CitaLogica citaLogica = new CitaLogica();

        public FrmCitas()
        {
            InitializeComponent();
            dtpFechaHora.Value = DateTime.Now;
        }

        private void FrmCitas_Load(object? sender, EventArgs e)
        {
            try
            {
                lstMascotas.DataSource = new MascotaLogica().Listar();
                lstVeterinarios.DataSource = new VeterinarioLogica().Listar();
                lstMascotas.SelectedIndex = -1;
                lstVeterinarios.SelectedIndex = -1;
                btnAgendar.Enabled = lstMascotas.Items.Count > 0 && lstVeterinarios.Items.Count > 0;
                if (!btnAgendar.Enabled)
                    MessageBox.Show("Para agendar debe haber al menos una mascota y un veterinario registrados.");
            }
            catch (SqlException)
            {
                btnAgendar.Enabled = false;
                MessageBox.Show("No se pudieron cargar las mascotas y los veterinarios.", "Agenda");
            }
            CargarCitas();
        }

        private void FiltrosCita_Changed(object? sender, EventArgs e)
        {
            dtpBuscarFecha.Enabled = chkBuscarFecha.Checked;
            CargarCitas();
        }

        private void CargarCitas()
        {
            try
            {
                DateTime? fecha = chkBuscarFecha.Checked ? dtpBuscarFecha.Value.Date : null;
                string estado = cboBuscarEstado.SelectedIndex > 0 ? cboBuscarEstado.Text : "";
                List<Cita> citas = citaLogica.Listar(txtBuscarMascota.Text, fecha, estado);
                dgvCitas.DataSource = citas;
                lblResultado.Text = citas.Count == 0 ? "Sin citas" : $"Citas: {citas.Count}";
                foreach (DataGridViewColumn columna in dgvCitas.Columns)
                {
                    switch (columna.Name)
                    {
                        case "IdCita": columna.HeaderText = "Código de cita"; break;
                        case "IdMascota": columna.HeaderText = "Código de mascota"; break;
                        case "NombreMascota": columna.HeaderText = "Mascota"; break;
                        case "IdVeterinario": columna.HeaderText = "Código de veterinario"; break;
                        case "FechaHora":
                            columna.HeaderText = "Fecha y hora";
                            columna.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                            break;
                        case "Total":
                        case "Detalles": columna.Visible = false; break;
                    }
                }
                dgvCitas.ClearSelection();
            }
            catch (SqlException)
            {
                dgvCitas.DataSource = null;
                lblResultado.Text = "";
                MessageBox.Show("No se pudo cargar la lista de citas.", "Agenda");
            }
        }

        private void dgvCitas_SelectionChanged(object? sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnConfirmar.Enabled = false;
            btnServicios.Enabled = false;
            btnAtender.Enabled = false;
            btnReprogramarCita.Enabled = false;
            if (dgvCitas.SelectedRows.Count == 0) return;
            Cita? cita = dgvCitas.SelectedRows[0].DataBoundItem as Cita;
            if (cita != null)
            {
                btnServicios.Enabled = true;
                btnConfirmar.Enabled = cita.Estado == "Pendiente";
                btnCancelar.Enabled = cita.Estado == "Pendiente" || cita.Estado == "Confirmada";
                btnAtender.Enabled = cita.Estado == "Pendiente" || cita.Estado == "Confirmada";
                btnReprogramarCita.Enabled = btnAtender.Enabled;
            }
        }

        private void btnReprogramar_Click(object? sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0) return;
            if (dgvCitas.SelectedRows[0].DataBoundItem is not Cita cita) return;
            errorProvider.Clear();
            lblError.Text = "";
            DateTime nuevoHorario = CitaLogica.HorarioAlMinuto(dtpFechaHora.Value);
            if (nuevoHorario == CitaLogica.HorarioAlMinuto(cita.FechaHora))
            {
                MostrarError(dtpFechaHora, "Elige una fecha u hora distinta de la actual.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Mover la cita {cita.IdCita} del {cita.FechaHora:dd/MM/yyyy HH:mm} al {nuevoHorario:dd/MM/yyyy HH:mm}?",
                "Reprogramar cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta != DialogResult.Yes) return;
            try
            {
                if (citaLogica.Reprogramar(cita, nuevoHorario))
                    MessageBox.Show("Cita reprogramada.", "Agenda");
                else
                    MessageBox.Show("La cita cambió. Revisa la agenda actualizada.", "Agenda");
                CargarCitas();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MostrarError(dtpFechaHora, "El veterinario ya tiene una cita en ese horario. Elige otra fecha u hora.");
                else
                    MessageBox.Show("No se pudo reprogramar la cita.", "Agenda");
            }
        }

        private void btnServicios_Click(object? sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0) return;
            if (dgvCitas.SelectedRows[0].DataBoundItem is Cita cita)
            {
                using FrmDetalleCita formulario = new FrmDetalleCita(cita);
                formulario.ShowDialog(this);
            }
        }

        private void btnAtender_Click(object? sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0) return;
            if (dgvCitas.SelectedRows[0].DataBoundItem is not Cita cita) return;
            DialogResult respuesta = MessageBox.Show(
                $"¿Marcar como atendida la cita {cita.IdCita} del {cita.FechaHora:dd/MM/yyyy HH:mm}?",
                "Atender cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                if (!citaLogica.Atender(cita.IdCita))
                    MessageBox.Show("La cita ya no está disponible para atender. Se actualizará la agenda.");
                CargarCitas();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo marcar la cita como atendida.", "Agenda");
            }
        }

        private void btnConfirmar_Click(object? sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0) return;
            Cita? cita = dgvCitas.SelectedRows[0].DataBoundItem as Cita;
            if (cita == null || cita.Estado != "Pendiente") return;

            try
            {
                if (citaLogica.Confirmar(cita.IdCita))
                    MessageBox.Show("Cita confirmada.");
                else
                    MessageBox.Show("La cita ya no está pendiente. Se actualizará la lista.");
                CargarCitas();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo confirmar la cita.", "Agenda");
            }
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0) return;
            Cita? cita = dgvCitas.SelectedRows[0].DataBoundItem as Cita;
            if (cita == null) return;
            DialogResult respuesta = MessageBox.Show(
                $"¿Cancelar la cita {cita.IdCita} del {cita.FechaHora:dd/MM/yyyy HH:mm}?",
                "Cancelar cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta != DialogResult.Yes) return;
            try
            {
                if (citaLogica.Cancelar(cita.IdCita))
                    MessageBox.Show("Cita cancelada. El horario está disponible.");
                else
                    MessageBox.Show("La cita ya no está disponible para cancelar. Se actualizará la lista.");
                CargarCitas();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo cancelar la cita.", "Agenda");
            }
        }

        private void lstMascotas_Format(object? sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Mascota mascota)
                e.Value = mascota.Nombre + " (código " + mascota.IdMascota + ")";
        }

        private void lstVeterinarios_Format(object? sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Veterinario veterinario)
                e.Value = veterinario.NombreCompleto + " (código " + veterinario.IdVeterinario + ")";
        }

        private void MostrarError(Control campo, string mensaje)
        {
            errorProvider.SetError(campo, mensaje);
            lblError.Location = new Point(campo.Right + 25, campo.Top);
            lblError.Text = mensaje;
            campo.Focus();
        }

        private void btnAgendar_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            lblError.Text = "";
            Mascota? mascota = lstMascotas.SelectedItem as Mascota;
            Veterinario? veterinario = lstVeterinarios.SelectedItem as Veterinario;
            if (mascota == null)
            {
                MostrarError(lstMascotas, "Selecciona una mascota.");
                return;
            }
            if (veterinario == null)
            {
                MostrarError(lstVeterinarios, "Selecciona un veterinario.");
                return;
            }

            try
            {
                if (citaLogica.Agendar(mascota.IdMascota, veterinario.IdVeterinario, dtpFechaHora.Value, txtMotivo.Text))
                {
                    MessageBox.Show("Cita agendada en estado Pendiente.");
                    lstMascotas.SelectedIndex = -1;
                    lstVeterinarios.SelectedIndex = -1;
                    txtMotivo.Clear();
                    lstMascotas.Focus();
                    CargarCitas();
                }
                else
                    MessageBox.Show("No se pudo agendar la cita. Revisa los datos.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MostrarError(dtpFechaHora, "Este veterinario ya tiene una cita en ese horario. Elige otra hora u otro veterinario.");
                else if (ex.Number == 547)
                    MessageBox.Show("Revisa la mascota y el veterinario. Vuelve a abrir la pantalla para actualizar las listas.");
                else
                    MessageBox.Show("No se pudo agendar la cita. Comprueba la conexión con SQL Server.");
            }
        }
    }
}
