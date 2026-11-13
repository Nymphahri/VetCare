using Guna.UI2.WinForms;

namespace VetCare
{
    partial class FrmDetalleCita
    {
        private System.ComponentModel.IContainer components = null;
        private ErrorProvider errorProvider;
        private Label lblTituloServicioCita;
        private Label lblCita;
        private Label lblServiciosRegistrados;
        private Label lblServicioCita;
        private ListBox lstServicios;
        private Label lblCantidad;
        private Guna2TextBox txtCantidad;
        private Label lblError;
        private Guna2GradientButton btnAgregarServicio;
        private Guna2DataGridView dgvDetalles;
        private Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            errorProvider = new ErrorProvider(components);
            lblTituloServicioCita = new Label();
            lblCita = new Label();
            lblServicioCita = new Label();
            lstServicios = new ListBox();
            lblCantidad = new Label();
            txtCantidad = new Guna2TextBox();
            lblError = new Label();
            btnAgregarServicio = new Guna2GradientButton();
            lblServiciosRegistrados = new Label();
            dgvDetalles = new Guna2DataGridView();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblTituloServicioCita
            // 
            lblTituloServicioCita.AutoSize = true;
            lblTituloServicioCita.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloServicioCita.Location = new Point(24, 14);
            lblTituloServicioCita.Name = "lblTituloServicioCita";
            lblTituloServicioCita.Size = new Size(255, 37);
            lblTituloServicioCita.TabIndex = 0;
            lblTituloServicioCita.Text = "Servicios de la cita";
            // 
            // lblCita
            // 
            lblCita.AutoEllipsis = true;
            lblCita.Location = new Point(28, 60);
            lblCita.Name = "lblCita";
            lblCita.Size = new Size(744, 24);
            lblCita.TabIndex = 1;
            // 
            // lblServicioCita
            // 
            lblServicioCita.Location = new Point(28, 100);
            lblServicioCita.Name = "lblServicioCita";
            lblServicioCita.Size = new Size(220, 22);
            lblServicioCita.TabIndex = 2;
            lblServicioCita.Text = "Servicios activos";
            // 
            // lstServicios
            // 
            lstServicios.BorderStyle = BorderStyle.FixedSingle;
            lstServicios.DisplayMember = "Nombre";
            lstServicios.Font = new Font("Segoe UI", 10F);
            lstServicios.Location = new Point(28, 126);
            lstServicios.Name = "lstServicios";
            lstServicios.Size = new Size(238, 87);
            lstServicios.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(466, 100);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(110, 22);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.BorderRadius = 5;
            txtCantidad.CustomizableEdges = customizableEdges5;
            txtCantidad.DefaultText = "1";
            txtCantidad.Font = new Font("Segoe UI", 9F);
            txtCantidad.Location = new Point(466, 126);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "";
            txtCantidad.SelectedText = "";
            txtCantidad.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCantidad.Size = new Size(110, 36);
            txtCantidad.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(291, 126);
            lblError.Name = "lblError";
            lblError.Size = new Size(165, 64);
            lblError.TabIndex = 4;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BorderRadius = 6;
            btnAgregarServicio.CustomizableEdges = customizableEdges7;
            btnAgregarServicio.Enabled = false;
            btnAgregarServicio.FillColor = Color.FromArgb(17, 107, 94);
            btnAgregarServicio.FillColor2 = Color.FromArgb(17, 107, 94);
            btnAgregarServicio.Font = new Font("Segoe UI", 9F);
            btnAgregarServicio.ForeColor = Color.White;
            btnAgregarServicio.Location = new Point(466, 189);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAgregarServicio.Size = new Size(180, 38);
            btnAgregarServicio.TabIndex = 2;
            btnAgregarServicio.Text = "Agregar servicio";
            btnAgregarServicio.Click += btnAgregar_Click;
            // 
            // lblServiciosRegistrados
            // 
            lblServiciosRegistrados.AutoSize = true;
            lblServiciosRegistrados.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblServiciosRegistrados.Location = new Point(26, 250);
            lblServiciosRegistrados.Name = "lblServiciosRegistrados";
            lblServiciosRegistrados.Size = new Size(188, 25);
            lblServiciosRegistrados.TabIndex = 5;
            lblServiciosRegistrados.Text = "Servicios registrados";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalles.ColumnHeadersHeight = 38;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDetalles.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalles.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetalles.Location = new Point(28, 285);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersVisible = false;
            dgvDetalles.RowTemplate.Height = 34;
            dgvDetalles.Size = new Size(744, 208);
            dgvDetalles.TabIndex = 3;
            dgvDetalles.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(222, 235, 229);
            dgvDetalles.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDetalles.ThemeStyle.HeaderStyle.ForeColor = SystemColors.ControlText;
            dgvDetalles.ThemeStyle.HeaderStyle.Height = 38;
            dgvDetalles.ThemeStyle.ReadOnly = true;
            dgvDetalles.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDetalles.ThemeStyle.RowsStyle.Height = 34;
            dgvDetalles.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dgvDetalles.ThemeStyle.RowsStyle.SelectionForeColor = SystemColors.ControlText;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.BackColor = Color.FromArgb(222, 235, 229);
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotal.Location = new Point(28, 505);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(0, 0, 15, 0);
            lblTotal.Size = new Size(744, 50);
            lblTotal.TabIndex = 6;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmDetalleCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 247);
            ClientSize = new Size(800, 580);
            Controls.Add(lblTituloServicioCita);
            Controls.Add(lblCita);
            Controls.Add(lblServicioCita);
            Controls.Add(lstServicios);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblError);
            Controls.Add(btnAgregarServicio);
            Controls.Add(lblServiciosRegistrados);
            Controls.Add(dgvDetalles);
            Controls.Add(lblTotal);
            ForeColor = Color.FromArgb(21, 62, 61);
            MinimumSize = new Size(816, 619);
            Name = "FrmDetalleCita";
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmDetalleCita_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
