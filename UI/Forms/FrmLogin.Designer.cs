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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUsuario = new Label();
            lblContrasena = new Label();
            lblError = new Label();
            txtUsuario = new Guna2TextBox();
            txtContrasena = new Guna2TextBox();
            btnIngresar = new Guna2GradientButton();
            errorProvider = new ErrorProvider(components);
            guna2PictureBox1 = new Guna2PictureBox();
            lblIniciarSesion = new Label();
            lblTextoIngreso = new Label();
            lblCopyRight = new Label();
            lblVetCareLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.FromArgb(20, 48, 44);
            lblUsuario.Location = new Point(520, 206);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.ForeColor = Color.FromArgb(20, 48, 44);
            lblContrasena.Location = new Point(520, 294);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(84, 15);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "CONTRASEÑA";
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(919, 228);
            lblError.Name = "lblError";
            lblError.Size = new Size(167, 42);
            lblError.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderRadius = 5;
            txtUsuario.CustomizableEdges = customizableEdges1;
            txtUsuario.DefaultText = "";
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.IconLeft = (Image)resources.GetObject("txtUsuario.IconLeft");
            txtUsuario.Location = new Point(522, 228);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsuario.Size = new Size(391, 47);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderRadius = 5;
            txtContrasena.CustomizableEdges = customizableEdges3;
            txtContrasena.DefaultText = "";
            txtContrasena.Font = new Font("Segoe UI", 9F);
            txtContrasena.IconLeft = (Image)resources.GetObject("txtContrasena.IconLeft");
            txtContrasena.Location = new Point(522, 316);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '●';
            txtContrasena.PlaceholderText = "";
            txtContrasena.SelectedText = "";
            txtContrasena.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtContrasena.Size = new Size(391, 47);
            txtContrasena.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BorderRadius = 6;
            btnIngresar.CustomizableEdges = customizableEdges5;
            btnIngresar.FillColor = Color.FromArgb(14, 107, 92);
            btnIngresar.FillColor2 = Color.MediumAquamarine;
            btnIngresar.Font = new Font("Segoe UI", 9F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(522, 422);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnIngresar.Size = new Size(391, 40);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-2, -59);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(455, 726);
            guna2PictureBox1.TabIndex = 3;
            guna2PictureBox1.TabStop = false;
            // 
            // lblIniciarSesion
            // 
            lblIniciarSesion.AutoSize = true;
            lblIniciarSesion.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblIniciarSesion.ForeColor = Color.FromArgb(21, 62, 61);
            lblIniciarSesion.Location = new Point(513, 100);
            lblIniciarSesion.Name = "lblIniciarSesion";
            lblIniciarSesion.Size = new Size(214, 45);
            lblIniciarSesion.TabIndex = 4;
            lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // lblTextoIngreso
            // 
            lblTextoIngreso.AutoSize = true;
            lblTextoIngreso.ForeColor = Color.FromArgb(96, 114, 110);
            lblTextoIngreso.Location = new Point(520, 154);
            lblTextoIngreso.Name = "lblTextoIngreso";
            lblTextoIngreso.Size = new Size(183, 15);
            lblTextoIngreso.TabIndex = 8;
            lblTextoIngreso.Text = "Ingresa con tu cuenta del sistema";
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.ForeColor = Color.FromArgb(96, 114, 110);
            lblCopyRight.Location = new Point(522, 619);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(117, 15);
            lblCopyRight.TabIndex = 9;
            lblCopyRight.Text = "© 2026 VetCare UISIL";
            // 
            // lblVetCareLogin
            // 
            lblVetCareLogin.BackColor = Color.FromArgb(220, 239, 231);
            lblVetCareLogin.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblVetCareLogin.ForeColor = Color.FromArgb(14, 107, 92);
            lblVetCareLogin.Image = (Image)resources.GetObject("lblVetCareLogin.Image");
            lblVetCareLogin.ImageAlign = ContentAlignment.MiddleLeft;
            lblVetCareLogin.Location = new Point(38, 28);
            lblVetCareLogin.Name = "lblVetCareLogin";
            lblVetCareLogin.Size = new Size(260, 78);
            lblVetCareLogin.TabIndex = 10;
            lblVetCareLogin.Text = "VetCare";
            lblVetCareLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 247);
            ClientSize = new Size(1137, 643);
            Controls.Add(lblVetCareLogin);
            Controls.Add(lblCopyRight);
            Controls.Add(lblTextoIngreso);
            Controls.Add(lblIniciarSesion);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblError);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetCare";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2PictureBox guna2PictureBox1;
        private Label lblIniciarSesion;
        private Label lblTextoIngreso;
        private Label lblCopyRight;
        private Label lblVetCareLogin;
    }
}
