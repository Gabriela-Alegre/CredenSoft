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
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            btnGestiónDeUsuarios = new Button();
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
            btnVerCredenciales.Location = new Point(26, 457);
            btnVerCredenciales.Margin = new Padding(2);
            btnVerCredenciales.Name = "btnVerCredenciales";
            btnVerCredenciales.Size = new Size(147, 33);
            btnVerCredenciales.TabIndex = 6;
            btnVerCredenciales.Text = "Ver Credenciales";
            btnVerCredenciales.UseVisualStyleBackColor = false;
            // 
            // lblSede
            // 
            lblSede.AutoSize = true;
            lblSede.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSede.Location = new Point(4, 76);
            lblSede.Margin = new Padding(2, 0, 2, 0);
            lblSede.Name = "lblSede";
            lblSede.Size = new Size(46, 19);
            lblSede.TabIndex = 3;
            lblSede.Text = "Sede:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(4, 50);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(4, 25);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 19);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblAccionesRápidas
            // 
            lblAccionesRápidas.AutoSize = true;
            lblAccionesRápidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccionesRápidas.ForeColor = Color.MidnightBlue;
            lblAccionesRápidas.Location = new Point(26, 409);
            lblAccionesRápidas.Margin = new Padding(2, 0, 2, 0);
            lblAccionesRápidas.Name = "lblAccionesRápidas";
            lblAccionesRápidas.Size = new Size(192, 30);
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
            dgvSolicitudes.Location = new Point(20, 302);
            dgvSolicitudes.Margin = new Padding(2);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(727, 94);
            dgvSolicitudes.TabIndex = 3;
            dgvSolicitudes.CellContentClick += dgvSolicitudes_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "Código de Solicitud";
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
            btnValidarSolicitud.Location = new Point(188, 457);
            btnValidarSolicitud.Margin = new Padding(2);
            btnValidarSolicitud.Name = "btnValidarSolicitud";
            btnValidarSolicitud.Size = new Size(147, 33);
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
            lblÚltimasSolicitudes.Location = new Point(26, 274);
            lblÚltimasSolicitudes.Margin = new Padding(2, 0, 2, 0);
            lblÚltimasSolicitudes.Name = "lblÚltimasSolicitudes";
            lblÚltimasSolicitudes.Size = new Size(210, 30);
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
            groupBox1.Location = new Point(11, 31);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(350, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado General";
            // 
            // lblValidacionesdelDía
            // 
            lblValidacionesdelDía.AutoSize = true;
            lblValidacionesdelDía.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValidacionesdelDía.Location = new Point(4, 66);
            lblValidacionesdelDía.Margin = new Padding(2, 0, 2, 0);
            lblValidacionesdelDía.Name = "lblValidacionesdelDía";
            lblValidacionesdelDía.Size = new Size(147, 19);
            lblValidacionesdelDía.TabIndex = 3;
            lblValidacionesdelDía.Text = "Validaciones del Día:";
            // 
            // lblCredencialesActivas
            // 
            lblCredencialesActivas.AutoSize = true;
            lblCredencialesActivas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCredencialesActivas.Location = new Point(4, 46);
            lblCredencialesActivas.Margin = new Padding(2, 0, 2, 0);
            lblCredencialesActivas.Name = "lblCredencialesActivas";
            lblCredencialesActivas.Size = new Size(150, 19);
            lblCredencialesActivas.TabIndex = 2;
            lblCredencialesActivas.Text = "Credenciales Activas:";
            // 
            // lblSolicitudesPendientes
            // 
            lblSolicitudesPendientes.AutoSize = true;
            lblSolicitudesPendientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSolicitudesPendientes.Location = new Point(4, 25);
            lblSolicitudesPendientes.Margin = new Padding(2, 0, 2, 0);
            lblSolicitudesPendientes.Name = "lblSolicitudesPendientes";
            lblSolicitudesPendientes.Size = new Size(162, 19);
            lblSolicitudesPendientes.TabIndex = 1;
            lblSolicitudesPendientes.Text = "Solicitudes Pendientes:";
            // 
            // lblAccesosLocales
            // 
            lblAccesosLocales.AutoSize = true;
            lblAccesosLocales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAccesosLocales.Location = new Point(4, 86);
            lblAccesosLocales.Margin = new Padding(2, 0, 2, 0);
            lblAccesosLocales.Name = "lblAccesosLocales";
            lblAccesosLocales.Size = new Size(119, 19);
            lblAccesosLocales.TabIndex = 0;
            lblAccesosLocales.Text = "Accesos Locales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 30);
            label2.TabIndex = 0;
            label2.Text = "Resumen Operativo Local";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSede);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Controls.Add(lblRol);
            groupBox2.Location = new Point(382, 31);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(371, 209);
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
            AdmininLocal.Location = new Point(175, 39);
            AdmininLocal.Margin = new Padding(2);
            AdmininLocal.Name = "AdmininLocal";
            AdmininLocal.Size = new Size(866, 530);
            AdmininLocal.TabIndex = 5;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(0, 105, 92);
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 508);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(866, 22);
            statusStrip.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Yellow;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(197, 17);
            lblStatus.Text = "● Sistema Online - Conexión Segura";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.DarkSeaGreen;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 11F);
            btnGenerarReporte.Location = new Point(351, 457);
            btnGenerarReporte.Margin = new Padding(2);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(147, 33);
            btnGenerarReporte.TabIndex = 7;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.DarkSeaGreen;
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSolicitudes.Location = new Point(0, 148);
            btnSolicitudes.Margin = new Padding(2);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(173, 36);
            btnSolicitudes.TabIndex = 6;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.UseVisualStyleBackColor = false;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // btnCredenciales
            // 
            btnCredenciales.BackColor = Color.DarkSeaGreen;
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCredenciales.Location = new Point(0, 192);
            btnCredenciales.Margin = new Padding(2);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(173, 36);
            btnCredenciales.TabIndex = 5;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.TextAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.UseVisualStyleBackColor = false;
            btnCredenciales.Click += btnCredenciales_Click;
            // 
            // btnValidaciones
            // 
            btnValidaciones.BackColor = Color.DarkSeaGreen;
            btnValidaciones.FlatAppearance.BorderSize = 0;
            btnValidaciones.FlatStyle = FlatStyle.Flat;
            btnValidaciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnValidaciones.Location = new Point(0, 281);
            btnValidaciones.Margin = new Padding(2);
            btnValidaciones.Name = "btnValidaciones";
            btnValidaciones.Size = new Size(173, 36);
            btnValidaciones.TabIndex = 2;
            btnValidaciones.Text = "Validaciones";
            btnValidaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnValidaciones.UseVisualStyleBackColor = false;
            btnValidaciones.Click += btnValidaciones_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.DarkSeaGreen;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 59);
            btnInicio.Margin = new Padding(2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(173, 36);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(0, 105, 92);
            panelSuperior.Controls.Add(lblInfoUsuario);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(175, 0);
            panelSuperior.Margin = new Padding(2);
            panelSuperior.MaximumSize = new Size(0, 48);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(866, 39);
            panelSuperior.TabIndex = 3;
            // 
            // lblInfoUsuario
            // 
            lblInfoUsuario.AutoSize = true;
            lblInfoUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblInfoUsuario.Location = new Point(736, 14);
            lblInfoUsuario.Margin = new Padding(2, 0, 2, 0);
            lblInfoUsuario.Name = "lblInfoUsuario";
            lblInfoUsuario.Size = new Size(110, 15);
            lblInfoUsuario.TabIndex = 6;
            lblInfoUsuario.Text = "Cargando usuario...";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 105, 92);
            panelMenu.Controls.Add(btnPerfil);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnGestiónDeUsuarios);
            panelMenu.Controls.Add(btnConfiguración);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnCredenciales);
            panelMenu.Controls.Add(btnValidaciones);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(175, 569);
            panelMenu.TabIndex = 4;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.DarkSeaGreen;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPerfil.Location = new Point(0, 325);
            btnPerfil.Margin = new Padding(2);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(179, 33);
            btnPerfil.TabIndex = 11;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextAlign = ContentAlignment.BottomLeft;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.DarkSeaGreen;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 511);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(175, 58);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesión_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-44, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnGestiónDeUsuarios
            // 
            btnGestiónDeUsuarios.BackColor = Color.DarkSeaGreen;
            btnGestiónDeUsuarios.FlatAppearance.BorderSize = 0;
            btnGestiónDeUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestiónDeUsuarios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGestiónDeUsuarios.ForeColor = Color.White;
            btnGestiónDeUsuarios.Location = new Point(0, 103);
            btnGestiónDeUsuarios.Margin = new Padding(2);
            btnGestiónDeUsuarios.Name = "btnGestiónDeUsuarios";
            btnGestiónDeUsuarios.Size = new Size(173, 36);
            btnGestiónDeUsuarios.TabIndex = 10;
            btnGestiónDeUsuarios.Text = "Gestión de Usuarios";
            btnGestiónDeUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnGestiónDeUsuarios.UseVisualStyleBackColor = false;
            btnGestiónDeUsuarios.Click += btnGestiónDeUsuarios_Click;
            // 
            // btnConfiguración
            // 
            btnConfiguración.BackColor = Color.DarkSeaGreen;
            btnConfiguración.FlatAppearance.BorderSize = 0;
            btnConfiguración.FlatStyle = FlatStyle.Flat;
            btnConfiguración.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfiguración.Location = new Point(0, 236);
            btnConfiguración.Margin = new Padding(2);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(173, 36);
            btnConfiguración.TabIndex = 8;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguración.UseVisualStyleBackColor = false;
            btnConfiguración.Click += btnConfiguración_Click;
            // 
            // FrmDashboardLocal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 569);
            Controls.Add(AdmininLocal);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "FrmDashboardLocal";
            Text = "Panel Principal CredenSoft";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashboardLocal_Load_1;
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
        private Button btnConfiguración;
        private PictureBox pictureBox1;
        private Button btnCerrarSesion;
        private Button btnGestiónDeUsuarios;
        private Label lblInfoUsuario;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private Button btnPerfil;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colAgente;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
    }
}