using VetCare.UI.UI;

namespace VetCare
{
    partial class FrmCitas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            errorProvider = new ErrorProvider(components);
            lblMascota = new Label();
            lstMascotas = new ListBox();
            lblVeterinario = new Label();
            lstVeterinarios = new ListBox();
            lblFecha = new Label();
            dtpFechaHora = new SelectorFecha();
            lblMotivo = new Label();
            txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            btnAgendar = new Guna.UI2.WinForms.Guna2GradientButton();
            lblError = new Label();
            dgvCitas = new Guna.UI2.WinForms.Guna2DataGridView();
            btnCancelar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnConfirmar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnServicios = new Guna.UI2.WinForms.Guna2GradientButton();
            btnReprogramarCita = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBuscarMascota = new Label();
            txtBuscarMascota = new Guna.UI2.WinForms.Guna2TextBox();
            lblResultado = new Label();
            chkBuscarFecha = new Guna.UI2.WinForms.Guna2CheckBox();
            dtpBuscarFecha = new SelectorFecha();
            cboBuscarEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            lblBuscarEstado = new Label();
            btnAtender = new Guna.UI2.WinForms.Guna2GradientButton();
            lblAgendaCitas = new Label();
            lblProgramarCita = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblMascota
            // 
            lblMascota.AutoSize = true;
            lblMascota.Location = new Point(24, 78);
            lblMascota.Name = "lblMascota";
            lblMascota.Size = new Size(52, 15);
            lblMascota.TabIndex = 15;
            lblMascota.Text = "Mascota";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.HorizontalScrollbar = true;
            lstMascotas.HorizontalScrollbar = true;
            lstMascotas.Location = new Point(24, 99);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(210, 64);
            lstMascotas.TabIndex = 0;
            lstMascotas.Format += lstMascotas_Format;
            // 
            // lblVeterinario
            // 
            lblVeterinario.AutoSize = true;
            lblVeterinario.Location = new Point(24, 185);
            lblVeterinario.Name = "lblVeterinario";
            lblVeterinario.Size = new Size(63, 15);
            lblVeterinario.TabIndex = 16;
            lblVeterinario.Text = "Veterinario";
            // 
            // lstVeterinarios
            // 
            lstVeterinarios.FormattingEnabled = true;
            lstVeterinarios.HorizontalScrollbar = true;
            lstVeterinarios.Location = new Point(24, 207);
            lstVeterinarios.Name = "lstVeterinarios";
            lstVeterinarios.Size = new Size(210, 64);
            lstVeterinarios.TabIndex = 1;
            lstVeterinarios.Format += lstVeterinarios_Format;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(24, 299);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 15);
            lblFecha.TabIndex = 17;
            lblFecha.Text = "Fecha y hora";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.BorderRadius = 10;
            dtpFechaHora.CustomizableEdges = customizableEdges17;
            dtpFechaHora.FillColor = Color.FromArgb(230, 240, 235);
            dtpFechaHora.Font = new Font("Segoe UI", 9F);
            dtpFechaHora.ForeColor = Color.FromArgb(21, 62, 61);
            dtpFechaHora.IncluirHora = true;
            dtpFechaHora.Location = new Point(24, 322);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.ShadowDecoration.CustomizableEdges = customizableEdges18;
            dtpFechaHora.Size = new Size(210, 38);
            dtpFechaHora.TabIndex = 2;
            dtpFechaHora.Text = "13/11/2026 00:00  ▾";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(24, 395);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(45, 15);
            lblMotivo.TabIndex = 18;
            lblMotivo.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.CustomizableEdges = customizableEdges19;
            txtMotivo.DefaultText = "";
            txtMotivo.Font = new Font("Segoe UI", 9F);
            txtMotivo.Location = new Point(24, 417);
            txtMotivo.MaxLength = 200;
            txtMotivo.BorderRadius = 5;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "opcional";
            txtMotivo.SelectedText = "";
            txtMotivo.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtMotivo.Size = new Size(320, 38);
            txtMotivo.TabIndex = 3;
            // 
            // btnAgendar
            // 
            btnAgendar.BorderRadius = 6;
            btnAgendar.CustomizableEdges = customizableEdges21;
            btnAgendar.FillColor = Color.FromArgb(17, 107, 94);
            btnAgendar.FillColor2 = Color.FromArgb(17, 107, 94);
            btnAgendar.Font = new Font("Segoe UI", 9F);
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(24, 471);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnAgendar.Size = new Size(145, 40);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "Agendar";
            btnAgendar.Click += btnAgendar_Click;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(258, 99);
            lblError.Name = "lblError";
            lblError.Size = new Size(130, 90);
            lblError.TabIndex = 19;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitas.ColumnHeadersHeight = 38;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCitas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.GridColor = Color.FromArgb(231, 229, 255);
            dgvCitas.Location = new Point(405, 181);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.RowTemplate.Height = 32;
            dgvCitas.Size = new Size(566, 268);
            dgvCitas.TabIndex = 13;
            dgvCitas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(222, 235, 229);
            dgvCitas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCitas.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(21, 62, 61);
            dgvCitas.ThemeStyle.HeaderStyle.Height = 38;
            dgvCitas.ThemeStyle.ReadOnly = true;
            dgvCitas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCitas.ThemeStyle.RowsStyle.Height = 32;
            dgvCitas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dgvCitas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(21, 62, 61);
            dgvCitas.SelectionChanged += dgvCitas_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BorderRadius = 6;
            btnCancelar.CustomizableEdges = customizableEdges9;
            btnCancelar.Enabled = false;
            btnCancelar.FillColor = Color.FromArgb(249, 232, 228);
            btnCancelar.FillColor2 = Color.FromArgb(249, 232, 228);
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.FromArgb(129, 49, 45);
            btnCancelar.Location = new Point(675, 471);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelar.Size = new Size(118, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar cita";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmar.BorderRadius = 6;
            btnConfirmar.CustomizableEdges = customizableEdges11;
            btnConfirmar.Enabled = false;
            btnConfirmar.FillColor = Color.FromArgb(224, 238, 232);
            btnConfirmar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnConfirmar.Font = new Font("Segoe UI", 9F);
            btnConfirmar.ForeColor = Color.FromArgb(21, 62, 61);
            btnConfirmar.Location = new Point(405, 471);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnConfirmar.Size = new Size(130, 40);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar cita";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnServicios
            // 
            btnServicios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnServicios.BorderRadius = 6;
            btnServicios.CustomizableEdges = customizableEdges15;
            btnServicios.Enabled = false;
            btnServicios.FillColor = Color.FromArgb(224, 238, 232);
            btnServicios.FillColor2 = Color.FromArgb(224, 238, 232);
            btnServicios.Font = new Font("Segoe UI", 9F);
            btnServicios.ForeColor = Color.FromArgb(21, 62, 61);
            btnServicios.Location = new Point(803, 471);
            btnServicios.Name = "btnServicios";
            btnServicios.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnServicios.Size = new Size(168, 40);
            btnServicios.TabIndex = 8;
            btnServicios.Text = "Servicios de la cita";
            btnServicios.Click += btnServicios_Click;
            // 
            // btnReprogramarCita
            // 
            btnReprogramarCita.BorderRadius = 6;
            btnReprogramarCita.CustomizableEdges = customizableEdges1;
            btnReprogramarCita.Enabled = false;
            btnReprogramarCita.FillColor = Color.FromArgb(224, 238, 232);
            btnReprogramarCita.FillColor2 = Color.FromArgb(224, 238, 232);
            btnReprogramarCita.Font = new Font("Segoe UI", 9F);
            btnReprogramarCita.ForeColor = Color.FromArgb(21, 62, 61);
            btnReprogramarCita.Location = new Point(179, 471);
            btnReprogramarCita.Name = "btnReprogramarCita";
            btnReprogramarCita.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReprogramarCita.Size = new Size(165, 40);
            btnReprogramarCita.TabIndex = 2;
            btnReprogramarCita.Text = "Reprogramar cita";
            btnReprogramarCita.Click += btnReprogramar_Click;
            // 
            // lblBuscarMascota
            // 
            lblBuscarMascota.AutoSize = true;
            lblBuscarMascota.Location = new Point(405, 78);
            lblBuscarMascota.Name = "lblBuscarMascota";
            lblBuscarMascota.Size = new Size(111, 15);
            lblBuscarMascota.TabIndex = 13;
            lblBuscarMascota.Text = "Buscar por mascota";
            // 
            // txtBuscarMascota
            // 
            txtBuscarMascota.CustomizableEdges = customizableEdges7;
            txtBuscarMascota.DefaultText = "";
            txtBuscarMascota.Font = new Font("Segoe UI", 9F);
            txtBuscarMascota.Location = new Point(405, 101);
            txtBuscarMascota.MaxLength = 50;
            txtBuscarMascota.BorderRadius = 5;
            txtBuscarMascota.Name = "txtBuscarMascota";
            txtBuscarMascota.PlaceholderText = "Nombre de la mascota";
            txtBuscarMascota.SelectedText = "";
            txtBuscarMascota.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBuscarMascota.Size = new Size(199, 36);
            txtBuscarMascota.TabIndex = 9;
            txtBuscarMascota.TextChanged += FiltrosCita_Changed;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(405, 152);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 14;
            // 
            // chkBuscarFecha
            // 
            chkBuscarFecha.AutoSize = true;
            chkBuscarFecha.CheckedState.BorderRadius = 0;
            chkBuscarFecha.CheckedState.BorderThickness = 0;
            chkBuscarFecha.Location = new Point(617, 75);
            chkBuscarFecha.Name = "chkBuscarFecha";
            chkBuscarFecha.Size = new Size(109, 19);
            chkBuscarFecha.TabIndex = 10;
            chkBuscarFecha.Text = "Filtrar por fecha";
            chkBuscarFecha.UncheckedState.BorderRadius = 0;
            chkBuscarFecha.UncheckedState.BorderThickness = 0;
            chkBuscarFecha.CheckedChanged += FiltrosCita_Changed;
            // 
            // dtpBuscarFecha
            // 
            dtpBuscarFecha.BorderRadius = 10;
            dtpBuscarFecha.CustomizableEdges = customizableEdges3;
            dtpBuscarFecha.Enabled = false;
            dtpBuscarFecha.FillColor = Color.FromArgb(230, 240, 235);
            dtpBuscarFecha.Font = new Font("Segoe UI", 9F);
            dtpBuscarFecha.ForeColor = Color.FromArgb(21, 62, 61);
            dtpBuscarFecha.Location = new Point(617, 101);
            dtpBuscarFecha.Name = "dtpBuscarFecha";
            dtpBuscarFecha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpBuscarFecha.Size = new Size(150, 36);
            dtpBuscarFecha.TabIndex = 11;
            dtpBuscarFecha.Text = "13/11/2026  ▾";
            dtpBuscarFecha.ValueChanged += FiltrosCita_Changed;
            // 
            // cboBuscarEstado
            // 
            cboBuscarEstado.BackColor = Color.Transparent;
            cboBuscarEstado.CustomizableEdges = customizableEdges5;
            cboBuscarEstado.DrawMode = DrawMode.OwnerDrawFixed;
            cboBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarEstado.FocusedColor = Color.Empty;
            cboBuscarEstado.Font = new Font("Segoe UI", 10F);
            cboBuscarEstado.ForeColor = Color.FromArgb(68, 88, 112);
            cboBuscarEstado.ItemHeight = 30;
            cboBuscarEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Confirmada", "Atendida", "Cancelada" });
            cboBuscarEstado.Location = new Point(780, 101);
            cboBuscarEstado.BorderRadius = 5;
            cboBuscarEstado.Name = "cboBuscarEstado";
            cboBuscarEstado.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboBuscarEstado.Size = new Size(165, 36);
            cboBuscarEstado.TabIndex = 12;
            cboBuscarEstado.SelectedIndexChanged += FiltrosCita_Changed;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.AutoSize = true;
            lblBuscarEstado.Location = new Point(780, 78);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(92, 15);
            lblBuscarEstado.TabIndex = 12;
            lblBuscarEstado.Text = "Estado de la cita";
            // 
            // btnAtender
            // 
            btnAtender.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtender.BorderRadius = 6;
            btnAtender.CustomizableEdges = customizableEdges13;
            btnAtender.Enabled = false;
            btnAtender.FillColor = Color.FromArgb(224, 238, 232);
            btnAtender.FillColor2 = Color.FromArgb(224, 238, 232);
            btnAtender.Font = new Font("Segoe UI", 9F);
            btnAtender.ForeColor = Color.FromArgb(21, 62, 61);
            btnAtender.Location = new Point(545, 471);
            btnAtender.Name = "btnAtender";
            btnAtender.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAtender.Size = new Size(120, 40);
            btnAtender.TabIndex = 6;
            btnAtender.Text = "Atender cita";
            btnAtender.Click += btnAtender_Click;
            // 
            // lblAgendaCitas
            // 
            lblAgendaCitas.AutoSize = true;
            lblAgendaCitas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAgendaCitas.Location = new Point(405, 21);
            lblAgendaCitas.Name = "lblAgendaCitas";
            lblAgendaCitas.Size = new Size(221, 37);
            lblAgendaCitas.TabIndex = 0;
            lblAgendaCitas.Text = "Agenda de citas";
            // 
            // lblProgramarCita
            // 
            lblProgramarCita.AutoSize = true;
            lblProgramarCita.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblProgramarCita.Location = new Point(24, 21);
            lblProgramarCita.Name = "lblProgramarCita";
            lblProgramarCita.Size = new Size(210, 37);
            lblProgramarCita.TabIndex = 1;
            lblProgramarCita.Text = "Programar cita";
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 247);
            FormBorderStyle = FormBorderStyle.None;
            ClientSize = new Size(995, 550);
            Controls.Add(lblAgendaCitas);
            Controls.Add(lblProgramarCita);
            Controls.Add(btnReprogramarCita);
            Controls.Add(chkBuscarFecha);
            Controls.Add(dtpBuscarFecha);
            Controls.Add(lblBuscarEstado);
            Controls.Add(cboBuscarEstado);
            Controls.Add(lblBuscarMascota);
            Controls.Add(txtBuscarMascota);
            Controls.Add(lblResultado);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAtender);
            Controls.Add(btnServicios);
            Controls.Add(dgvCitas);
            Controls.Add(lblMascota);
            Controls.Add(lstMascotas);
            Controls.Add(lblVeterinario);
            Controls.Add(lstVeterinarios);
            Controls.Add(lblFecha);
            Controls.Add(dtpFechaHora);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(btnAgendar);
            Controls.Add(lblError);
            ForeColor = Color.FromArgb(21, 62, 61);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(995, 550);
            Name = "FrmCitas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VetCare";
            Load += FrmCitas_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblProgramarCita;
        private Label lblAgendaCitas;
        private Label lblMascota;
        private ListBox lstMascotas;
        private Label lblVeterinario;
        private ListBox lstVeterinarios;
        private Label lblFecha;
        private SelectorFecha dtpFechaHora;
        private Label lblMotivo;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgendar;
        private Label lblError;
        private ErrorProvider errorProvider;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirmar;
        private Guna.UI2.WinForms.Guna2GradientButton btnServicios;
        private Guna.UI2.WinForms.Guna2GradientButton btnReprogramarCita;
        private Label lblBuscarMascota;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarMascota;
        private Label lblResultado;
        private Guna.UI2.WinForms.Guna2CheckBox chkBuscarFecha;
        private SelectorFecha dtpBuscarFecha;
        private Guna.UI2.WinForms.Guna2ComboBox cboBuscarEstado;
        private Label lblBuscarEstado;
        private Guna.UI2.WinForms.Guna2GradientButton btnAtender;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitas;
    }
}
