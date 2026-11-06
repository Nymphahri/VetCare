namespace VetCare
{
    partial class FrmMascotas
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
            lstPropietarios = new ListBox();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            txtEspecie = new Guna.UI2.WinForms.Guna2TextBox();
            txtRaza = new Guna.UI2.WinForms.Guna2TextBox();
            dtpFechaNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnCerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnModificar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            btnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBuscar = new Label();
            lblResultadoBusqueda = new Label();
            dgvMascotas = new Guna.UI2.WinForms.Guna2DataGridView();
            lblPropietario = new Label();
            lblCedulaPropietario = new Label();
            lblNombre = new Label();
            lblEspecie = new Label();
            lblRaza = new Label();
            lblFecha = new Label();
            lblErrorPropietario = new Label();
            lblErrorNombre = new Label();
            lblErrorEspecie = new Label();
            lblErrorRaza = new Label();
            lblErrorFecha = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();

            lblPropietario.Name = "lblPropietario";
            lblPropietario.Text = "Propietario (selecciona un nombre):";
            lblPropietario.AutoSize = true;
            lblPropietario.Location = new Point(25, 20);
            lstPropietarios.Name = "lstPropietarios";
            lstPropietarios.Location = new Point(25, 45);
            lstPropietarios.Size = new Size(330, 184);
            lstPropietarios.TabIndex = 0;
            lstPropietarios.SelectedIndexChanged += lstPropietarios_SelectedIndexChanged;
            lblCedulaPropietario.Name = "lblCedulaPropietario";
            lblCedulaPropietario.AutoSize = true;
            lblCedulaPropietario.Location = new Point(25, 240);
            lblErrorPropietario.Name = "lblErrorPropietario";
            lblErrorPropietario.ForeColor = Color.Firebrick;
            lblErrorPropietario.Location = new Point(25, 270);
            lblErrorPropietario.Size = new Size(350, 65);

            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre de la mascota:";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(410, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Location = new Point(410, 45);
            txtNombre.Size = new Size(230, 36);
            txtNombre.TabIndex = 1;
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.ForeColor = Color.Firebrick;
            lblErrorNombre.Location = new Point(670, 45);
            lblErrorNombre.Size = new Size(400, 42);

            lblEspecie.Name = "lblEspecie";
            lblEspecie.Text = "Especie:";
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(410, 100);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Location = new Point(410, 125);
            txtEspecie.Size = new Size(230, 36);
            txtEspecie.TabIndex = 2;
            lblErrorEspecie.Name = "lblErrorEspecie";
            lblErrorEspecie.ForeColor = Color.Firebrick;
            lblErrorEspecie.Location = new Point(670, 125);
            lblErrorEspecie.Size = new Size(400, 42);

            lblRaza.Name = "lblRaza";
            lblRaza.Text = "Raza (opcional):";
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(410, 180);
            txtRaza.Name = "txtRaza";
            txtRaza.Location = new Point(410, 205);
            txtRaza.Size = new Size(230, 36);
            txtRaza.TabIndex = 3;
            lblErrorRaza.Name = "lblErrorRaza";
            lblErrorRaza.ForeColor = Color.Firebrick;
            lblErrorRaza.Location = new Point(670, 205);
            lblErrorRaza.Size = new Size(400, 42);

            lblFecha.Name = "lblFecha";
            lblFecha.Text = "Fecha de nacimiento:";
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(410, 260);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Location = new Point(410, 285);
            dtpFechaNacimiento.Size = new Size(230, 36);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.TabIndex = 4;
            lblErrorFecha.Name = "lblErrorFecha";
            lblErrorFecha.ForeColor = Color.Firebrick;
            lblErrorFecha.Location = new Point(670, 285);
            lblErrorFecha.Size = new Size(400, 42);

            btnGuardar.Name = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(25, 360);
            btnGuardar.Size = new Size(180, 45);
            btnGuardar.TabIndex = 5;
            btnGuardar.Click += btnGuardar_Click;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(225, 360);
            btnLimpiar.Size = new Size(180, 45);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Click += btnLimpiar_Click;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Text = "Cerrar";
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(425, 360);
            btnCerrar.Size = new Size(180, 45);
            btnCerrar.TabIndex = 7;
            btnCerrar.Click += btnCerrar_Click;

            btnModificar.Name = "btnModificar";
            btnModificar.Text = "Modificar";
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(625, 360);
            btnModificar.Size = new Size(180, 45);
            btnModificar.TabIndex = 8;
            btnModificar.Enabled = false;
            btnModificar.Click += btnModificar_Click;

            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(825, 360);
            btnEliminar.Size = new Size(180, 45);
            btnEliminar.TabIndex = 9;
            btnEliminar.Enabled = false;
            btnEliminar.Click += btnEliminar_Click;

            lblBuscar.Name = "lblBuscar";
            lblBuscar.Text = "Buscar por nombre, especie o raza:";
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(25, 420);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Location = new Point(25, 445);
            txtBuscar.Size = new Size(400, 36);
            txtBuscar.MaxLength = 50;
            txtBuscar.TabIndex = 10;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Text = "Buscar";
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(445, 445);
            btnBuscar.Size = new Size(140, 36);
            btnBuscar.TabIndex = 11;
            btnBuscar.Click += btnBuscar_Click;
            lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            lblResultadoBusqueda.AutoSize = true;
            lblResultadoBusqueda.Location = new Point(610, 455);

            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.Location = new Point(25, 500);
            dgvMascotas.Size = new Size(1050, 220);
            dgvMascotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMascotas.ReadOnly = true;
            dgvMascotas.AllowUserToAddRows = false;
            dgvMascotas.AllowUserToDeleteRows = false;
            dgvMascotas.MultiSelect = false;
            dgvMascotas.RowHeadersVisible = false;
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvMascotas.ColumnHeadersHeight = 30;
            dgvMascotas.TabIndex = 12;
            dgvMascotas.CellClick += dgvMascotas_CellClick;
            errorProvider.ContainerControl = this;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 745);
            StartPosition = FormStartPosition.CenterParent;
            Text = "VetCare - Mascotas";
            Name = "FrmMascotas";
            Controls.Add(lblPropietario);
            Controls.Add(lstPropietarios);
            Controls.Add(lblCedulaPropietario);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblEspecie);
            Controls.Add(txtEspecie);
            Controls.Add(lblRaza);
            Controls.Add(txtRaza);
            Controls.Add(lblFecha);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblErrorPropietario);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblErrorEspecie);
            Controls.Add(lblErrorRaza);
            Controls.Add(lblErrorFecha);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMascotas);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblResultadoBusqueda);
            Load += FrmMascotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox lstPropietarios;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtEspecie;
        private Guna.UI2.WinForms.Guna2TextBox txtRaza;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaNacimiento;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuardar;
        private Guna.UI2.WinForms.Guna2GradientButton btnLimpiar;
        private Guna.UI2.WinForms.Guna2GradientButton btnCerrar;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificar;
        private Guna.UI2.WinForms.Guna2GradientButton btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscar;
        private Label lblBuscar;
        private Label lblResultadoBusqueda;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMascotas;
        private Label lblPropietario;
        private Label lblCedulaPropietario;
        private Label lblNombre;
        private Label lblEspecie;
        private Label lblRaza;
        private Label lblFecha;
        private Label lblErrorPropietario;
        private Label lblErrorNombre;
        private Label lblErrorEspecie;
        private Label lblErrorRaza;
        private Label lblErrorFecha;
        private ErrorProvider errorProvider;
    }
}
