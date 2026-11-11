using Guna.UI2.WinForms;

namespace VetCare
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsuario;
        private Label lblContrasena;
        private Label lblError;
        private Guna2TextBox txtUsuario;
        private Guna2TextBox txtContrasena;
        private Guna2GradientButton btnIngresar;
        private ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUsuario = new Label();
            lblContrasena = new Label();
            lblError = new Label();
            txtUsuario = new Guna2TextBox();
            txtContrasena = new Guna2TextBox();
            btnIngresar = new Guna2GradientButton();
            errorProvider = new ErrorProvider(components);
            SuspendLayout();
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(24, 18);
            lblUsuario.Text = "Nombre de usuario";
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Location = new Point(24, 40);
            txtUsuario.Size = new Size(220, 36);
            txtUsuario.MaxLength = 30;
            txtUsuario.TabIndex = 0;
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(24, 90);
            lblContrasena.Text = "Contraseña";
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Location = new Point(24, 112);
            txtContrasena.Size = new Size(220, 36);
            txtContrasena.PasswordChar = '●';
            txtContrasena.TabIndex = 1;
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(268, 40);
            lblError.Size = new Size(190, 42);
            errorProvider.ContainerControl = this;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.Location = new Point(24, 169);
            btnIngresar.Size = new Size(220, 40);
            btnIngresar.TabIndex = 2;
            btnIngresar.Click += btnIngresar_Click;
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblError);
            Controls.Add(btnIngresar);
            AcceptButton = btnIngresar;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 232);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Text = "VetCare - Inicio de sesión";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
