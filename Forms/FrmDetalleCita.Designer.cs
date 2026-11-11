using Guna.UI2.WinForms;

namespace VetCare
{
    partial class FrmDetalleCita
    {
        private System.ComponentModel.IContainer components = null;
        private ErrorProvider errorProvider;
        private Label lblServicio;
        private ListBox lstServicios;
        private Label lblCantidad;
        private Guna2TextBox txtCantidad;
        private Label lblError;
        private Guna2GradientButton btnAgregar;
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
            errorProvider = new ErrorProvider(components);
            errorProvider.ContainerControl = this;
            SuspendLayout();
            lblServicio = new Label();
            lblServicio.Name = "lblServicio";
            lblServicio.Location = new Point(20, 14);
            lblServicio.Size = new Size(220, 22);
            lblServicio.Text = "Servicios activos";
            Controls.Add(lblServicio);

            lstServicios = new ListBox();
            lstServicios.Name = "lstServicios";
            lstServicios.Location = new Point(20, 40);
            lstServicios.Size = new Size(255, 85);
            Controls.Add(lstServicios);

            lblCantidad = new Label();
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Location = new Point(20, 136);
            lblCantidad.Size = new Size(110, 22);
            lblCantidad.Text = "Cantidad";
            Controls.Add(lblCantidad);

            txtCantidad = new Guna2TextBox();
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Location = new Point(20, 160);
            txtCantidad.Size = new Size(110, 36);
            txtCantidad.Text = "1";
            Controls.Add(txtCantidad);

            lblError = new Label();
            lblError.Name = "lblError";
            lblError.Location = new Point(310, 40);
            lblError.Size = new Size(325, 60);
            Controls.Add(lblError);

            btnAgregar = new Guna2GradientButton();
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Location = new Point(20, 210);
            btnAgregar.Size = new Size(180, 38);
            btnAgregar.Text = "Agregar servicio";
            Controls.Add(btnAgregar);

            dgvDetalles = new Guna2DataGridView();
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.Location = new Point(20, 265);
            dgvDetalles.Size = new Size(605, 180);
            Controls.Add(dgvDetalles);

            lblTotal = new Label();
            lblTotal.Name = "lblTotal";
            lblTotal.Location = new Point(20, 460);
            lblTotal.Size = new Size(605, 26);
            Controls.Add(lblTotal);
            lstServicios.DisplayMember = "Nombre";
            lblError.ForeColor = Color.Firebrick;
            btnAgregar.Enabled = false;
            btnAgregar.Click += btnAgregar_Click;
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.ReadOnly = true;
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.Columns.Add("NombreServicio", "Servicio");
            dgvDetalles.Columns["NombreServicio"].DataPropertyName = "NombreServicio";
            dgvDetalles.Columns.Add("Cantidad", "Cantidad");
            dgvDetalles.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgvDetalles.Columns.Add("PrecioAplicado", "Precio aplicado");
            dgvDetalles.Columns["PrecioAplicado"].DataPropertyName = "PrecioAplicado";
            dgvDetalles.Columns["PrecioAplicado"].DefaultCellStyle.Format = "N2";
            dgvDetalles.Columns.Add("Subtotal", "Subtotal");
            dgvDetalles.Columns["Subtotal"].DataPropertyName = "Subtotal";
            dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            ClientSize = new Size(650, 500);
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmDetalleCita_Load;
            ResumeLayout(false);
        }
    }
}
