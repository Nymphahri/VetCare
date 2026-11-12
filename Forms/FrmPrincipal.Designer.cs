using Guna.UI2.WinForms;

namespace VetCare
{
    partial class FrmPrincipal
    {
        private Label lblSesion;
        private Guna2GradientButton btnPropietarios;
        private Guna2GradientButton btnMascotas;
        private Guna2GradientButton btnCitas;
        private Guna2GradientButton btnVeterinarios;
        private Guna2GradientButton btnServicios;

        private void InitializeComponent()
        {
            lblSesion = new Label();
            btnPropietarios = new Guna2GradientButton();
            btnMascotas = new Guna2GradientButton();
            btnCitas = new Guna2GradientButton();
            btnVeterinarios = new Guna2GradientButton();
            btnServicios = new Guna2GradientButton();
            SuspendLayout();
            lblSesion.Name = "lblSesion";
            lblSesion.Location = new Point(24, 18);
            lblSesion.AutoSize = true;
            Controls.Add(lblSesion);

            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.Text = "Propietarios";
            btnPropietarios.Location = new Point(24, 52);
            btnPropietarios.Size = new Size(280, 40);
            btnPropietarios.TabIndex = 0;
            btnPropietarios.Click += btnPropietarios_Click;
            Controls.Add(btnPropietarios);

            btnMascotas.Name = "btnMascotas";
            btnMascotas.Text = "Mascotas";
            btnMascotas.Location = new Point(24, 102);
            btnMascotas.Size = new Size(280, 40);
            btnMascotas.TabIndex = 1;
            btnMascotas.Click += btnMascotas_Click;
            Controls.Add(btnMascotas);

            btnCitas.Name = "btnCitas";
            btnCitas.Text = "Citas";
            btnCitas.Location = new Point(24, 152);
            btnCitas.Size = new Size(280, 40);
            btnCitas.TabIndex = 2;
            btnCitas.Click += btnCitas_Click;
            Controls.Add(btnCitas);

            btnVeterinarios.Name = "btnVeterinarios";
            btnVeterinarios.Text = "Veterinarios";
            btnVeterinarios.Location = new Point(24, 202);
            btnVeterinarios.Size = new Size(280, 40);
            btnVeterinarios.TabIndex = 3;
            btnVeterinarios.Click += btnVeterinarios_Click;
            Controls.Add(btnVeterinarios);

            btnServicios.Name = "btnServicios";
            btnServicios.Text = "Servicios";
            btnServicios.Location = new Point(24, 252);
            btnServicios.Size = new Size(280, 40);
            btnServicios.TabIndex = 4;
            btnServicios.Click += btnServicios_Click;
            Controls.Add(btnServicios);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 316);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetCare - Menú principal";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
