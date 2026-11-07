namespace VetCare
{
    partial class FrmVeterinarios
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
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            txtEspecialidad = new Guna.UI2.WinForms.Guna2TextBox();
            txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnCerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnModificar = new Guna.UI2.WinForms.Guna2GradientButton();
            btnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            btnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            lblBuscar = new Label();
            lblResultados = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblEspecialidad = new Label();
            lblTelefono = new Label();
            lblErrorNombre = new Label();
            lblErrorApellidos = new Label();
            lblErrorEspecialidad = new Label();
            lblErrorTelefono = new Label();
            dgvVeterinarios = new Guna.UI2.WinForms.Guna2DataGridView();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();

            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre:";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Location = new Point(25, 45);
            txtNombre.Size = new Size(250, 36);
            txtNombre.TabIndex = 0;
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.ForeColor = Color.Firebrick;
            lblErrorNombre.Location = new Point(305, 45);
            lblErrorNombre.Size = new Size(560, 42);

            lblApellidos.Name = "lblApellidos";
            lblApellidos.Text = "Apellidos:";
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(25, 100);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Location = new Point(25, 125);
            txtApellidos.Size = new Size(250, 36);
            txtApellidos.TabIndex = 1;
            lblErrorApellidos.Name = "lblErrorApellidos";
            lblErrorApellidos.ForeColor = Color.Firebrick;
            lblErrorApellidos.Location = new Point(305, 125);
            lblErrorApellidos.Size = new Size(560, 42);

            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Text = "Especialidad:";
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(25, 180);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Location = new Point(25, 205);
            txtEspecialidad.Size = new Size(250, 36);
            txtEspecialidad.TabIndex = 2;
            lblErrorEspecialidad.Name = "lblErrorEspecialidad";
            lblErrorEspecialidad.ForeColor = Color.Firebrick;
            lblErrorEspecialidad.Location = new Point(305, 205);
            lblErrorEspecialidad.Size = new Size(560, 42);

            lblTelefono.Name = "lblTelefono";
            lblTelefono.Text = "Teléfono:";
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(25, 260);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Location = new Point(25, 285);
            txtTelefono.Size = new Size(250, 36);
            txtTelefono.TabIndex = 3;
            lblErrorTelefono.Name = "lblErrorTelefono";
            lblErrorTelefono.ForeColor = Color.Firebrick;
            lblErrorTelefono.Location = new Point(305, 285);
            lblErrorTelefono.Size = new Size(560, 42);

            btnGuardar.Name = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(25, 345);
            btnGuardar.Size = new Size(180, 45);
            btnGuardar.TabIndex = 4;
            btnGuardar.Click += btnGuardar_Click;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(225, 345);
            btnLimpiar.Size = new Size(180, 45);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Click += btnLimpiar_Click;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Text = "Cerrar";
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(425, 345);
            btnCerrar.Size = new Size(180, 45);
            btnCerrar.TabIndex = 6;
            btnCerrar.Click += btnCerrar_Click;

            btnModificar.Name = "btnModificar";
            btnModificar.Text = "Modificar";
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(625, 345);
            btnModificar.Size = new Size(180, 45);
            btnModificar.TabIndex = 7;
            btnModificar.Enabled = false;
            btnModificar.Click += btnModificar_Click;

            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(825, 345);
            btnEliminar.Size = new Size(180, 45);
            btnEliminar.TabIndex = 8;
            btnEliminar.Enabled = false;
            btnEliminar.Click += btnEliminar_Click;

            lblBuscar.Name = "lblBuscar";
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(25, 402);
            lblBuscar.Text = "Buscar por nombre, apellidos o especialidad:";
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Location = new Point(25, 426);
            txtBuscar.Size = new Size(400, 36);
            txtBuscar.MaxLength = 80;
            txtBuscar.TabIndex = 9;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Text = "Buscar";
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(445, 426);
            btnBuscar.Size = new Size(140, 36);
            btnBuscar.TabIndex = 10;
            btnBuscar.Click += btnBuscar_Click;
            lblResultados.Name = "lblResultados";
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(610, 436);

            dgvVeterinarios.Name = "dgvVeterinarios";
            dgvVeterinarios.Location = new Point(25, 480);
            dgvVeterinarios.Size = new Size(1050, 220);
            dgvVeterinarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeterinarios.ReadOnly = true;
            dgvVeterinarios.AllowUserToAddRows = false;
            dgvVeterinarios.AllowUserToDeleteRows = false;
            dgvVeterinarios.MultiSelect = false;
            dgvVeterinarios.RowHeadersVisible = false;
            dgvVeterinarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeterinarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVeterinarios.ColumnHeadersHeight = 30;
            dgvVeterinarios.TabIndex = 11;
            dgvVeterinarios.CellClick += dgvVeterinarios_CellClick;
            errorProvider.ContainerControl = this;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 725);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblResultados);
            Name = "FrmVeterinarios";
            Text = "VetCare - Veterinarios";
            StartPosition = FormStartPosition.CenterParent;
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellidos);
            Controls.Add(txtApellidos);
            Controls.Add(lblEspecialidad);
            Controls.Add(txtEspecialidad);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblErrorApellidos);
            Controls.Add(lblErrorEspecialidad);
            Controls.Add(lblErrorTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvVeterinarios);
            Load += FrmVeterinarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private Guna.UI2.WinForms.Guna2TextBox txtEspecialidad;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuardar;
        private Guna.UI2.WinForms.Guna2GradientButton btnLimpiar;
        private Guna.UI2.WinForms.Guna2GradientButton btnCerrar;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificar;
        private Guna.UI2.WinForms.Guna2GradientButton btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscar;
        private Label lblBuscar;
        private Label lblResultados;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVeterinarios;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblEspecialidad;
        private Label lblTelefono;
        private Label lblErrorNombre;
        private Label lblErrorApellidos;
        private Label lblErrorEspecialidad;
        private Label lblErrorTelefono;
        private ErrorProvider errorProvider;
    }
}
