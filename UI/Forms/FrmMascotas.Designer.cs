using VetCare.UI.UI;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMascotas));
            lstPropietarios = new ListBox();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            txtEspecie = new Guna.UI2.WinForms.Guna2TextBox();
            txtRaza = new Guna.UI2.WinForms.Guna2TextBox();
            dtpFechaNacimiento = new SelectorFecha();
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
            lblDatosMascotas = new Label();
            lblBuscarMascotas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lstPropietarios
            // 
            lstPropietarios.Location = new Point(24, 96);
            lstPropietarios.Name = "lstPropietarios";
            lstPropietarios.Size = new Size(216, 79);
            lstPropietarios.TabIndex = 0;
            lstPropietarios.SelectedIndexChanged += lstPropietarios_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.BorderRadius = 5;
            txtNombre.CustomizableEdges = customizableEdges1;
            txtNombre.DefaultText = "";
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(24, 231);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtNombre.Size = new Size(216, 36);
            txtNombre.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.BorderRadius = 5;
            txtEspecie.CustomizableEdges = customizableEdges3;
            txtEspecie.DefaultText = "";
            txtEspecie.Font = new Font("Segoe UI", 9F);
            txtEspecie.Location = new Point(24, 296);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.PlaceholderText = "";
            txtEspecie.SelectedText = "";
            txtEspecie.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEspecie.Size = new Size(216, 36);
            txtEspecie.TabIndex = 2;
            // 
            // txtRaza
            // 
            txtRaza.BorderRadius = 5;
            txtRaza.CustomizableEdges = customizableEdges5;
            txtRaza.DefaultText = "";
            txtRaza.Font = new Font("Segoe UI", 9F);
            txtRaza.Location = new Point(24, 361);
            txtRaza.Name = "txtRaza";
            txtRaza.PlaceholderText = "opcional";
            txtRaza.SelectedText = "";
            txtRaza.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtRaza.Size = new Size(216, 36);
            txtRaza.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.BorderRadius = 10;
            dtpFechaNacimiento.CustomizableEdges = customizableEdges7;
            dtpFechaNacimiento.FillColor = Color.FromArgb(230, 240, 235);
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9F);
            dtpFechaNacimiento.ForeColor = Color.FromArgb(21, 62, 61);
            dtpFechaNacimiento.Location = new Point(24, 426);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpFechaNacimiento.Size = new Size(216, 36);
            dtpFechaNacimiento.TabIndex = 4;
            dtpFechaNacimiento.Text = "13/11/2026  ▾";
            // 
            // btnGuardar
            // 
            btnGuardar.BorderRadius = 6;
            btnGuardar.CustomizableEdges = customizableEdges9;
            btnGuardar.FillColor = Color.FromArgb(17, 107, 94);
            btnGuardar.FillColor2 = Color.FromArgb(17, 107, 94);
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(24, 482);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnGuardar.Size = new Size(108, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BorderRadius = 6;
            btnLimpiar.CustomizableEdges = customizableEdges11;
            btnLimpiar.FillColor = Color.FromArgb(224, 238, 232);
            btnLimpiar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnLimpiar.Font = new Font("Segoe UI", 9F);
            btnLimpiar.ForeColor = Color.FromArgb(21, 62, 61);
            btnLimpiar.Location = new Point(260, 482);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLimpiar.Size = new Size(97, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BorderRadius = 6;
            btnCerrar.CustomizableEdges = customizableEdges13;
            btnCerrar.FillColor = Color.FromArgb(224, 238, 232);
            btnCerrar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnCerrar.Font = new Font("Segoe UI", 9F);
            btnCerrar.ForeColor = Color.FromArgb(21, 62, 61);
            btnCerrar.Location = new Point(895, 482);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCerrar.Size = new Size(105, 40);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BorderRadius = 6;
            btnModificar.CustomizableEdges = customizableEdges15;
            btnModificar.Enabled = false;
            btnModificar.FillColor = Color.FromArgb(224, 238, 232);
            btnModificar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.ForeColor = Color.FromArgb(21, 62, 61);
            btnModificar.Location = new Point(140, 482);
            btnModificar.Name = "btnModificar";
            btnModificar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnModificar.Size = new Size(112, 40);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BorderRadius = 6;
            btnEliminar.CustomizableEdges = customizableEdges17;
            btnEliminar.Enabled = false;
            btnEliminar.FillColor = Color.FromArgb(249, 232, 228);
            btnEliminar.FillColor2 = Color.FromArgb(249, 232, 228);
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.FromArgb(129, 49, 45);
            btnEliminar.Location = new Point(452, 482);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderRadius = 5;
            txtBuscar.CustomizableEdges = customizableEdges19;
            txtBuscar.DefaultText = "";
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.Location = new Point(452, 96);
            txtBuscar.MaxLength = 50;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtBuscar.Size = new Size(285, 36);
            txtBuscar.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.BorderRadius = 6;
            btnBuscar.CustomizableEdges = customizableEdges21;
            btnBuscar.FillColor = Color.FromArgb(224, 238, 232);
            btnBuscar.FillColor2 = Color.FromArgb(224, 238, 232);
            btnBuscar.Font = new Font("Segoe UI", 9F);
            btnBuscar.ForeColor = Color.FromArgb(21, 62, 61);
            btnBuscar.Location = new Point(750, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnBuscar.Size = new Size(98, 36);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(452, 75);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(190, 15);
            lblBuscar.TabIndex = 13;
            lblBuscar.Text = "Buscar por nombre, especie o raza:";
            // 
            // lblResultadoBusqueda
            // 
            lblResultadoBusqueda.AutoSize = true;
            lblResultadoBusqueda.Location = new Point(452, 148);
            lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            lblResultadoBusqueda.Size = new Size(0, 15);
            lblResultadoBusqueda.TabIndex = 14;
            // 
            // dgvMascotas
            // 
            dgvMascotas.AllowUserToAddRows = false;
            dgvMascotas.AllowUserToDeleteRows = false;
            dgvMascotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMascotas.ColumnHeadersHeight = 38;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(211, 231, 221);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMascotas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMascotas.GridColor = Color.FromArgb(231, 229, 255);
            dgvMascotas.Location = new Point(452, 180);
            dgvMascotas.MultiSelect = false;
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.ReadOnly = true;
            dgvMascotas.RowHeadersVisible = false;
            dgvMascotas.RowTemplate.Height = 32;
            dgvMascotas.Size = new Size(548, 285);
            dgvMascotas.TabIndex = 12;
            dgvMascotas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(222, 235, 229);
            dgvMascotas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvMascotas.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(21, 62, 61);
            dgvMascotas.ThemeStyle.HeaderStyle.Height = 38;
            dgvMascotas.ThemeStyle.ReadOnly = true;
            dgvMascotas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMascotas.ThemeStyle.RowsStyle.Height = 32;
            dgvMascotas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(211, 231, 221);
            dgvMascotas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(21, 62, 61);
            dgvMascotas.CellClick += dgvMascotas_CellClick;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Location = new Point(24, 75);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(196, 15);
            lblPropietario.TabIndex = 2;
            lblPropietario.Text = "Propietario (selecciona un nombre):";
            // 
            // lblCedulaPropietario
            // 
            lblCedulaPropietario.AutoSize = true;
            lblCedulaPropietario.Location = new Point(24, 179);
            lblCedulaPropietario.Name = "lblCedulaPropietario";
            lblCedulaPropietario.Size = new Size(0, 15);
            lblCedulaPropietario.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 210);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(130, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre de la mascota:";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(24, 275);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(49, 15);
            lblEspecie.TabIndex = 5;
            lblEspecie.Text = "Especie:";
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(24, 340);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(31, 15);
            lblRaza.TabIndex = 6;
            lblRaza.Text = "Raza";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(24, 405);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha de nacimiento:";
            // 
            // lblErrorPropietario
            // 
            lblErrorPropietario.ForeColor = Color.Firebrick;
            lblErrorPropietario.Location = new Point(265, 97);
            lblErrorPropietario.Name = "lblErrorPropietario";
            lblErrorPropietario.Size = new Size(174, 65);
            lblErrorPropietario.TabIndex = 8;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.ForeColor = Color.Firebrick;
            lblErrorNombre.Location = new Point(265, 229);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(174, 50);
            lblErrorNombre.TabIndex = 9;
            // 
            // lblErrorEspecie
            // 
            lblErrorEspecie.ForeColor = Color.Firebrick;
            lblErrorEspecie.Location = new Point(265, 294);
            lblErrorEspecie.Name = "lblErrorEspecie";
            lblErrorEspecie.Size = new Size(174, 50);
            lblErrorEspecie.TabIndex = 10;
            // 
            // lblErrorRaza
            // 
            lblErrorRaza.ForeColor = Color.Firebrick;
            lblErrorRaza.Location = new Point(265, 359);
            lblErrorRaza.Name = "lblErrorRaza";
            lblErrorRaza.Size = new Size(174, 50);
            lblErrorRaza.TabIndex = 11;
            // 
            // lblErrorFecha
            // 
            lblErrorFecha.ForeColor = Color.Firebrick;
            lblErrorFecha.Location = new Point(265, 424);
            lblErrorFecha.Name = "lblErrorFecha";
            lblErrorFecha.Size = new Size(174, 50);
            lblErrorFecha.TabIndex = 12;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblDatosMascotas
            // 
            lblDatosMascotas.AutoSize = true;
            lblDatosMascotas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDatosMascotas.Location = new Point(24, 20);
            lblDatosMascotas.Name = "lblDatosMascotas";
            lblDatosMascotas.Size = new Size(276, 37);
            lblDatosMascotas.TabIndex = 0;
            lblDatosMascotas.Text = "Datos de la mascota";
            // 
            // lblBuscarMascotas
            // 
            lblBuscarMascotas.AutoSize = true;
            lblBuscarMascotas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBuscarMascotas.Location = new Point(452, 20);
            lblBuscarMascotas.Name = "lblBuscarMascotas";
            lblBuscarMascotas.Size = new Size(228, 37);
            lblBuscarMascotas.TabIndex = 1;
            lblBuscarMascotas.Text = "Buscar mascotas";
            // 
            // FrmMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 247);
            FormBorderStyle = FormBorderStyle.None;
            ClientSize = new Size(1024, 552);
            Controls.Add(lblDatosMascotas);
            Controls.Add(lblBuscarMascotas);
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
            ForeColor = Color.FromArgb(21, 62, 61);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 552);
            Name = "FrmMascotas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VetCare";
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
        private SelectorFecha dtpFechaNacimiento;
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
        private Label lblDatosMascotas;
        private Label lblBuscarMascotas;
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
