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
            errorProvider = new ErrorProvider(components);
            lblMascota = new Label();
            lstMascotas = new ListBox();
            lblVeterinario = new Label();
            lstVeterinarios = new ListBox();
            lblFecha = new Label();
            dtpFechaHora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblMotivo = new Label();
            txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            btnAgendar = new Guna.UI2.WinForms.Guna2GradientButton();
            lblError = new Label();
            dgvCitas = new Guna.UI2.WinForms.Guna2DataGridView();
            btnCancelar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnConfirmar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnServicios = new Guna.UI2.WinForms.Guna2GradientButton();
            btnReprogramar = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBuscarMascota = new Label();
            txtBuscarMascota = new Guna.UI2.WinForms.Guna2TextBox();
            lblResultado = new Label();
            chkBuscarFecha = new Guna.UI2.WinForms.Guna2CheckBox();
            dtpBuscarFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cboBuscarEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            lblBuscarEstado = new Label();
            btnAtender = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            lblMascota.Name = "lblMascota";
            lblMascota.Location = new Point(25, 15);
            lblMascota.Text = "Mascota";
            lblMascota.AutoSize = true;

            lstMascotas.Name = "lstMascotas";
            lstMascotas.Location = new Point(25, 39);
            lstMascotas.Size = new Size(315, 80);
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Format += lstMascotas_Format;
            lstMascotas.TabIndex = 0;

            lblVeterinario.Name = "lblVeterinario";
            lblVeterinario.Location = new Point(25, 130);
            lblVeterinario.Text = "Veterinario";
            lblVeterinario.AutoSize = true;

            lstVeterinarios.Name = "lstVeterinarios";
            lstVeterinarios.Location = new Point(25, 154);
            lstVeterinarios.Size = new Size(315, 80);
            lstVeterinarios.FormattingEnabled = true;
            lstVeterinarios.Format += lstVeterinarios_Format;
            lstVeterinarios.TabIndex = 1;

            lblFecha.Name = "lblFecha";
            lblFecha.Location = new Point(25, 250);
            lblFecha.Text = "Fecha y hora";
            lblFecha.AutoSize = true;

            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Location = new Point(25, 274);
            dtpFechaHora.Size = new Size(315, 36);
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaHora.TabIndex = 2;
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Text = "Reprogramar cita";
            btnReprogramar.Location = new Point(625, 274);
            btnReprogramar.Size = new Size(170, 36);
            btnReprogramar.Enabled = false;
            btnReprogramar.Click += btnReprogramar_Click;
            Controls.Add(btnReprogramar);

            lblMotivo.Name = "lblMotivo";
            lblMotivo.Location = new Point(25, 332);
            lblMotivo.Text = "Motivo (opcional)";
            lblMotivo.AutoSize = true;

            txtMotivo.Name = "txtMotivo";
            txtMotivo.Location = new Point(25, 356);
            txtMotivo.Size = new Size(315, 36);
            txtMotivo.MaxLength = 200;
            txtMotivo.TabIndex = 3;

            btnAgendar.Name = "btnAgendar";
            btnAgendar.Location = new Point(25, 412);
            btnAgendar.Text = "Agendar";
            btnAgendar.Size = new Size(132, 42);
            btnAgendar.Click += btnAgendar_Click;
            btnAgendar.TabIndex = 4;

            lblError.Name = "lblError";
            lblError.Location = new Point(365, 39);
            lblError.ForeColor = Color.Firebrick;
            lblError.Size = new Size(250, 70);
            errorProvider.ContainerControl = this;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 695);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Text = "Cancelar cita";
            btnCancelar.Location = new Point(465, 412);
            btnCancelar.Size = new Size(140, 42);
            btnCancelar.Enabled = false;
            btnCancelar.TabIndex = 7;
            btnCancelar.Click += btnCancelar_Click;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Text = "Confirmar cita";
            btnConfirmar.Location = new Point(167, 412);
            btnConfirmar.Size = new Size(143, 42);
            btnConfirmar.Enabled = false;
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Click += btnConfirmar_Click;
            dgvCitas.Name = "dgvCitas";
            lblBuscarMascota.AutoSize = true;
            lblBuscarMascota.Location = new Point(25, 463);
            lblBuscarMascota.Text = "Buscar por mascota";
            txtBuscarMascota.Name = "txtBuscarMascota";
            txtBuscarMascota.Location = new Point(25, 487);
            txtBuscarMascota.Size = new Size(220, 36);
            txtBuscarMascota.PlaceholderText = "Nombre de la mascota";
            txtBuscarMascota.MaxLength = 50;
            txtBuscarMascota.TabIndex = 9;
            chkBuscarFecha.Name = "chkBuscarFecha";
            chkBuscarFecha.Text = "Filtrar por fecha";
            chkBuscarFecha.Location = new Point(260, 460);
            chkBuscarFecha.AutoSize = true;
            chkBuscarFecha.TabIndex = 10;
            dtpBuscarFecha.Name = "dtpBuscarFecha";
            dtpBuscarFecha.Location = new Point(260, 487);
            dtpBuscarFecha.Size = new Size(170, 36);
            dtpBuscarFecha.Format = DateTimePickerFormat.Custom;
            dtpBuscarFecha.CustomFormat = "dd/MM/yyyy";
            dtpBuscarFecha.Value = DateTime.Today;
            dtpBuscarFecha.Enabled = false;
            dtpBuscarFecha.TabIndex = 11;
            lblBuscarEstado.Text = "Estado de la cita";
            lblBuscarEstado.AutoSize = true;
            lblBuscarEstado.Location = new Point(450, 463);
            cboBuscarEstado.Name = "cboBuscarEstado";
            cboBuscarEstado.Location = new Point(450, 487);
            cboBuscarEstado.Size = new Size(165, 36);
            cboBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Confirmada", "Atendida", "Cancelada" });
            cboBuscarEstado.SelectedIndex = 0;
            cboBuscarEstado.TabIndex = 12;
            txtBuscarMascota.TextChanged += FiltrosCita_Changed;
            chkBuscarFecha.CheckedChanged += FiltrosCita_Changed;
            dtpBuscarFecha.ValueChanged += FiltrosCita_Changed;
            cboBuscarEstado.SelectedIndexChanged += FiltrosCita_Changed;
            Controls.Add(chkBuscarFecha);
            Controls.Add(dtpBuscarFecha);
            Controls.Add(lblBuscarEstado);
            Controls.Add(cboBuscarEstado);
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(635, 496);
            Controls.Add(lblBuscarMascota);
            Controls.Add(txtBuscarMascota);
            Controls.Add(lblResultado);
            dgvCitas.Location = new Point(25, 535);
            dgvCitas.Size = new Size(770, 135);
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.ReadOnly = true;
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.MultiSelect = false;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.ColumnHeadersHeight = 30;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCitas.TabIndex = 13;
            dgvCitas.SelectionChanged += dgvCitas_SelectionChanged;
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            btnAtender.Name = "btnAtender";
            btnAtender.Text = "Atender cita";
            btnAtender.Location = new Point(320, 412);
            btnAtender.Size = new Size(135, 42);
            btnAtender.Enabled = false;
            btnAtender.TabIndex = 6;
            btnAtender.Click += btnAtender_Click;
            Controls.Add(btnAtender);
            btnServicios.Name = "btnServicios";
            btnServicios.Text = "Servicios de la cita";
            btnServicios.Location = new Point(615, 412);
            btnServicios.Size = new Size(180, 42);
            btnServicios.Enabled = false;
            btnServicios.TabIndex = 8;
            btnServicios.Click += btnServicios_Click;
            Controls.Add(btnServicios);
            Controls.Add(dgvCitas);
            Text = "VetCare - Agendar cita";
            StartPosition = FormStartPosition.CenterParent;
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
            Load += FrmCitas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMascota;
        private ListBox lstMascotas;
        private Label lblVeterinario;
        private ListBox lstVeterinarios;
        private Label lblFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaHora;
        private Label lblMotivo;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private Guna.UI2.WinForms.Guna2GradientButton btnAgendar;
        private Label lblError;
        private ErrorProvider errorProvider;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelar;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirmar;
        private Guna.UI2.WinForms.Guna2GradientButton btnServicios;
        private Guna.UI2.WinForms.Guna2GradientButton btnReprogramar;
        private Label lblBuscarMascota;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarMascota;
        private Label lblResultado;
        private Guna.UI2.WinForms.Guna2CheckBox chkBuscarFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBuscarFecha;
        private Guna.UI2.WinForms.Guna2ComboBox cboBuscarEstado;
        private Label lblBuscarEstado;
        private Guna.UI2.WinForms.Guna2GradientButton btnAtender;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitas;
    }
}
