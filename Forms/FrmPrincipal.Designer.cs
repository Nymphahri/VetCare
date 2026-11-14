using Guna.UI2.WinForms;
using VetCare.UI.UI;

namespace VetCare
{
    partial class FrmPrincipal
    {
        private Panel pnlMenuPrincipal;
        private Label lblRolMenu;
        private Guna2Button btnAnterior;
        private Guna2Button btnHoy;
        private Guna2Button btnSiguiente;
        private TableLayoutPanel resumenAgenda;
        private Label lblTotal;
        private Label lblPendientes;
        private Label lblAtendidas;
        private Panel pnlAviso;
        private PictureBox picHuella;
        private Guna2Button btnAgendarVacia;
        private Panel pnlModulo;
        private Guna2Button btnAgenda;
        private Panel pnlAgenda;
        private Guna2Button btnMenuEsconder;
        private Label lblTituloPrincipal;
        private Guna2Button btnRecepcion;
        private Guna2Button btnAdministracion;
        private Guna2Button btnCerrarSesion;
        private Guna2Button btnSalir;
        private Label lblAgendaCitas;
        private Label lblResultado;
        private SelectorFecha btnFechaAgenda;
        private Guna2DataGridView dgvAgenda;
        private Guna2Button btnPropietarios;
        private Guna2Button btnMascotas;
        private Guna2Button btnCitasRecepcion;
        private Guna2Button btnVeterinarios;
        private Guna2Button btnServicios;
        private Guna2Button btnUsuarios;
        private Guna2Button btnCitas;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlMenuPrincipal = new Panel();
            lblTituloPrincipal = new Label();
            lblRolMenu = new Label();
            btnAgenda = new Guna2Button();
            btnRecepcion = new Guna2Button();
            btnPropietarios = new Guna2Button();
            btnMascotas = new Guna2Button();
            btnCitasRecepcion = new Guna2Button();
            btnAdministracion = new Guna2Button();
            btnVeterinarios = new Guna2Button();
            btnServicios = new Guna2Button();
            btnUsuarios = new Guna2Button();
            btnCerrarSesion = new Guna2Button();
            btnSalir = new Guna2Button();
            btnAnterior = new Guna2Button();
            btnHoy = new Guna2Button();
            btnSiguiente = new Guna2Button();
            resumenAgenda = new TableLayoutPanel();
            lblTotal = new Label();
            lblPendientes = new Label();
            lblAtendidas = new Label();
            pnlAviso = new Panel();
            lblResultado = new Label();
            picHuella = new PictureBox();
            btnAgendarVacia = new Guna2Button();
            pnlModulo = new Panel();
            pnlAgenda = new Panel();
            btnMenuEsconder = new Guna2Button();
            lblAgendaCitas = new Label();
            btnCitas = new Guna2Button();
            btnFechaAgenda = new SelectorFecha();
            dgvAgenda = new Guna2DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            pnlMenuPrincipal.SuspendLayout();
            resumenAgenda.SuspendLayout();
            pnlAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHuella).BeginInit();
            pnlAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            pnlMenuPrincipal.BackColor = Color.FromArgb(21, 62, 61);
            pnlMenuPrincipal.Controls.Add(lblTituloPrincipal);
            pnlMenuPrincipal.Controls.Add(lblRolMenu);
            pnlMenuPrincipal.Controls.Add(btnAgenda);
            pnlMenuPrincipal.Controls.Add(btnRecepcion);
            pnlMenuPrincipal.Controls.Add(btnPropietarios);
            pnlMenuPrincipal.Controls.Add(btnMascotas);
            pnlMenuPrincipal.Controls.Add(btnCitasRecepcion);
            pnlMenuPrincipal.Controls.Add(btnAdministracion);
            pnlMenuPrincipal.Controls.Add(btnVeterinarios);
            pnlMenuPrincipal.Controls.Add(btnServicios);
            pnlMenuPrincipal.Controls.Add(btnUsuarios);
            pnlMenuPrincipal.Controls.Add(btnCerrarSesion);
            pnlMenuPrincipal.Controls.Add(btnSalir);
            pnlMenuPrincipal.Dock = DockStyle.Left;
            pnlMenuPrincipal.Location = new Point(0, 0);
            pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            pnlMenuPrincipal.Size = new Size(194, 718);
            pnlMenuPrincipal.TabIndex = 0;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = Color.White;
            lblTituloPrincipal.Location = new Point(12, 9);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(135, 45);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "VetCare";
            // 
            // lblRolMenu
            // 
            lblRolMenu.ForeColor = Color.FromArgb(181, 210, 201);
            lblRolMenu.Location = new Point(8, 668);
            lblRolMenu.Name = "lblRolMenu";
            lblRolMenu.Size = new Size(180, 24);
            lblRolMenu.TabIndex = 1;
            // 
            // btnAgenda
            // 
            btnAgenda.CustomizableEdges = customizableEdges1;
            btnAgenda.FillColor = Color.FromArgb(31, 78, 75);
            btnAgenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Image = (Image)resources.GetObject("btnAgenda.Image");
            btnAgenda.ImageAlign = HorizontalAlignment.Left;
            btnAgenda.Location = new Point(12, 63);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAgenda.Size = new Size(170, 34);
            btnAgenda.TabIndex = 1;
            btnAgenda.Text = "Agenda";
            btnAgenda.TextAlign = HorizontalAlignment.Left;
            btnAgenda.TextOffset = new Point(6, 0);
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnRecepcion
            // 
            btnRecepcion.CustomizableEdges = customizableEdges3;
            btnRecepcion.FillColor = Color.FromArgb(31, 78, 75);
            btnRecepcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecepcion.ForeColor = Color.White;
            btnRecepcion.Location = new Point(12, 110);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRecepcion.Size = new Size(170, 34);
            btnRecepcion.TabIndex = 1;
            btnRecepcion.Text = "▾  Recepción";
            btnRecepcion.TextAlign = HorizontalAlignment.Left;
            btnRecepcion.Click += btnRecepcion_Click;
            // 
            // btnPropietarios
            // 
            btnPropietarios.CustomizableEdges = customizableEdges5;
            btnPropietarios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnPropietarios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnPropietarios.FillColor = Color.FromArgb(21, 62, 61);
            btnPropietarios.Font = new Font("Segoe UI", 11F);
            btnPropietarios.ForeColor = Color.White;
            btnPropietarios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnPropietarios.Image = (Image)resources.GetObject("btnPropietarios.Image");
            btnPropietarios.ImageAlign = HorizontalAlignment.Left;
            btnPropietarios.Location = new Point(12, 148);
            btnPropietarios.Name = "btnPropietarios";
            btnPropietarios.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPropietarios.Size = new Size(170, 40);
            btnPropietarios.TabIndex = 2;
            btnPropietarios.Text = "Propietarios";
            btnPropietarios.TextAlign = HorizontalAlignment.Left;
            btnPropietarios.TextOffset = new Point(6, 0);
            btnPropietarios.Click += btnPropietarios_Click;
            // 
            // btnMascotas
            // 
            btnMascotas.CustomizableEdges = customizableEdges7;
            btnMascotas.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnMascotas.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnMascotas.FillColor = Color.FromArgb(21, 62, 61);
            btnMascotas.Font = new Font("Segoe UI", 11F);
            btnMascotas.ForeColor = Color.White;
            btnMascotas.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnMascotas.Image = (Image)resources.GetObject("btnMascotas.Image");
            btnMascotas.ImageAlign = HorizontalAlignment.Left;
            btnMascotas.Location = new Point(12, 190);
            btnMascotas.Name = "btnMascotas";
            btnMascotas.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnMascotas.Size = new Size(170, 40);
            btnMascotas.TabIndex = 3;
            btnMascotas.Text = "Mascotas";
            btnMascotas.TextAlign = HorizontalAlignment.Left;
            btnMascotas.TextOffset = new Point(6, 0);
            btnMascotas.Click += btnMascotas_Click;
            // 
            // btnCitasRecepcion
            // 
            btnCitasRecepcion.CustomizableEdges = customizableEdges9;
            btnCitasRecepcion.FillColor = Color.FromArgb(21, 62, 61);
            btnCitasRecepcion.Font = new Font("Segoe UI", 11F);
            btnCitasRecepcion.ForeColor = Color.White;
            btnCitasRecepcion.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnCitasRecepcion.Image = (Image)resources.GetObject("btnCitasRecepcion.Image");
            btnCitasRecepcion.ImageAlign = HorizontalAlignment.Left;
            btnCitasRecepcion.Location = new Point(12, 232);
            btnCitasRecepcion.Name = "btnCitasRecepcion";
            btnCitasRecepcion.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCitasRecepcion.Size = new Size(170, 40);
            btnCitasRecepcion.TabIndex = 4;
            btnCitasRecepcion.Text = "Citas";
            btnCitasRecepcion.TextAlign = HorizontalAlignment.Left;
            btnCitasRecepcion.TextOffset = new Point(6, 0);
            btnCitasRecepcion.Click += btnCitas_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.CustomizableEdges = customizableEdges11;
            btnAdministracion.FillColor = Color.FromArgb(31, 78, 75);
            btnAdministracion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdministracion.ForeColor = Color.White;
            btnAdministracion.Location = new Point(12, 280);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAdministracion.Size = new Size(170, 34);
            btnAdministracion.TabIndex = 4;
            btnAdministracion.Text = "▾  Administración";
            btnAdministracion.TextAlign = HorizontalAlignment.Left;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // btnVeterinarios
            // 
            btnVeterinarios.CustomizableEdges = customizableEdges13;
            btnVeterinarios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnVeterinarios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnVeterinarios.FillColor = Color.FromArgb(21, 62, 61);
            btnVeterinarios.Font = new Font("Segoe UI", 11F);
            btnVeterinarios.ForeColor = Color.White;
            btnVeterinarios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnVeterinarios.Image = (Image)resources.GetObject("btnVeterinarios.Image");
            btnVeterinarios.ImageAlign = HorizontalAlignment.Left;
            btnVeterinarios.Location = new Point(12, 319);
            btnVeterinarios.Name = "btnVeterinarios";
            btnVeterinarios.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnVeterinarios.Size = new Size(170, 40);
            btnVeterinarios.TabIndex = 5;
            btnVeterinarios.Text = "Veterinarios";
            btnVeterinarios.TextAlign = HorizontalAlignment.Left;
            btnVeterinarios.TextOffset = new Point(6, 0);
            btnVeterinarios.Click += btnVeterinarios_Click;
            // 
            // btnServicios
            // 
            btnServicios.CustomizableEdges = customizableEdges15;
            btnServicios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnServicios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnServicios.FillColor = Color.FromArgb(21, 62, 61);
            btnServicios.Font = new Font("Segoe UI", 11F);
            btnServicios.ForeColor = Color.White;
            btnServicios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnServicios.Image = (Image)resources.GetObject("btnServicios.Image");
            btnServicios.ImageAlign = HorizontalAlignment.Left;
            btnServicios.Location = new Point(12, 361);
            btnServicios.Name = "btnServicios";
            btnServicios.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnServicios.Size = new Size(170, 40);
            btnServicios.TabIndex = 6;
            btnServicios.Text = "Servicios";
            btnServicios.TextAlign = HorizontalAlignment.Left;
            btnServicios.TextOffset = new Point(6, 0);
            btnServicios.Click += btnServicios_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.CustomizableEdges = customizableEdges17;
            btnUsuarios.DisabledState.FillColor = Color.FromArgb(21, 62, 61);
            btnUsuarios.DisabledState.ForeColor = Color.FromArgb(149, 171, 168);
            btnUsuarios.FillColor = Color.FromArgb(21, 62, 61);
            btnUsuarios.Font = new Font("Segoe UI", 11F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.HoverState.FillColor = Color.FromArgb(37, 91, 87);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = HorizontalAlignment.Left;
            btnUsuarios.Location = new Point(12, 403);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnUsuarios.Size = new Size(170, 40);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = HorizontalAlignment.Left;
            btnUsuarios.TextOffset = new Point(6, 0);
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.CustomizableEdges = customizableEdges19;
            btnCerrarSesion.FillColor = Color.FromArgb(31, 78, 75);
            btnCerrarSesion.Font = new Font("Segoe UI", 9F);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(12, 565);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnCerrarSesion.Size = new Size(170, 36);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalir.CustomizableEdges = customizableEdges21;
            btnSalir.FillColor = Color.FromArgb(21, 62, 61);
            btnSalir.Font = new Font("Segoe UI", 9F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(12, 609);
            btnSalir.Name = "btnSalir";
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnSalir.Size = new Size(170, 36);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir del programa";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.AccessibleName = "Día anterior";
            btnAnterior.BorderRadius = 5;
            btnAnterior.CustomizableEdges = customizableEdges23;
            btnAnterior.FillColor = Color.FromArgb(225, 238, 231);
            btnAnterior.Font = new Font("Segoe UI", 9F);
            btnAnterior.ForeColor = Color.FromArgb(21, 62, 61);
            btnAnterior.Location = new Point(34, 88);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnAnterior.Size = new Size(42, 38);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "‹";
            btnAnterior.Click += CambiarDia;
            // 
            // btnHoy
            // 
            btnHoy.AccessibleName = "Hoy";
            btnHoy.BorderRadius = 5;
            btnHoy.CustomizableEdges = customizableEdges25;
            btnHoy.FillColor = Color.FromArgb(17, 107, 94);
            btnHoy.Font = new Font("Segoe UI", 9F);
            btnHoy.ForeColor = Color.White;
            btnHoy.Location = new Point(82, 88);
            btnHoy.Name = "btnHoy";
            btnHoy.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnHoy.Size = new Size(60, 38);
            btnHoy.TabIndex = 1;
            btnHoy.Text = "Hoy";
            btnHoy.Click += CambiarDia;
            // 
            // btnSiguiente
            // 
            btnSiguiente.AccessibleName = "Día siguiente";
            btnSiguiente.BorderRadius = 5;
            btnSiguiente.CustomizableEdges = customizableEdges27;
            btnSiguiente.FillColor = Color.FromArgb(225, 238, 231);
            btnSiguiente.Font = new Font("Segoe UI", 9F);
            btnSiguiente.ForeColor = Color.FromArgb(21, 62, 61);
            btnSiguiente.Location = new Point(148, 88);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnSiguiente.Size = new Size(42, 38);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "›";
            btnSiguiente.Click += CambiarDia;
            // 
            // resumenAgenda
            // 
            resumenAgenda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resumenAgenda.ColumnCount = 3;
            resumenAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            resumenAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            resumenAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            resumenAgenda.Controls.Add(lblTotal, 0, 0);
            resumenAgenda.Controls.Add(lblPendientes, 1, 0);
            resumenAgenda.Controls.Add(lblAtendidas, 2, 0);
            resumenAgenda.Location = new Point(34, 141);
            resumenAgenda.Name = "resumenAgenda";
            resumenAgenda.RowCount = 1;
            resumenAgenda.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            resumenAgenda.Size = new Size(960, 66);
            resumenAgenda.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(230, 240, 235);
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(21, 62, 61);
            lblTotal.Location = new Point(3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(12, 0, 0, 0);
            lblTotal.Size = new Size(310, 66);
            lblTotal.TabIndex = 0;
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPendientes
            // 
            lblPendientes.BackColor = Color.FromArgb(230, 240, 235);
            lblPendientes.Dock = DockStyle.Fill;
            lblPendientes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPendientes.ForeColor = Color.FromArgb(21, 62, 61);
            lblPendientes.Location = new Point(319, 0);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Padding = new Padding(12, 0, 0, 0);
            lblPendientes.Size = new Size(310, 66);
            lblPendientes.TabIndex = 1;
            lblPendientes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAtendidas
            // 
            lblAtendidas.BackColor = Color.FromArgb(230, 240, 235);
            lblAtendidas.Dock = DockStyle.Fill;
            lblAtendidas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAtendidas.ForeColor = Color.FromArgb(21, 62, 61);
            lblAtendidas.Location = new Point(635, 0);
            lblAtendidas.Name = "lblAtendidas";
            lblAtendidas.Padding = new Padding(12, 0, 0, 0);
            lblAtendidas.Size = new Size(322, 66);
            lblAtendidas.TabIndex = 2;
            lblAtendidas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlAviso
            // 
            pnlAviso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAviso.BackColor = Color.White;
            pnlAviso.Controls.Add(lblResultado);
            pnlAviso.Controls.Add(picHuella);
            pnlAviso.Controls.Add(btnAgendarVacia);
            pnlAviso.Location = new Point(34, 260);
            pnlAviso.Name = "pnlAviso";
            pnlAviso.Size = new Size(960, 432);
            pnlAviso.TabIndex = 4;
            pnlAviso.Resize += CentrarAviso;
            // 
            // lblResultado
            // 
            lblResultado.ForeColor = Color.FromArgb(21, 62, 61);
            lblResultado.Location = new Point(0, 113);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(684, 45);
            lblResultado.TabIndex = 6;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picHuella
            // 
            picHuella.Image = (Image)resources.GetObject("picHuella.Image");
            picHuella.Location = new Point(326, 73);
            picHuella.Name = "picHuella";
            picHuella.Size = new Size(32, 32);
            picHuella.SizeMode = PictureBoxSizeMode.Zoom;
            picHuella.TabIndex = 7;
            picHuella.TabStop = false;
            // 
            // btnAgendarVacia
            // 
            btnAgendarVacia.BorderRadius = 5;
            btnAgendarVacia.CustomizableEdges = customizableEdges29;
            btnAgendarVacia.FillColor = Color.FromArgb(17, 107, 94);
            btnAgendarVacia.Font = new Font("Segoe UI", 9F);
            btnAgendarVacia.ForeColor = Color.White;
            btnAgendarVacia.Location = new Point(262, 166);
            btnAgendarVacia.Name = "btnAgendarVacia";
            btnAgendarVacia.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnAgendarVacia.Size = new Size(160, 35);
            btnAgendarVacia.TabIndex = 7;
            btnAgendarVacia.Text = "+  Agendar una cita";
            btnAgendarVacia.Click += btnCitas_Click;
            // 
            // pnlModulo
            // 
            pnlModulo.AutoScroll = true;
            pnlModulo.Dock = DockStyle.Fill;
            pnlModulo.Location = new Point(194, 0);
            pnlModulo.Name = "pnlModulo";
            pnlModulo.Size = new Size(1024, 718);
            pnlModulo.TabIndex = 1;
            pnlModulo.Visible = false;
            pnlModulo.ClientSizeChanged += pnlModulo_ClientSizeChanged;
            // 
            // pnlAgenda
            // 
            pnlAgenda.Controls.Add(btnAnterior);
            pnlAgenda.Controls.Add(btnHoy);
            pnlAgenda.Controls.Add(btnSiguiente);
            pnlAgenda.Controls.Add(resumenAgenda);
            pnlAgenda.Controls.Add(pnlAviso);
            pnlAgenda.Controls.Add(btnMenuEsconder);
            pnlAgenda.Controls.Add(lblAgendaCitas);
            pnlAgenda.Controls.Add(btnCitas);
            pnlAgenda.Controls.Add(btnFechaAgenda);
            pnlAgenda.Controls.Add(dgvAgenda);
            pnlAgenda.Dock = DockStyle.Fill;
            pnlAgenda.Location = new Point(194, 0);
            pnlAgenda.Name = "pnlAgenda";
            pnlAgenda.Size = new Size(1024, 718);
            pnlAgenda.TabIndex = 0;
            // 
            // btnMenuEsconder
            // 
            btnMenuEsconder.AccessibleName = "Ocultar menú lateral";
            btnMenuEsconder.BorderRadius = 6;
            btnMenuEsconder.CustomizableEdges = customizableEdges31;
            btnMenuEsconder.FillColor = Color.FromArgb(224, 238, 232);
            btnMenuEsconder.Font = new Font("Segoe UI", 16F);
            btnMenuEsconder.ForeColor = Color.FromArgb(21, 62, 61);
            btnMenuEsconder.Location = new Point(20, 26);
            btnMenuEsconder.Name = "btnMenuEsconder";
            btnMenuEsconder.ShadowDecoration.CustomizableEdges = customizableEdges32;
            btnMenuEsconder.Size = new Size(44, 40);
            btnMenuEsconder.TabIndex = 0;
            btnMenuEsconder.Text = "☰";
            btnMenuEsconder.Click += btnMenu_Click;
            // 
            // lblAgendaCitas
            // 
            lblAgendaCitas.AutoSize = true;
            lblAgendaCitas.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAgendaCitas.ForeColor = Color.FromArgb(21, 62, 61);
            lblAgendaCitas.Location = new Point(76, 20);
            lblAgendaCitas.Name = "lblAgendaCitas";
            lblAgendaCitas.Size = new Size(258, 45);
            lblAgendaCitas.TabIndex = 1;
            lblAgendaCitas.Text = "Agenda de citas";
            // 
            // btnCitas
            // 
            btnCitas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCitas.BorderRadius = 6;
            btnCitas.CustomizableEdges = customizableEdges33;
            btnCitas.FillColor = Color.FromArgb(17, 107, 94);
            btnCitas.Font = new Font("Segoe UI", 9F);
            btnCitas.ForeColor = Color.White;
            btnCitas.Location = new Point(836, 27);
            btnCitas.Name = "btnCitas";
            btnCitas.ShadowDecoration.CustomizableEdges = customizableEdges34;
            btnCitas.Size = new Size(158, 40);
            btnCitas.TabIndex = 2;
            btnCitas.Text = "+  Agendar una cita";
            btnCitas.Click += btnCitas_Click;
            // 
            // btnFechaAgenda
            // 
            btnFechaAgenda.AccessibleName = "Elegir fecha de la agenda";
            btnFechaAgenda.BorderRadius = 10;
            btnFechaAgenda.Cursor = Cursors.Hand;
            btnFechaAgenda.CustomizableEdges = customizableEdges35;
            btnFechaAgenda.FechaLarga = true;
            btnFechaAgenda.FillColor = Color.FromArgb(230, 240, 235);
            btnFechaAgenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFechaAgenda.ForeColor = Color.FromArgb(21, 62, 61);
            btnFechaAgenda.HoverState.FillColor = Color.FromArgb(217, 234, 225);
            btnFechaAgenda.Location = new Point(198, 88);
            btnFechaAgenda.Name = "btnFechaAgenda";
            btnFechaAgenda.ShadowDecoration.CustomizableEdges = customizableEdges36;
            btnFechaAgenda.Size = new Size(260, 38);
            btnFechaAgenda.TabIndex = 3;
            btnFechaAgenda.Text = "viernes 13 de noviembre de 2026  ▾";
            btnFechaAgenda.ValueChanged += CargarAgenda;
            // 
            // dgvAgenda
            // 
            dgvAgenda.AllowUserToAddRows = false;
            dgvAgenda.AllowUserToDeleteRows = false;
            dgvAgenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(222, 235, 229);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgenda.ColumnHeadersHeight = 38;
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAgenda.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(202, 229, 218);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(21, 62, 61);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAgenda.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAgenda.GridColor = Color.FromArgb(231, 229, 255);
            dgvAgenda.Location = new Point(34, 222);
            dgvAgenda.MultiSelect = false;
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.ReadOnly = true;
            dgvAgenda.RowHeadersVisible = false;
            dgvAgenda.RowTemplate.Height = 36;
            dgvAgenda.Size = new Size(960, 470);
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
            ClientSize = new Size(1218, 718);
            Controls.Add(pnlAgenda);
            Controls.Add(pnlModulo);
            Controls.Add(pnlMenuPrincipal);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(830, 604);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetCare";
            Load += CargarAgenda;
            pnlMenuPrincipal.ResumeLayout(false);
            pnlMenuPrincipal.PerformLayout();
            resumenAgenda.ResumeLayout(false);
            pnlAviso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHuella).EndInit();
            pnlAgenda.ResumeLayout(false);
            pnlAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
