using Guna.UI2.WinForms;
using VetCare.UI.Modelos;

namespace VetCare
{
    partial class FrmUsuarios
    {
        private Guna2DataGridView dgvUsuarios;
        private System.ComponentModel.IContainer components = null;
        private ErrorProvider errorProvider;
        private Label lblNombre;
        private Guna2TextBox txtNombre;
        private Label lblContrasena;
        private Guna2TextBox txtContrasena;
        private Label lblRol;
        private Guna2ComboBox cboRol;
        private Label lblError;
        private Guna2GradientButton btnRegistrar;
        private Label lblNuevoRol;
        private Guna2ComboBox cboNuevoRol;
        private Guna2GradientButton btnCambiarRol;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvUsuarios = new Guna2DataGridView();
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            errorProvider.ContainerControl = this;
            SuspendLayout();
            lblNombre = new Label();
            lblNombre.Name = "lblNombre";
            lblNombre.Location = new Point(20, 14);
            lblNombre.Size = new Size(200, 20);
            lblNombre.Text = "Nombre de usuario";
            Controls.Add(lblNombre);
            txtNombre = new Guna2TextBox();
            txtNombre.Name = "txtNombre";
            txtNombre.Location = new Point(20, 36);
            txtNombre.Size = new Size(220, 36);
            Controls.Add(txtNombre);
            lblContrasena = new Label();
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Location = new Point(20, 80);
            lblContrasena.Size = new Size(200, 20);
            lblContrasena.Text = "Contraseña";
            Controls.Add(lblContrasena);
            txtContrasena = new Guna2TextBox();
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Location = new Point(20, 102);
            txtContrasena.Size = new Size(220, 36);
            Controls.Add(txtContrasena);
            lblRol = new Label();
            lblRol.Name = "lblRol";
            lblRol.Location = new Point(20, 146);
            lblRol.Size = new Size(200, 20);
            lblRol.Text = "Rol";
            Controls.Add(lblRol);
            cboRol = new Guna2ComboBox();
            cboRol.Name = "cboRol";
            cboRol.Location = new Point(20, 168);
            cboRol.Size = new Size(220, 36);
            Controls.Add(cboRol);
            lblError = new Label();
            lblError.Name = "lblError";
            lblError.Location = new Point(265, 36);
            lblError.Size = new Size(235, 50);
            Controls.Add(lblError);
            btnRegistrar = new Guna2GradientButton();
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Location = new Point(20, 218);
            btnRegistrar.Size = new Size(220, 38);
            btnRegistrar.Text = "Registrar cuenta";
            Controls.Add(btnRegistrar);
            txtNombre.MaxLength = 30;
            txtContrasena.PasswordChar = '●';
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.Items.AddRange(new object[] { "Recepcionista", "Administrador" });
            cboRol.SelectedIndex = -1;
            lblError.ForeColor = Color.Firebrick;
            btnRegistrar.Click += btnRegistrar_Click;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Location = new Point(20, 274);
            dgvUsuarios.Size = new Size(500, 200);
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeight = 32;
            dgvUsuarios.Columns.Add("colNombre", "Nombre de usuario");
            dgvUsuarios.Columns["colNombre"].DataPropertyName = nameof(Usuario.NombreUsuario);
            dgvUsuarios.Columns.Add("colRol", "Rol");
            dgvUsuarios.Columns["colRol"].DataPropertyName = nameof(Usuario.Rol);
            Controls.Add(dgvUsuarios);
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            lblNuevoRol = new Label();
            lblNuevoRol.Text = "Rol de la cuenta seleccionada";
            lblNuevoRol.AutoSize = true;
            lblNuevoRol.Location = new Point(20, 487);
            cboNuevoRol = new Guna2ComboBox();
            cboNuevoRol.Name = "cboNuevoRol";
            cboNuevoRol.Location = new Point(20, 510);
            cboNuevoRol.Size = new Size(220, 36);
            cboNuevoRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNuevoRol.Items.AddRange(new object[] { "Recepcionista", "Administrador" });
            cboNuevoRol.Enabled = false;
            btnCambiarRol = new Guna2GradientButton();
            btnCambiarRol.Name = "btnCambiarRol";
            btnCambiarRol.Text = "Guardar cambio de rol";
            btnCambiarRol.Location = new Point(260, 510);
            btnCambiarRol.Size = new Size(220, 36);
            btnCambiarRol.Enabled = false;
            Controls.Add(lblNuevoRol);
            Controls.Add(cboNuevoRol);
            Controls.Add(btnCambiarRol);
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            cboNuevoRol.SelectedIndexChanged += cboNuevoRol_SelectedIndexChanged;
            btnCambiarRol.Click += btnCambiarRol_Click;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 570);
            lblNuevoRol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboNuevoRol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCambiarRol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Text = "VetCare - Usuarios";
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmUsuarios_Load;
            ResumeLayout(false);
        }
    }
}
