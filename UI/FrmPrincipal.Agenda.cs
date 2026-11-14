using Guna.UI2.WinForms;
using VetCare.UI.Modelos;

namespace VetCare
{
    public partial class FrmPrincipal
    {
        private readonly Guna2Button btnManana = new();
        private readonly Panel marcaActiva = new();
        private Guna2Button? opcionActiva;
        private readonly ContextMenuStrip accionesCita = new();

        private void PrepararAgenda(Usuario usuario)
        {
            Color tinta = Color.FromArgb(21, 62, 61);
            foreach (var seccion in new[] { btnRecepcion, btnAdministracion })
            {
                if (seccion.IsDisposed) continue;
                seccion.FillColor = pnlMenuPrincipal.BackColor;
                seccion.ForeColor = Color.FromArgb(183, 211, 202);
                seccion.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            lblRolMenu.AutoEllipsis = true;
            lblRolMenu.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            lblRolMenu.Text = usuario.NombreUsuario + "\n" + usuario.Rol;
            lblRolMenu.SetBounds(btnSalir.Left + LogicalToDeviceUnits(40), btnSalir.Bottom + LogicalToDeviceUnits(10),
                btnSalir.Width - LogicalToDeviceUnits(40), LogicalToDeviceUnits(42));
            var inicial = new Guna2Button { Text = usuario.NombreUsuario.Substring(0, 1).ToUpperInvariant(),
                Size = new Size(32, 32), BorderRadius = 16, FillColor = Color.FromArgb(127, 207, 185),
                ForeColor = tinta, TabStop = false, Location = new Point(16, lblRolMenu.Top + 3),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
            inicial.Enabled = false;
            inicial.DisabledState.FillColor = inicial.FillColor;
            inicial.DisabledState.ForeColor = tinta;
            pnlMenuPrincipal.Controls.Add(inicial);
            int subir = btnAgenda.Top - lblTituloPrincipal.Bottom - 9;
            foreach (Control boton in new Control[] { btnAgenda, btnRecepcion, btnPropietarios,
                btnMascotas, btnCitasRecepcion, btnAdministracion, btnVeterinarios, btnServicios, btnUsuarios })
                if (!boton.IsDisposed) boton.Top -= subir;
            // Reserva espacio para la cuenta y los botones de salida con ambos grupos abiertos.
            MinimumSize = new Size(MinimumSize.Width, Math.Max(MinimumSize.Height, LogicalToDeviceUnits(660)));
            pnlMenuPrincipal.Controls.Add(marcaActiva);
            marcaActiva.BackColor = Color.FromArgb(127, 207, 185);
            MarcarModulo(null);
            Shown += (_, _) => ActualizarMarca();

            btnCitas.Text = "+ Nueva cita";
            foreach (Control control in new Control[] { btnAnterior, btnSiguiente, btnHoy, btnFechaAgenda })
                control.Height = LogicalToDeviceUnits(44);
            btnFechaAgenda.Width = LogicalToDeviceUnits(292);
            btnFechaAgenda.Font = new Font("Segoe UI", 9F);
            btnManana.Name = "btnManana";
            btnManana.Text = "Mañana";
            btnManana.FillColor = pnlAgenda.BackColor;
            btnManana.ForeColor = tinta;
            btnManana.Size = new Size(LogicalToDeviceUnits(80), btnHoy.Height);
            btnManana.Location = new Point(btnFechaAgenda.Right + 4, btnFechaAgenda.Top);
            btnManana.Click += CambiarDia;
            pnlAgenda.Controls.Add(btnManana);

            resumenAgenda.RowStyles[0].SizeType = SizeType.Percent;
            resumenAgenda.RowStyles[0].Height = 100;
            resumenAgenda.Height = LogicalToDeviceUnits(82);
            CrearTarjeta(lblTotal, "Citas del día", Color.FromArgb(17, 107, 94), 0);
            CrearTarjeta(lblPendientes, "Pendientes", Color.FromArgb(225, 162, 32), 1);
            CrearTarjeta(lblAtendidas, "Atendidas", Color.FromArgb(51, 149, 92), 2);

            int bordeInferior = dgvAgenda.Bottom;
            dgvAgenda.Top = resumenAgenda.Bottom + LogicalToDeviceUnits(14);
            dgvAgenda.Height = bordeInferior - dgvAgenda.Top;
            pnlAviso.Top = dgvAgenda.Top + dgvAgenda.ColumnHeadersHeight;
            pnlAviso.Height = bordeInferior - pnlAviso.Top;
            dgvAgenda.Columns.Insert(3, new DataGridViewTextBoxColumn { Name = "Veterinario", HeaderText = "Veterinario" });
            dgvAgenda.Columns.Add(new DataGridViewButtonColumn { Name = "Acciones", HeaderText = "", FlatStyle = FlatStyle.Flat });
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int[] pesos = { 10, 26, 21, 21, 16, 6 };
            for (int i = 0; i < pesos.Length; i++)
            {
                dgvAgenda.Columns[i].FillWeight = pesos[i];
                dgvAgenda.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvAgenda.Columns[4].MinimumWidth = LogicalToDeviceUnits(89);
            dgvAgenda.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAgenda.RowTemplate.Height = LogicalToDeviceUnits(58);
            dgvAgenda.CellPainting += PintarEstado;
            dgvAgenda.CellContentClick += AbrirAcciones;
            accionesCita.Items.Add("Ver cita", null, (_, _) => AbrirCitaSeleccionada(false));
            accionesCita.Items.Add("Servicios de la cita", null, (_, _) => AbrirCitaSeleccionada(true));
            Disposed += (_, _) => accionesCita.Dispose();
        }

        private void CrearTarjeta(Label valor, string titulo, Color color, int columna)
        {
            var tarjeta = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, Margin = new Padding(3) };
            var franja = new Panel { Dock = DockStyle.Top, Height = LogicalToDeviceUnits(4), BackColor = color };
            var etiqueta = new Label { Dock = DockStyle.Top, Height = LogicalToDeviceUnits(30), Text = titulo,
                TextAlign = ContentAlignment.BottomLeft, Padding = new Padding(10, 0, 0, 0) };
            valor.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            valor.BackColor = Color.White;
            valor.TextAlign = ContentAlignment.MiddleLeft;
            tarjeta.Controls.Add(valor);
            tarjeta.Controls.Add(etiqueta);
            tarjeta.Controls.Add(franja);
            resumenAgenda.Controls.Add(tarjeta, columna, 0);
        }

        private void MarcarModulo(Form? formulario)
        {
            var actual = formulario switch
            {
                FrmPropietarios => btnPropietarios, FrmMascotas => btnMascotas,
                FrmCitas or FrmDetalleCita => btnCitasRecepcion, FrmServicios => btnServicios,
                FrmVeterinarios => btnVeterinarios, FrmUsuarios => btnUsuarios, _ => btnAgenda
            };
            if (opcionActiva != null) opcionActiva.FillColor = pnlMenuPrincipal.BackColor;
            opcionActiva = actual;
            actual.FillColor = Color.FromArgb(44, 88, 80);
            ActualizarMarca();
        }

        private void ActualizarMarca()
        {
            if (opcionActiva == null) return;
            marcaActiva.SetBounds(opcionActiva.Left, opcionActiva.Top, LogicalToDeviceUnits(3), opcionActiva.Height);
            marcaActiva.Visible = opcionActiva.Visible;
            marcaActiva.BringToFront();
        }

        private void PintarEstado(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4 || e.Graphics == null || e.CellStyle == null) return;
            bool seleccionada = (e.State & DataGridViewElementStates.Selected) != 0;
            using var fila = new SolidBrush(seleccionada ? dgvAgenda.DefaultCellStyle.SelectionBackColor : Color.White);
            e.Graphics.FillRectangle(fila, e.CellBounds);
            e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            string texto = Convert.ToString(e.Value) ?? "";
            var tam = TextRenderer.MeasureText(texto, dgvAgenda.Font);
            var caja = new Rectangle(e.CellBounds.Left + 3, e.CellBounds.Top + (e.CellBounds.Height - tam.Height - 6) / 2,
                Math.Min(e.CellBounds.Width - 6, tam.Width + 10), tam.Height + 6);
            using var fondo = new SolidBrush(e.CellStyle.BackColor);
            e.Graphics.FillRoundedRectangle(fondo, caja, new Size(10, 10));
            TextRenderer.DrawText(e.Graphics, texto, dgvAgenda.Font, caja, Color.FromArgb(21, 62, 61),
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            e.Handled = true;
        }

        private void AbrirAcciones(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 || e.RowIndex < 0 || dgvAgenda.Rows[e.RowIndex].Tag is not Cita cita) return;
            accionesCita.Tag = cita;
            Rectangle celda = dgvAgenda.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            accionesCita.Show(dgvAgenda, new Point(celda.Left, celda.Bottom));
        }

        private void AbrirCitaSeleccionada(bool detalle)
        {
            if (accionesCita.Tag is not Cita cita) return;
            btnCitas_Click(btnCitas, EventArgs.Empty);
            if (moduloActual is not FrmCitas formulario || !formulario.SeleccionarCita(cita.IdCita)) return;
            if (detalle) AbrirDetalle(cita);
        }
    }
}
