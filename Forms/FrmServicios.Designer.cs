namespace VetCare
{
    partial class FrmServicios
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
            lblNombre = new Label();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            lblErrorNombre = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            lblErrorDescripcion = new Label();
            lblPrecio = new Label();
            txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            lblErrorPrecio = new Label();
            lblEstado = new Label();
            lstEstado = new ListBox();
            btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnCerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnModificar = new Guna.UI2.WinForms.Guna2GradientButton();
            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            btnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBuscar = new Label();
            lblResultados = new Label();
            dgvServicios = new Guna.UI2.WinForms.Guna2DataGridView();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();

            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre:";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 18);

            txtNombre.Name = "txtNombre";
            txtNombre.Location = new Point(25, 41);
            txtNombre.Size = new Size(260, 36);
            txtNombre.TabIndex = 0;
            txtNombre.MaxLength = 60;

            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.ForeColor = Color.Firebrick;
            lblErrorNombre.Location = new Point(315, 41);
            lblErrorNombre.Size = new Size(520, 42);

            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Text = "Descripción (opcional):";
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(25, 92);

            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Location = new Point(25, 115);
            txtDescripcion.Size = new Size(260, 36);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.MaxLength = 200;

            lblErrorDescripcion.Name = "lblErrorDescripcion";
            lblErrorDescripcion.ForeColor = Color.Firebrick;
            lblErrorDescripcion.Location = new Point(315, 115);
            lblErrorDescripcion.Size = new Size(520, 42);

            lblPrecio.Name = "lblPrecio";
            lblPrecio.Text = "Precio:";
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(25, 166);

            txtPrecio.Name = "txtPrecio";
            txtPrecio.Location = new Point(25, 189);
            txtPrecio.Size = new Size(260, 36);
            txtPrecio.TabIndex = 2;
            txtPrecio.PlaceholderText = "Ej. 15000,50";

            lblErrorPrecio.Name = "lblErrorPrecio";
            lblErrorPrecio.ForeColor = Color.Firebrick;
            lblErrorPrecio.Location = new Point(315, 189);
            lblErrorPrecio.Size = new Size(520, 42);

            lblEstado.Name = "lblEstado";
            lblEstado.Text = "Estado:";
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(25, 240);

            lstEstado.Name = "lstEstado";
            lstEstado.Location = new Point(25, 263);
            lstEstado.Size = new Size(260, 45);
            lstEstado.TabIndex = 3;
            lstEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });

            btnGuardar.Name = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(25, 330);
            btnGuardar.Size = new Size(180, 45);
            btnGuardar.TabIndex = 4;
            btnGuardar.Click += btnGuardar_Click;

            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(225, 330);
            btnLimpiar.Size = new Size(180, 45);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Click += btnLimpiar_Click;

            btnCerrar.Name = "btnCerrar";
            btnCerrar.Text = "Cerrar";
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(425, 330);
            btnCerrar.Size = new Size(180, 45);
            btnCerrar.TabIndex = 6;
            btnCerrar.Click += btnCerrar_Click;

            btnModificar.Name = "btnModificar";
            btnModificar.Text = "Modificar";
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(625, 330);
            btnModificar.Size = new Size(180, 45);
            btnModificar.TabIndex = 7;
            btnModificar.Enabled = false;
            btnModificar.Click += btnModificar_Click;

            lblBuscar.Name = "lblBuscar";
            lblBuscar.Text = "Buscar por nombre o descripción:";
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(25, 390);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Location = new Point(25, 415);
            txtBuscar.Size = new Size(400, 36);
            txtBuscar.MaxLength = 200;
            txtBuscar.TabIndex = 8;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Text = "Buscar";
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(445, 415);
            btnBuscar.Size = new Size(140, 36);
            btnBuscar.TabIndex = 9;
            btnBuscar.Click += btnBuscar_Click;
            lblResultados.Name = "lblResultados";
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(610, 425);

            dgvServicios.Name = "dgvServicios";
            dgvServicios.Location = new Point(25, 470);
            dgvServicios.Size = new Size(850, 220);
            dgvServicios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServicios.ReadOnly = true;
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;
            dgvServicios.RowHeadersVisible = false;
            dgvServicios.ColumnHeadersHeight = 30;
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvServicios.TabIndex = 10;
            dgvServicios.CellClick += dgvServicios_CellClick;
            errorProvider.ContainerControl = this;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 715);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblResultados);
            StartPosition = FormStartPosition.CenterParent;
            Name = "FrmServicios";
            Text = "VetCare - Servicios";
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblErrorDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblErrorPrecio);
            Controls.Add(lblEstado);
            Controls.Add(lstEstado);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(dgvServicios);
            Load += FrmServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Label lblErrorNombre;
        private Label lblDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Label lblErrorDescripcion;
        private Label lblPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Label lblErrorPrecio;
        private Label lblEstado;
        private ListBox lstEstado;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuardar;
        private Guna.UI2.WinForms.Guna2GradientButton btnLimpiar;
        private Guna.UI2.WinForms.Guna2GradientButton btnCerrar;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscar;
        private Label lblBuscar;
        private Label lblResultados;
        private Guna.UI2.WinForms.Guna2DataGridView dgvServicios;
        private ErrorProvider errorProvider;
    }
}
