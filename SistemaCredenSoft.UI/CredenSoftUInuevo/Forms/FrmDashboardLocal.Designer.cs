namespace CredenSoftUInuevo.Forms
{
    partial class FrmDashboardLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardLocal));
            btnVerCredenciales = new Button();
            lblSede = new Label();
            lblNombre = new Label();
            lblRol = new Label();
            lblAccionesRápidas = new Label();
            dgvSolicitudes = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colAgente = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            btnValidarSolicitud = new Button();
            lblÚltimasSolicitudes = new Label();
            groupBox1 = new GroupBox();
            lblValidacionesdelDía = new Label();
            lblCredencialesActivas = new Label();
            lblSolicitudesPendientes = new Label();
            lblAccesosLocales = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            AdmininLocal = new Panel();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            btnGenerarReporte = new Button();
            btnSolicitudes = new Button();
            btnCredenciales = new Button();
            btnValidaciones = new Button();
            btnInicio = new Button();
            panelSuperior = new Panel();
            lblInfoUsuario = new Label();
            panelMenu = new Panel();
            btnGestiónDeUsuarios = new Button();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            btnConfiguración = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            AdmininLocal.SuspendLayout();
            statusStrip.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVerCredenciales
            // 
            btnVerCredenciales.BackColor = Color.Lavender;
            btnVerCredenciales.FlatStyle = FlatStyle.Flat;
            btnVerCredenciales.Font = new Font("Segoe UI", 11F);
            btnVerCredenciales.Location = new Point(37, 761);
            btnVerCredenciales.Name = "btnVerCredenciales";
            btnVerCredenciales.Size = new Size(210, 55);
            btnVerCredenciales.TabIndex = 6;
            btnVerCredenciales.Text = "Ver Credenciales";
            btnVerCredenciales.UseVisualStyleBackColor = false;
            // 
            // lblSede
            // 
            lblSede.AutoSize = true;
            lblSede.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSede.Location = new Point(6, 126);
            lblSede.Name = "lblSede";
            lblSede.Size = new Size(62, 28);
            lblSede.TabIndex = 3;
            lblSede.Text = "Sede:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(6, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(6, 42);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(48, 28);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblAccionesRápidas
            // 
            lblAccionesRápidas.AutoSize = true;
            lblAccionesRápidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccionesRápidas.ForeColor = Color.MidnightBlue;
            lblAccionesRápidas.Location = new Point(37, 681);
            lblAccionesRápidas.Name = "lblAccionesRápidas";
            lblAccionesRápidas.Size = new Size(279, 45);
            lblAccionesRápidas.TabIndex = 4;
            lblAccionesRápidas.Text = "Acciones Rápidas";
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.BackgroundColor = Color.White;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { colID, colAgente, colEstado, colFecha });
            dgvSolicitudes.Location = new Point(28, 504);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(1038, 157);
            dgvSolicitudes.TabIndex = 3;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colAgente
            // 
            colAgente.HeaderText = "Agente";
            colAgente.MinimumWidth = 8;
            colAgente.Name = "colAgente";
            colAgente.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 8;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // btnValidarSolicitud
            // 
            btnValidarSolicitud.BackColor = Color.LightSteelBlue;
            btnValidarSolicitud.FlatStyle = FlatStyle.Flat;
            btnValidarSolicitud.Font = new Font("Segoe UI", 11F);
            btnValidarSolicitud.Location = new Point(269, 761);
            btnValidarSolicitud.Name = "btnValidarSolicitud";
            btnValidarSolicitud.Size = new Size(210, 55);
            btnValidarSolicitud.TabIndex = 5;
            btnValidarSolicitud.Text = "Validar Solicitud";
            btnValidarSolicitud.UseVisualStyleBackColor = false;
            btnValidarSolicitud.Click += btnValidarSolicitud_Click;
            // 
            // lblÚltimasSolicitudes
            // 
            lblÚltimasSolicitudes.AutoSize = true;
            lblÚltimasSolicitudes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblÚltimasSolicitudes.ForeColor = Color.MidnightBlue;
            lblÚltimasSolicitudes.Location = new Point(37, 456);
            lblÚltimasSolicitudes.Name = "lblÚltimasSolicitudes";
            lblÚltimasSolicitudes.Size = new Size(304, 45);
            lblÚltimasSolicitudes.TabIndex = 2;
            lblÚltimasSolicitudes.Text = "Últimas Solicitudes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblValidacionesdelDía);
            groupBox1.Controls.Add(lblCredencialesActivas);
            groupBox1.Controls.Add(lblSolicitudesPendientes);
            groupBox1.Controls.Add(lblAccesosLocales);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(16, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 348);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado General";
            // 
            // lblValidacionesdelDía
            // 
            lblValidacionesdelDía.AutoSize = true;
            lblValidacionesdelDía.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValidacionesdelDía.Location = new Point(6, 110);
            lblValidacionesdelDía.Name = "lblValidacionesdelDía";
            lblValidacionesdelDía.Size = new Size(207, 28);
            lblValidacionesdelDía.TabIndex = 3;
            lblValidacionesdelDía.Text = "Validaciones del Día:";
            // 
            // lblCredencialesActivas
            // 
            lblCredencialesActivas.AutoSize = true;
            lblCredencialesActivas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCredencialesActivas.Location = new Point(6, 76);
            lblCredencialesActivas.Name = "lblCredencialesActivas";
            lblCredencialesActivas.Size = new Size(211, 28);
            lblCredencialesActivas.TabIndex = 2;
            lblCredencialesActivas.Text = "Credenciales Activas:";
            // 
            // lblSolicitudesPendientes
            // 
            lblSolicitudesPendientes.AutoSize = true;
            lblSolicitudesPendientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSolicitudesPendientes.Location = new Point(6, 42);
            lblSolicitudesPendientes.Name = "lblSolicitudesPendientes";
            lblSolicitudesPendientes.Size = new Size(229, 28);
            lblSolicitudesPendientes.TabIndex = 1;
            lblSolicitudesPendientes.Text = "Solicitudes Pendientes:";
            // 
            // lblAccesosLocales
            // 
            lblAccesosLocales.AutoSize = true;
            lblAccesosLocales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAccesosLocales.Location = new Point(6, 144);
            lblAccesosLocales.Name = "lblAccesosLocales";
            lblAccesosLocales.Size = new Size(167, 28);
            lblAccesosLocales.TabIndex = 0;
            lblAccesosLocales.Text = "Accesos Locales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(25, 3);
            label2.Name = "label2";
            label2.Size = new Size(399, 45);
            label2.TabIndex = 0;
            label2.Text = "Resumen Operativo Local";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSede);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Controls.Add(lblRol);
            groupBox2.Location = new Point(545, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(530, 348);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Sesión";
            // 
            // AdmininLocal
            // 
            AdmininLocal.BackColor = Color.White;
            AdmininLocal.Controls.Add(statusStrip);
            AdmininLocal.Controls.Add(groupBox2);
            AdmininLocal.Controls.Add(btnGenerarReporte);
            AdmininLocal.Controls.Add(btnVerCredenciales);
            AdmininLocal.Controls.Add(btnValidarSolicitud);
            AdmininLocal.Controls.Add(lblAccionesRápidas);
            AdmininLocal.Controls.Add(dgvSolicitudes);
            AdmininLocal.Controls.Add(lblÚltimasSolicitudes);
            AdmininLocal.Controls.Add(groupBox1);
            AdmininLocal.Controls.Add(label2);
            AdmininLocal.Dock = DockStyle.Fill;
            AdmininLocal.Location = new Point(259, 65);
            AdmininLocal.Name = "AdmininLocal";
            AdmininLocal.Size = new Size(1228, 886);
            AdmininLocal.TabIndex = 5;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(30, 40, 55);
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 854);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 23, 0);
            statusStrip.Size = new Size(1228, 32);
            statusStrip.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(297, 25);
            lblStatus.Text = "● Sistema Online - Conexión Segura";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.DarkSeaGreen;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 11F);
            btnGenerarReporte.Location = new Point(501, 761);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(210, 55);
            btnGenerarReporte.TabIndex = 7;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.FromArgb(44, 62, 80);
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Segoe UI", 13F);
            btnSolicitudes.Location = new Point(0, 246);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(268, 60);
            btnSolicitudes.TabIndex = 6;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.UseVisualStyleBackColor = false;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // btnCredenciales
            // 
            btnCredenciales.BackColor = Color.FromArgb(44, 62, 80);
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.Font = new Font("Segoe UI", 13F);
            btnCredenciales.Location = new Point(0, 320);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(268, 60);
            btnCredenciales.TabIndex = 5;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.TextAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.UseVisualStyleBackColor = false;
            btnCredenciales.Click += btnCredenciales_Click;
            // 
            // btnValidaciones
            // 
            btnValidaciones.BackColor = Color.FromArgb(44, 62, 80);
            btnValidaciones.FlatAppearance.BorderSize = 0;
            btnValidaciones.FlatStyle = FlatStyle.Flat;
            btnValidaciones.Font = new Font("Segoe UI", 13F);
            btnValidaciones.Location = new Point(0, 468);
            btnValidaciones.Name = "btnValidaciones";
            btnValidaciones.Size = new Size(268, 60);
            btnValidaciones.TabIndex = 2;
            btnValidaciones.Text = "Validaciones";
            btnValidaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnValidaciones.UseVisualStyleBackColor = false;
            btnValidaciones.Click += btnValidaciones_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(44, 62, 80);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 13F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 98);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(268, 60);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(25, 35, 50);
            panelSuperior.Controls.Add(lblInfoUsuario);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(259, 0);
            panelSuperior.MaximumSize = new Size(0, 80);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1228, 65);
            panelSuperior.TabIndex = 3;
            // 
            // lblInfoUsuario
            // 
            lblInfoUsuario.AutoSize = true;
            lblInfoUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblInfoUsuario.Location = new Point(1051, 24);
            lblInfoUsuario.Name = "lblInfoUsuario";
            lblInfoUsuario.Size = new Size(165, 25);
            lblInfoUsuario.TabIndex = 6;
            lblInfoUsuario.Text = "Cargando usuario...";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 35, 50);
            panelMenu.Controls.Add(btnGestiónDeUsuarios);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnConfiguración);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnCredenciales);
            panelMenu.Controls.Add(btnValidaciones);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(259, 951);
            panelMenu.TabIndex = 4;
            // 
            // btnGestiónDeUsuarios
            // 
            btnGestiónDeUsuarios.BackColor = Color.FromArgb(44, 62, 80);
            btnGestiónDeUsuarios.FlatAppearance.BorderSize = 0;
            btnGestiónDeUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestiónDeUsuarios.Font = new Font("Segoe UI", 12F);
            btnGestiónDeUsuarios.ForeColor = Color.White;
            btnGestiónDeUsuarios.Location = new Point(0, 172);
            btnGestiónDeUsuarios.Name = "btnGestiónDeUsuarios";
            btnGestiónDeUsuarios.Size = new Size(268, 60);
            btnGestiónDeUsuarios.TabIndex = 10;
            btnGestiónDeUsuarios.Text = "Gestión de Usuarios";
            btnGestiónDeUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnGestiónDeUsuarios.UseVisualStyleBackColor = false;
            btnGestiónDeUsuarios.Click += btnGestiónDeUsuarios_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(44, 62, 80);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 854);
            btnCerrarSesion.Margin = new Padding(6, 5, 6, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(259, 97);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesión_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-63, -8);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnConfiguración
            // 
            btnConfiguración.BackColor = Color.FromArgb(44, 62, 80);
            btnConfiguración.FlatAppearance.BorderSize = 0;
            btnConfiguración.FlatStyle = FlatStyle.Flat;
            btnConfiguración.Font = new Font("Segoe UI", 13F);
            btnConfiguración.Location = new Point(0, 394);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(268, 60);
            btnConfiguración.TabIndex = 8;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguración.UseVisualStyleBackColor = false;
            btnConfiguración.Click += btnConfiguración_Click;
            // 
            // FrmDashboardLocal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 951);
            Controls.Add(AdmininLocal);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            Name = "FrmDashboardLocal";
            Text = "FrmDashboardLocal";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            AdmininLocal.ResumeLayout(false);
            AdmininLocal.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerCredenciales;
        private Label lblSede;
        private Label lblNombre;
        private Label lblRol;
        private Label lblAccionesRápidas;
        private DataGridView dgvSolicitudes;
        private DataGridViewTextBoxColumn colTipo;
        private Button btnValidarSolicitud;
        private Label lblÚltimasSolicitudes;
        private GroupBox groupBox1;
        private Label lblValidacionesdelDía;
        private Label lblCredencialesActivas;
        private Label lblSolicitudesPendientes;
        private Label lblAccesosLocales;
        private Label label2;
        private GroupBox groupBox2;
        private Panel AdmininLocal;
        private Button btnGenerarReporte;
        private Button btnSolicitudes;
        private Button btnCredenciales;
        private Button btnValidaciones;
        private Button btnInicio;
        private Panel panelSuperior;
        private Panel panelMenu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colAgente;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
        private Button btnConfiguración;
        private PictureBox pictureBox1;
        private Button btnCerrarSesion;
        private Button btnGestiónDeUsuarios;
        private Label lblInfoUsuario;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
    }
}