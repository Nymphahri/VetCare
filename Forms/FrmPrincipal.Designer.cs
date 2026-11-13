using Guna.UI2.WinForms;

namespace VetCare
{
    partial class FrmPrincipal
    {
        private Panel pnlMenu;
        private Label lblMarca;
        private Label lblRecepcion;
        private Label lblAdministracion;
        private Label lblSesion;
        private Label lblTitulo;
        private Label lblResultado;
        private Guna2DateTimePicker dtpAgenda;
        private Guna2DataGridView dgvAgenda;
        private Guna2Button btnActualizar;
        private Guna2Button btnPropietarios;
        private Guna2Button btnMascotas;
        private Guna2Button btnVeterinarios;
        private Guna2Button btnServicios;
        private Guna2Button btnUsuarios;
        private Guna2Button btnCitas;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            lblMarca = new Label();
            lblRecepcion = new Label();
            lblAdministracion = new Label();
            btnPropietarios = new Guna2Button();
            btnMascotas = new Guna2Button();
            btnVeterinarios = new Guna2Button();
            btnServicios = new Guna2Button();
            btnUsuarios = new Guna2Button();
            lblSesion = new Label();
            lblTitulo = new Label();
            lblResultado = new Label();
            btnCitas = new Guna2Button();
            btnActualizar = new Guna2Button();
            dtpAgenda = new Guna2DateTimePicker();
            dgvAgenda = new Guna2DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(21, 62, 61);
            pnlMenu.Controls.Add(lblMarca);
            pnlMenu.Controls.Add(lblRecepcion);
            pnlMenu.Controls.Add(lblAdministracion);
            pnlMenu.Controls.Add(btnPropietarios);
            pnlMenu.Controls.Add(btnMascotas);
            pnlMenu.Controls.Add(btnVeterinarios);
            pnlMenu.Controls.Add(btnServicios);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(lblSesion);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(212, 560);
            pnlMenu.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(20, 18);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(135, 45);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "VetCare";
            // 
            // lblRecepcion
            // 
            lblRecepcion.AutoSize = true;
            lblRecepcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecepcion.ForeColor = Color.FromArgb(181, 210, 201);
            lblRecepcion.Location = new Point(22, 82);
            lblRecepcion.Name = "lblRecepcion";
            lblRecepcion.Size = new Size(70, 15);
            lblRecepcion.TabIndex = 1;
            lblRecepcion.Text = "RECEPCIÓN";
            // 
            // lblAdministracion
            // 
            lblAdministracion.AutoSize = true;
            lblAdministracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdministracion.ForeColor = Color.FromArgb(181, 210, 201);
            lblAdministracion.Location = new Point(22, 240);
            lblAdministracion.Name = "lblAdministracion";
            lblAdministracion.Size = new Size(111, 15);
            lblAdministracion.TabIndex = 2;
            lblAdministracion.Text = "ADMINISTRACIÓN";
            // 
            // btnPropietarios
            // 
            btnPropietarios.CustomizableEdges = customizableEdges17;
            btnPropietarios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnPropietarios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnPropietarios.FillColor = Color.FromArgb(21, 62, 61);
            btnPropietarios.Font = new Font("Segoe UI", 11F);
            btnPropietarios.ForeColor = Color.White;
            btnPropietarios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnPropietarios.Location = new Point(16, 110);
            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnPropietarios.Size = new Size(180, 40);
            btnPropietarios.TabIndex = 3;
            btnPropietarios.Text = "Propietarios";
            btnPropietarios.TextAlign = HorizontalAlignment.Left;
            btnPropietarios.Click += btnPropietarios_Click;
            // 
            // btnMascotas
            // 
            btnMascotas.CustomizableEdges = customizableEdges19;
            btnMascotas.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnMascotas.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnMascotas.FillColor = Color.FromArgb(21, 62, 61);
            btnMascotas.Font = new Font("Segoe UI", 11F);
            btnMascotas.ForeColor = Color.White;
            btnMascotas.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnMascotas.Location = new Point(16, 156);
            btnMascotas.Name = "btnMascotas";
            btnMascotas.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnMascotas.Size = new Size(180, 40);
            btnMascotas.TabIndex = 4;
            btnMascotas.Text = "Mascotas";
            btnMascotas.TextAlign = HorizontalAlignment.Left;
            btnMascotas.Click += btnMascotas_Click;
            // 
            // btnVeterinarios
            // 
            btnVeterinarios.CustomizableEdges = customizableEdges21;
            btnVeterinarios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnVeterinarios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnVeterinarios.FillColor = Color.FromArgb(21, 62, 61);
            btnVeterinarios.Font = new Font("Segoe UI", 11F);
            btnVeterinarios.ForeColor = Color.White;
            btnVeterinarios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnVeterinarios.Location = new Point(16, 272);
            btnVeterinarios.Name = "btnVeterinarios";
            btnVeterinarios.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnVeterinarios.Size = new Size(180, 40);
            btnVeterinarios.TabIndex = 5;
            btnVeterinarios.Text = "Veterinarios";
            btnVeterinarios.TextAlign = HorizontalAlignment.Left;
            btnVeterinarios.Click += btnVeterinarios_Click;
            // 
            // btnServicios
            // 
            btnServicios.CustomizableEdges = customizableEdges23;
            btnServicios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnServicios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnServicios.FillColor = Color.FromArgb(21, 62, 61);
            btnServicios.Font = new Font("Segoe UI", 11F);
            btnServicios.ForeColor = Color.White;
            btnServicios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnServicios.Location = new Point(16, 318);
            btnServicios.Name = "btnServicios";
            btnServicios.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnServicios.Size = new Size(180, 40);
            btnServicios.TabIndex = 6;
            btnServicios.Text = "Servicios";
            btnServicios.TextAlign = HorizontalAlignment.Left;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.CustomizableEdges = customizableEdges25;
            btnUsuarios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnUsuarios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnUsuarios.FillColor = Color.FromArgb(21, 62, 61);
            btnUsuarios.Font = new Font("Segoe UI", 11F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnUsuarios.Location = new Point(16, 364);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnUsuarios.Size = new Size(180, 40);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = HorizontalAlignment.Left;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // lblSesion
            // 
            lblSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSesion.ForeColor = Color.White;
            lblSesion.Location = new Point(22, 930);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(172, 70);
            lblSesion.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(21, 62, 61);
            lblTitulo.Location = new Point(240, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Agenda de citas";
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResultado.ForeColor = Color.FromArgb(21, 62, 61);
            lblResultado.Location = new Point(246, 499);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(684, 45);
            lblResultado.TabIndex = 6;
            // 
            // btnCitas
            // 
            btnCitas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCitas.BorderRadius = 6;
            btnCitas.CustomizableEdges = customizableEdges27;
            btnCitas.FillColor = Color.FromArgb(17, 107, 94);
            btnCitas.Font = new Font("Segoe UI", 9F);
            btnCitas.ForeColor = Color.White;
            btnCitas.Location = new Point(772, 27);
            btnCitas.Name = "btnCitas";
            btnCitas.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnCitas.Size = new Size(158, 40);
            btnCitas.TabIndex = 2;
            btnCitas.Text = "Gestionar citas";
            btnCitas.Click += btnCitas_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BorderRadius = 5;
            btnActualizar.CustomizableEdges = customizableEdges29;
            btnActualizar.FillColor = Color.FromArgb(225, 238, 231);
            btnActualizar.Font = new Font("Segoe UI", 9F);
            btnActualizar.ForeColor = Color.FromArgb(21, 62, 61);
            btnActualizar.Location = new Point(456, 88);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnActualizar.Size = new Size(112, 38);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += CargarAgenda;
            // 
            // dtpAgenda
            // 
            dtpAgenda.BorderColor = Color.FromArgb(171, 191, 185);
            dtpAgenda.BorderRadius = 5;
            dtpAgenda.BorderThickness = 1;
            dtpAgenda.Checked = true;
            dtpAgenda.CustomFormat = "dd/MM/yyyy";
            dtpAgenda.CustomizableEdges = customizableEdges31;
            dtpAgenda.FillColor = Color.White;
            dtpAgenda.Font = new Font("Segoe UI", 9F);
            dtpAgenda.Format = DateTimePickerFormat.Custom;
            dtpAgenda.Location = new Point(246, 88);
            dtpAgenda.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpAgenda.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpAgenda.Name = "dtpAgenda";
            dtpAgenda.ShadowDecoration.CustomizableEdges = customizableEdges32;
            dtpAgenda.Size = new Size(200, 38);
            dtpAgenda.TabIndex = 3;
            dtpAgenda.Value = new DateTime(2026, 11, 12, 0, 0, 0, 0);
            dtpAgenda.ValueChanged += CargarAgenda;
            // 
            // dgvAgenda
            // 
            dgvAgenda.AllowUserToAddRows = false;
            dgvAgenda.AllowUserToDeleteRows = false;
            dgvAgenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAgenda.ColumnHeadersHeight = 38;
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAgenda.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAgenda.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAgenda.GridColor = Color.FromArgb(231, 229, 255);
            dgvAgenda.Location = new Point(246, 150);
            dgvAgenda.MultiSelect = false;
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.ReadOnly = true;
            dgvAgenda.RowHeadersVisible = false;
            dgvAgenda.RowTemplate.Height = 36;
            dgvAgenda.Size = new Size(684, 335);
            dgvAgenda.TabIndex = 5;
            dgvAgenda.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(222, 235, 229);
            dgvAgenda.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F);
            dgvAgenda.ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(21, 62, 61);
            dgvAgenda.ThemeStyle.HeaderStyle.Height = 38;
            dgvAgenda.ThemeStyle.ReadOnly = true;
            dgvAgenda.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvAgenda.ThemeStyle.RowsStyle.Height = 36;
            dgvAgenda.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dgvAgenda.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(21, 62, 61);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Hora";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Mascota";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Motivo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 247);
            ClientSize = new Size(960, 560);
            Controls.Add(pnlMenu);
            Controls.Add(lblTitulo);
            Controls.Add(btnCitas);
            Controls.Add(dtpAgenda);
            Controls.Add(btnActualizar);
            Controls.Add(dgvAgenda);
            Controls.Add(lblResultado);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(830, 540);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetCare | Recepción";
            Load += CargarAgenda;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
