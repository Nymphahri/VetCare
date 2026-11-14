using VetCare.UI.Modelos;
using VetCare.UI.Logica;
using Microsoft.Data.SqlClient;

namespace VetCare
{
    public partial class FrmPrincipal : Form
    {
        private Form? moduloActual;
        private FrmCitas? citasEnEspera;
        private readonly bool esAdministrador;

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            esAdministrador = usuario.Rol == "Administrador";
            if (esAdministrador)
                ConfigurarMenuAdministrador();
            else if (usuario.Rol == "Recepcionista")
                ConfigurarMenuRecepcion();
            else
                throw new ArgumentException("El rol no tiene un menú asignado.", nameof(usuario));
            PrepararAgenda(usuario);
            MostrarOpcionesRecepcion(false);
        }

        private void ConfigurarMenuRecepcion()
        {
            Text = "VetCare · Recepción";
            lblRolMenu.Text = "Menú de recepción";
            btnAdministracion.Dispose();
            btnVeterinarios.Dispose();
            btnServicios.Dispose();
            btnUsuarios.Dispose();
        }

        private void ConfigurarMenuAdministrador()
        {
            Text = "VetCare · Administrador";
            lblRolMenu.Text = "Menú de administrador";
            MostrarOpcionesAdministracion(false);
        }

        private void btnRecepcion_Click(object? sender, EventArgs e)
        {
            MostrarOpcionesRecepcion(!btnPropietarios.Visible);
        }

        private void MostrarOpcionesRecepcion(bool desplegar)
        {
            btnPropietarios.Visible = desplegar;
            btnMascotas.Visible = desplegar;
            btnCitasRecepcion.Visible = desplegar;
            btnRecepcion.Text = desplegar ? "RECEPCIÓN   ▾" : "RECEPCIÓN   ▸";
            ActualizarMarca();
            if (!esAdministrador) return;

            int separacion = btnPropietarios.Top - btnRecepcion.Bottom;
            int nuevaPosicion = desplegar ? btnCitasRecepcion.Bottom + separacion : btnRecepcion.Bottom + separacion;
            int desplazamiento = nuevaPosicion - btnAdministracion.Top;
            btnAdministracion.Top += desplazamiento;
            btnVeterinarios.Top += desplazamiento;
            btnServicios.Top += desplazamiento;
            btnUsuarios.Top += desplazamiento;
            ActualizarMarca();
        }

        private void btnAdministracion_Click(object? sender, EventArgs e)
        {
            if (!esAdministrador) return;
            MostrarOpcionesAdministracion(!btnVeterinarios.Visible);
        }

        private void MostrarOpcionesAdministracion(bool desplegar)
        {
            bool mostrar = esAdministrador && desplegar;
            btnVeterinarios.Visible = mostrar;
            btnServicios.Visible = mostrar;
            btnUsuarios.Visible = mostrar;
            btnAdministracion.Text = mostrar ? "ADMINISTRACIÓN   ▾" : "ADMINISTRACIÓN   ▸";
            ActualizarMarca();
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click(object? sender, EventArgs e)
        {
            pnlMenuPrincipal.Visible = !pnlMenuPrincipal.Visible;
            btnMenuEsconder.AccessibleName = pnlMenuPrincipal.Visible ? "Ocultar menú lateral" : "Mostrar menú lateral";
        }

        private void CambiarDia(object? sender, EventArgs e)
        {
            DateTime fecha = btnFechaAgenda.Value;
            if (sender == btnHoy) fecha = DateTime.Today;
            else if (sender == btnManana) fecha = DateTime.Today.AddDays(1);
            else if (sender == btnAnterior && fecha > btnFechaAgenda.MinDate) fecha = fecha.AddDays(-1);
            else if (sender == btnSiguiente && fecha < btnFechaAgenda.MaxDate) fecha = fecha.AddDays(1);
            btnFechaAgenda.Value = fecha;
        }

        private void CentrarAviso(object? sender, EventArgs e)
        {
            int separacion = LogicalToDeviceUnits(8);
            int altoBloque = picHuella.Height + separacion + lblResultado.Height;
            if (btnAgendarVacia.Visible) altoBloque += separacion + btnAgendarVacia.Height;
            int ancho = pnlAviso.ClientSize.Width;
            picHuella.Location = new Point((ancho - picHuella.Width) / 2, (pnlAviso.ClientSize.Height - altoBloque) / 2);
            lblResultado.Width = ancho;
            lblResultado.Location = new Point(0, picHuella.Bottom + separacion);
            btnAgendarVacia.Location = new Point((pnlAviso.ClientSize.Width - btnAgendarVacia.Width) / 2,
                lblResultado.Bottom + separacion);
        }

        private void CargarAgenda(object? sender, EventArgs e)
        {
            dgvAgenda.Rows.Clear();
            bool hoy = btnFechaAgenda.Value.Date == DateTime.Today;
            btnHoy.FillColor = hoy ? Color.FromArgb(17, 107, 94) : Color.FromArgb(225, 238, 231);
            btnHoy.ForeColor = hoy ? Color.White : Color.FromArgb(21, 62, 61);
            try
            {
                List<Cita> citas = new CitaLogica().Listar(fecha: btnFechaAgenda.Value);
                citas.Reverse();
                int pendientes = 0;
                int atendidas = 0;
                foreach (Cita cita in citas)
                {
                    int fila = dgvAgenda.Rows.Add(cita.FechaHora.ToString("HH:mm"), cita.NombreMascota + "\n" + cita.NombrePropietario + " · " + cita.Especie, cita.Motivo, cita.NombreVeterinario, cita.Estado, "⋮");
                    dgvAgenda.Rows[fila].Tag = cita;
                    dgvAgenda.Rows[fila].Cells[5].ToolTipText = "Opciones de la cita " + cita.IdCita;
                    var estilo = dgvAgenda.Rows[fila].Cells[4].Style;
                    switch (cita.Estado)
                    {
                        case "Pendiente":
                            pendientes++;
                            estilo.BackColor = Color.FromArgb(253, 238, 215);
                            break;
                        case "Atendida":
                            atendidas++;
                            estilo.BackColor = Color.FromArgb(219, 241, 230);
                            break;
                        case "Confirmada": estilo.BackColor = Color.FromArgb(222, 238, 250); break;
                        case "Cancelada": estilo.BackColor = Color.FromArgb(229, 233, 231); break;
                    }
                }
                lblTotal.Text = citas.Count.ToString();
                lblPendientes.Text = pendientes.ToString();
                lblAtendidas.Text = atendidas.ToString();
                bool esHoy = btnFechaAgenda.Value == DateTime.Today;
                lblResultado.Text = (esHoy ? "No hay citas para hoy." : "No hay citas para esta fecha.")
                    + "\nLas citas que agendes aparecerán aquí.";
                pnlAviso.Visible = citas.Count == 0;
                btnCitas.Visible = citas.Count > 0;
                btnAgendarVacia.Visible = true;
                CentrarAviso(this, EventArgs.Empty);
                dgvAgenda.ClearSelection();
            }
            catch (SqlException)
            {
                lblTotal.Text = lblPendientes.Text = lblAtendidas.Text = "—";
                pnlAviso.Visible = true;
                btnCitas.Visible = true;
                btnAgendarVacia.Visible = false;
                CentrarAviso(this, EventArgs.Empty);
                lblResultado.Text = "No se pudo cargar la agenda. Comprueba la conexión y vuelve a pulsar Agenda.";
            }
        }

        private void btnPropietarios_Click(object? sender, EventArgs e)
        {
            if (moduloActual is FrmPropietarios) return;
            MostrarModulo(new FrmPropietarios());
        }

        private void btnMascotas_Click(object? sender, EventArgs e)
        {
            if (moduloActual is FrmMascotas) return;
            MostrarModulo(new FrmMascotas());
        }

        private void MostrarModulo(Form formulario)
        {
            CerrarModulos();
            InsertarModulo(formulario);
        }

        private void InsertarModulo(Form formulario)
        {
            pnlMenuPrincipal.Visible = true;
            btnMenuEsconder.AccessibleName = "Ocultar menú lateral";
            pnlModulo.AutoScrollPosition = Point.Empty;
            moduloActual = formulario;
            Size espacioFicha = formulario.ClientSize;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.MinimumSize = espacioFicha;
            formulario.FormClosed += modulo_FormClosed;
            pnlAgenda.Visible = false;
            pnlModulo.Visible = true;
            pnlModulo.Controls.Add(formulario);
            AjustarModulo();
            formulario.Show();
            MarcarModulo(formulario);
        }

        private void pnlModulo_ClientSizeChanged(object? sender, EventArgs e)
        {
            AjustarModulo();
        }

        private void AjustarModulo()
        {
            if (moduloActual != null)
                moduloActual.Size = new Size(Math.Max(moduloActual.MinimumSize.Width, pnlModulo.ClientSize.Width),
                    Math.Max(moduloActual.MinimumSize.Height, pnlModulo.ClientSize.Height));
        }

        private void btnAgenda_Click(object? sender, EventArgs e)
        {
            CerrarModulos();
            MostrarAgenda();
        }

        private void CerrarModulos()
        {
            if (moduloActual != null)
            {
                moduloActual.FormClosed -= modulo_FormClosed;
                moduloActual.Dispose();
                moduloActual = null;
            }
            citasEnEspera?.Dispose();
            citasEnEspera = null;
        }

        private void MostrarAgenda()
        {
            pnlModulo.Visible = false;
            pnlAgenda.Visible = true;
            MarcarModulo(null);
            CargarAgenda(this, EventArgs.Empty);
        }

        private void modulo_FormClosed(object? sender, FormClosedEventArgs e)
        {
            moduloActual = citasEnEspera;
            citasEnEspera = null;
            if (moduloActual == null)
                MostrarAgenda();
            else
            {
                pnlModulo.AutoScrollPosition = Point.Empty;
                AjustarModulo();
                moduloActual.Show();
            }
        }

        private void btnCitas_Click(object? sender, EventArgs e)
        {
            if (moduloActual is FrmCitas) return;
            if (moduloActual is FrmDetalleCita && citasEnEspera != null)
            {
                moduloActual.Close();
                return;
            }
            var citas = sender == btnCitasRecepcion ? new FrmCitas() : new FrmCitas(btnFechaAgenda.Value);
            citas.VerServicios += AbrirDetalle;
            MostrarModulo(citas);
        }

        private void AbrirDetalle(Cita cita)
        {
            if (moduloActual is not FrmCitas citas) return;
            citasEnEspera = citas;
            citas.Hide();
            InsertarModulo(new FrmDetalleCita(cita));
        }

        private void btnVeterinarios_Click(object? sender, EventArgs e)
        {
            if (!esAdministrador || moduloActual is FrmVeterinarios) return;
            MostrarModulo(new FrmVeterinarios());
        }

        private void btnUsuarios_Click(object? sender, EventArgs e)
        {
            if (!esAdministrador || moduloActual is FrmUsuarios) return;
            MostrarModulo(new FrmUsuarios());
        }

        private void btnServicios_Click(object? sender, EventArgs e)
        {
            if (!esAdministrador || moduloActual is FrmServicios) return;
            MostrarModulo(new FrmServicios());
        }
    }
}
