using Guna.UI2.WinForms;
using VetCare.UI.Modelos;

namespace VetCare
{
    partial class FrmUsuarios
    {
        private Guna2DataGridView dgvUsuarios;

        private void InitializeComponent()
        {
            dgvUsuarios = new Guna2DataGridView();
            SuspendLayout();
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Location = new Point(20, 20);
            dgvUsuarios.Size = new Size(460, 260);
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
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Text = "VetCare - Usuarios";
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmUsuarios_Load;
            ResumeLayout(false);
        }
    }
}
