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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            lblDatosServicio = new Label();
            lblBuscarServicios = new Label();
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
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblDatosServicio
            // 
            lblDatosServicio.AutoSize = true;
            lblDatosServicio.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDatosServicio.Location = new Point(24, 20);
            lblDatosServicio.Name = "lblDatosServicio";
            lblDatosServicio.Size = new Size(246, 37);
            lblDatosServicio.TabIndex = 0;
            lblDatosServicio.Text = "Datos del servicio";
            // 
            // lblBuscarServicios
            // 
            lblBuscarServicios.AutoSize = true;
            lblBuscarServicios.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBuscarServicios.Location = new Point(452, 20);
            lblBuscarServicios.Name = "lblBuscarServicios";
            lblBuscarServicios.Size = new Size(220, 37);
            lblBuscarServicios.TabIndex = 1;
            lblBuscarServicios.Text = "Buscar servicios";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.CustomizableEdges = customizableEdges1;
            txtNombre.DefaultText = "";
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(24, 98);
            txtNombre.MaxLength = 60;
            txtNombre.BorderRadius = 5;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNombre.Size = new Size(216, 36);
            txtNombre.TabIndex = 0;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.ForeColor = Color.Firebrick;
            lblErrorNombre.Location = new Point(266, 98);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(172, 55);
            lblErrorNombre.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(24, 152);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.CustomizableEdges = customizableEdges3;
            txtDescripcion.DefaultText = "";
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.Location = new Point(24, 174);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.BorderRadius = 5;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "opcional";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDescripcion.Size = new Size(216, 36);
            txtDescripcion.TabIndex = 1;
            // 
            // lblErrorDescripcion
            // 
            lblErrorDescripcion.ForeColor = Color.Firebrick;
            lblErrorDescripcion.Location = new Point(266, 174);
            lblErrorDescripcion.Name = "lblErrorDescripcion";
            lblErrorDescripcion.Size = new Size(172, 55);
            lblErrorDescripcion.TabIndex = 14;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(24, 228);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.CustomizableEdges = customizableEdges5;
            txtPrecio.DefaultText = "";
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.Location = new Point(24, 250);
            txtPrecio.BorderRadius = 5;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "₡ 15000,50";
            txtPrecio.SelectedText = "";
            txtPrecio.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrecio.Size = new Size(216, 36);
            txtPrecio.TabIndex = 2;
            // 
            // lblErrorPrecio
            // 
            lblErrorPrecio.ForeColor = Color.Firebrick;
            lblErrorPrecio.Location = new Point(266, 250);
            lblErrorPrecio.Name = "lblErrorPrecio";
            lblErrorPrecio.Size = new Size(172, 62);
            lblErrorPrecio.TabIndex = 16;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(24, 304);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Estado:";
            // 
            // lstEstado
            // 
            lstEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            lstEstado.Location = new Point(24, 326);
            lstEstado.Name = "lstEstado";
            lstEstado.Size = new Size(216, 64);
            lstEstado.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderRadius = 6;
            btnGuardar.CustomizableEdges = customizableEdges7;
            btnGuardar.FillColor = Color.FromArgb(17, 107, 94);
            btnGuardar.FillColor2 = Color.FromArgb(17, 107, 94);
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(24, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnGuardar.Size = new Size(120, 38);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BorderRadius = 6;
            btnLimpiar.CustomizableEdges = customizableEdges9;
            btnLimpiar.FillColor = Color.FromArgb(224, 238, 232);
            btnLimpiar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnLimpiar.Font = new Font("Segoe UI", 9F);
            btnLimpiar.ForeColor = Color.FromArgb(21, 62, 61);
            btnLimpiar.Location = new Point(24, 448);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnLimpiar.Size = new Size(120, 38);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BorderRadius = 6;
            btnCerrar.CustomizableEdges = customizableEdges11;
            btnCerrar.FillColor = Color.FromArgb(224, 238, 232);
            btnCerrar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnCerrar.Font = new Font("Segoe UI", 9F);
            btnCerrar.ForeColor = Color.FromArgb(21, 62, 61);
            btnCerrar.Location = new Point(156, 448);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCerrar.Size = new Size(120, 38);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BorderRadius = 6;
            btnModificar.CustomizableEdges = customizableEdges13;
            btnModificar.Enabled = false;
            btnModificar.FillColor = Color.FromArgb(224, 238, 232);
            btnModificar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.ForeColor = Color.FromArgb(21, 62, 61);
            btnModificar.Location = new Point(156, 398);
            btnModificar.Name = "btnModificar";
            btnModificar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnModificar.Size = new Size(120, 38);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.CustomizableEdges = customizableEdges15;
            txtBuscar.DefaultText = "";
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.Location = new Point(452, 98);
            txtBuscar.MaxLength = 200;
            txtBuscar.BorderRadius = 5;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtBuscar.Size = new Size(285, 36);
            txtBuscar.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.BorderRadius = 6;
            btnBuscar.CustomizableEdges = customizableEdges17;
            btnBuscar.FillColor = Color.FromArgb(224, 238, 232);
            btnBuscar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnBuscar.Font = new Font("Segoe UI", 9F);
            btnBuscar.ForeColor = Color.FromArgb(21, 62, 61);
            btnBuscar.Location = new Point(750, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnBuscar.Size = new Size(110, 36);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(452, 76);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(185, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por nombre o descripción:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(452, 151);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(0, 15);
            lblResultados.TabIndex = 10;
            // 
            // dgvServicios
            // 
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;
            dgvServicios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(17, 107, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServicios.ColumnHeadersHeight = 38;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 238, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvServicios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvServicios.GridColor = Color.FromArgb(224, 238, 232);
            dgvServicios.Location = new Point(452, 178);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.ReadOnly = true;
            dgvServicios.RowHeadersVisible = false;
            dgvServicios.Size = new Size(548, 308);
            dgvServicios.TabIndex = 10;
            dgvServicios.ThemeStyle.GridColor = Color.FromArgb(224, 238, 232);
            dgvServicios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(17, 107, 94);
            dgvServicios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvServicios.ThemeStyle.HeaderStyle.Height = 38;
            dgvServicios.ThemeStyle.ReadOnly = true;
            dgvServicios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvServicios.ThemeStyle.RowsStyle.Height = 25;
            dgvServicios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(224, 238, 232);
            dgvServicios.CellClick += dgvServicios_CellClick;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 247);
            ClientSize = new Size(1024, 510);
            Controls.Add(lblDatosServicio);
            Controls.Add(lblBuscarServicios);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblResultados);
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
            ForeColor = Color.FromArgb(21, 62, 61);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1040, 549);
            Name = "FrmServicios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VetCare ";
            Load += FrmServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDatosServicio;
        private Label lblBuscarServicios;
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
