namespace CredenSoftUInuevo.Forms
{
    partial class FrmDashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardAdmin));
            panelSuperior = new Panel();
            lblInfoUsuario = new Label();
            panelMenu = new Panel();
            btnPerfil = new Button();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            btnCredenciales = new Button();
            btnValidaciones = new Button();
            btnConfiguración = new Button();
            btnGestiónDeUsuarios = new Button();
            btnInicio = new Button();
            panelPrincipal = new Panel();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            groupBox2 = new GroupBox();
            lblEstado = new Label();
            lblFecha = new Label();
            lblRol = new Label();
            lblUsuario = new Label();
            btnEmitirCredencial = new Button();
            btnVerSolicitudes = new Button();
            btnNuevoUsuario = new Button();
            lblAccionesRápidas = new Label();
            dgvSolicitudes = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            lblÚltimasSolicitudes = new Label();
            groupBox1 = new GroupBox();
            lblAccesosRegistradosHoy = new Label();
            lblCredencialesEmitidas = new Label();
            lblSolicitudesPendientes = new Label();
            lblUsuariosActivos = new Label();
            label2 = new Label();
            panelSuperior.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
            statusStrip.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(0, 51, 102);
            panelSuperior.Controls.Add(lblInfoUsuario);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(176, 0);
            panelSuperior.Margin = new Padding(2);
            panelSuperior.MaximumSize = new Size(0, 48);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(761, 48);
            panelSuperior.TabIndex = 0;
            // 
            // lblInfoUsuario
            // 
            lblInfoUsuario.Anchor = AnchorStyles.Top;
            lblInfoUsuario.AutoSize = true;
            lblInfoUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblInfoUsuario.Location = new Point(688, 14);
            lblInfoUsuario.Margin = new Padding(2, 0, 2, 0);
            lblInfoUsuario.Name = "lblInfoUsuario";
            lblInfoUsuario.Size = new Size(140, 15);
            lblInfoUsuario.TabIndex = 6;
            lblInfoUsuario.Text = "          Cargando usuario...";
            lblInfoUsuario.Click += lblInfoUsuario_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 51, 102);
            panelMenu.Controls.Add(btnPerfil);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnCredenciales);
            panelMenu.Controls.Add(btnValidaciones);
            panelMenu.Controls.Add(btnConfiguración);
            panelMenu.Controls.Add(btnGestiónDeUsuarios);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(176, 529);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(13, 71, 161);
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(-2, 298);
            btnPerfil.Margin = new Padding(2);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(179, 33);
            btnPerfil.TabIndex = 8;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextAlign = ContentAlignment.BottomLeft;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(13, 71, 161);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 471);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(176, 58);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnCredenciales
            // 
            btnCredenciales.BackColor = Color.FromArgb(13, 71, 161);
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCredenciales.ForeColor = Color.White;
            btnCredenciales.Location = new Point(0, 118);
            btnCredenciales.Margin = new Padding(2);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(188, 36);
            btnCredenciales.TabIndex = 5;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.TextAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.UseVisualStyleBackColor = false;
            btnCredenciales.Click += btnCredenciales_Click;
            // 
            // btnValidaciones
            // 
            btnValidaciones.BackColor = Color.FromArgb(13, 71, 161);
            btnValidaciones.FlatAppearance.BorderSize = 0;
            btnValidaciones.FlatStyle = FlatStyle.Flat;
            btnValidaciones.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnValidaciones.ForeColor = Color.White;
            btnValidaciones.Location = new Point(0, 253);
            btnValidaciones.Margin = new Padding(2);
            btnValidaciones.Name = "btnValidaciones";
            btnValidaciones.Size = new Size(188, 36);
            btnValidaciones.TabIndex = 4;
            btnValidaciones.Text = "Validaciones";
            btnValidaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnValidaciones.UseVisualStyleBackColor = false;
            btnValidaciones.Click += btnValidaciones_Click;
            // 
            // btnConfiguración
            // 
            btnConfiguración.BackColor = Color.FromArgb(13, 71, 161);
            btnConfiguración.FlatAppearance.BorderSize = 0;
            btnConfiguración.FlatStyle = FlatStyle.Flat;
            btnConfiguración.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnConfiguración.ForeColor = Color.White;
            btnConfiguración.Location = new Point(0, 163);
            btnConfiguración.Margin = new Padding(2);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(188, 36);
            btnConfiguración.TabIndex = 3;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguración.UseVisualStyleBackColor = false;
            btnConfiguración.Click += btnConfiguracion_Click;
            // 
            // btnGestiónDeUsuarios
            // 
            btnGestiónDeUsuarios.BackColor = Color.FromArgb(13, 71, 161);
            btnGestiónDeUsuarios.FlatAppearance.BorderSize = 0;
            btnGestiónDeUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestiónDeUsuarios.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnGestiónDeUsuarios.ForeColor = Color.White;
            btnGestiónDeUsuarios.Location = new Point(0, 208);
            btnGestiónDeUsuarios.Margin = new Padding(2);
            btnGestiónDeUsuarios.Name = "btnGestiónDeUsuarios";
            btnGestiónDeUsuarios.Size = new Size(188, 36);
            btnGestiónDeUsuarios.TabIndex = 2;
            btnGestiónDeUsuarios.Text = "Gestión de Usuarios";
            btnGestiónDeUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnGestiónDeUsuarios.UseVisualStyleBackColor = false;
            btnGestiónDeUsuarios.Click += btnGestiónDeUsuarios_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(13, 71, 161);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 73);
            btnInicio.Margin = new Padding(2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(188, 36);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(statusStrip);
            panelPrincipal.Controls.Add(groupBox2);
            panelPrincipal.Controls.Add(btnEmitirCredencial);
            panelPrincipal.Controls.Add(btnVerSolicitudes);
            panelPrincipal.Controls.Add(btnNuevoUsuario);
            panelPrincipal.Controls.Add(lblAccionesRápidas);
            panelPrincipal.Controls.Add(dgvSolicitudes);
            panelPrincipal.Controls.Add(lblÚltimasSolicitudes);
            panelPrincipal.Controls.Add(groupBox1);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(176, 48);
            panelPrincipal.Margin = new Padding(2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(761, 481);
            panelPrincipal.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(0, 51, 102);
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 459);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(761, 22);
            statusStrip.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.MediumSpringGreen;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(197, 17);
            lblStatus.Text = "● Sistema Online - Conexión Segura";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblRol);
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Location = new Point(355, 49);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(407, 209);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Sesión";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(6, 94);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(53, 19);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(6, 68);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 19);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.Location = new Point(6, 43);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 19);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(6, 18);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // btnEmitirCredencial
            // 
            btnEmitirCredencial.BackColor = Color.DarkSeaGreen;
            btnEmitirCredencial.FlatStyle = FlatStyle.Flat;
            btnEmitirCredencial.Font = new Font("Segoe UI", 11F);
            btnEmitirCredencial.Location = new Point(210, 481);
            btnEmitirCredencial.Margin = new Padding(2);
            btnEmitirCredencial.Name = "btnEmitirCredencial";
            btnEmitirCredencial.Size = new Size(147, 33);
            btnEmitirCredencial.TabIndex = 7;
            btnEmitirCredencial.Text = "Emitir Credencial";
            btnEmitirCredencial.UseVisualStyleBackColor = false;
            btnEmitirCredencial.Click += btnEmitirCredencial_Click;
            // 
            // btnVerSolicitudes
            // 
            btnVerSolicitudes.BackColor = Color.Lavender;
            btnVerSolicitudes.FlatStyle = FlatStyle.Flat;
            btnVerSolicitudes.Font = new Font("Segoe UI", 11F);
            btnVerSolicitudes.Location = new Point(29, 481);
            btnVerSolicitudes.Margin = new Padding(2);
            btnVerSolicitudes.Name = "btnVerSolicitudes";
            btnVerSolicitudes.Size = new Size(147, 33);
            btnVerSolicitudes.TabIndex = 6;
            btnVerSolicitudes.Text = "Ver Solicitudes";
            btnVerSolicitudes.UseVisualStyleBackColor = false;
            btnVerSolicitudes.Click += btnVerSolicitudes_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.LightSteelBlue;
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Segoe UI", 11F);
            btnNuevoUsuario.Location = new Point(391, 481);
            btnNuevoUsuario.Margin = new Padding(2);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(147, 33);
            btnNuevoUsuario.TabIndex = 5;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // lblAccionesRápidas
            // 
            lblAccionesRápidas.AutoSize = true;
            lblAccionesRápidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccionesRápidas.ForeColor = Color.MidnightBlue;
            lblAccionesRápidas.Location = new Point(20, 445);
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
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { colID, colEstado, colFecha, colTipo });
            dgvSolicitudes.Location = new Point(18, 325);
            dgvSolicitudes.Margin = new Padding(2);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(744, 94);
            dgvSolicitudes.TabIndex = 3;
            // 
            // colID
            // 
            colID.HeaderText = "Código de Solicitud";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
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
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 8;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // lblÚltimasSolicitudes
            // 
            lblÚltimasSolicitudes.AutoSize = true;
            lblÚltimasSolicitudes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblÚltimasSolicitudes.ForeColor = Color.MidnightBlue;
            lblÚltimasSolicitudes.Location = new Point(18, 287);
            lblÚltimasSolicitudes.Margin = new Padding(2, 0, 2, 0);
            lblÚltimasSolicitudes.Name = "lblÚltimasSolicitudes";
            lblÚltimasSolicitudes.Size = new Size(210, 30);
            lblÚltimasSolicitudes.TabIndex = 2;
            lblÚltimasSolicitudes.Text = "Últimas Solicitudes";
            lblÚltimasSolicitudes.Click += lblÚltimasSolicitudes_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAccesosRegistradosHoy);
            groupBox1.Controls.Add(lblCredencialesEmitidas);
            groupBox1.Controls.Add(lblSolicitudesPendientes);
            groupBox1.Controls.Add(lblUsuariosActivos);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(21, 48);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(281, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado General";
            // 
            // lblAccesosRegistradosHoy
            // 
            lblAccesosRegistradosHoy.AutoSize = true;
            lblAccesosRegistradosHoy.Location = new Point(4, 88);
            lblAccesosRegistradosHoy.Margin = new Padding(2, 0, 2, 0);
            lblAccesosRegistradosHoy.Name = "lblAccesosRegistradosHoy";
            lblAccesosRegistradosHoy.Size = new Size(164, 19);
            lblAccesosRegistradosHoy.TabIndex = 3;
            lblAccesosRegistradosHoy.Text = "Accesos Registrados Hoy:";
            // 
            // lblCredencialesEmitidas
            // 
            lblCredencialesEmitidas.AutoSize = true;
            lblCredencialesEmitidas.Location = new Point(4, 65);
            lblCredencialesEmitidas.Margin = new Padding(2, 0, 2, 0);
            lblCredencialesEmitidas.Name = "lblCredencialesEmitidas";
            lblCredencialesEmitidas.Size = new Size(143, 19);
            lblCredencialesEmitidas.TabIndex = 2;
            lblCredencialesEmitidas.Text = "Credenciales Emitidas:";
            // 
            // lblSolicitudesPendientes
            // 
            lblSolicitudesPendientes.AutoSize = true;
            lblSolicitudesPendientes.Location = new Point(4, 43);
            lblSolicitudesPendientes.Margin = new Padding(2, 0, 2, 0);
            lblSolicitudesPendientes.Name = "lblSolicitudesPendientes";
            lblSolicitudesPendientes.Size = new Size(146, 19);
            lblSolicitudesPendientes.TabIndex = 1;
            lblSolicitudesPendientes.Text = "Solicitudes Pendientes:";
            // 
            // lblUsuariosActivos
            // 
            lblUsuariosActivos.AutoSize = true;
            lblUsuariosActivos.Location = new Point(4, 21);
            lblUsuariosActivos.Margin = new Padding(2, 0, 2, 0);
            lblUsuariosActivos.Name = "lblUsuariosActivos";
            lblUsuariosActivos.Size = new Size(113, 19);
            lblUsuariosActivos.TabIndex = 0;
            lblUsuariosActivos.Text = "Usuarios Activos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(317, 30);
            label2.TabIndex = 0;
            label2.Text = "Resumen General del Sistema";
            label2.Click += label2_Click;
            // 
            // FrmDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 529);
            Controls.Add(panelPrincipal);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "FrmDashboardAdmin";
            Text = "Panel Administrador Central";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashboardAdmin_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelMenu;
        private Button btnInicio;
        private Button btnCredenciales;
        private Button btnConfiguración;
        private Button btnGestiónDeUsuarios;
        private Panel panelPrincipal;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblAccesosRegistradosHoy;
        private Label lblCredencialesEmitidas;
        private Label lblSolicitudesPendientes;
        private Label lblUsuariosActivos;
        private DataGridView dataGridView1;
        private Label lblÚltimasSolicitudes;
        private DataGridView dgvSolicitudes;
        private Label lblAccionesRápidas;
        private Button btnEmitirCredencial;
        private Button btnVerSolicitudes;
        private Button btnNuevoUsuario;
        private GroupBox groupBox2;
        private Label lblUsuario;
        private Label lblEstado;
        private Label lblFecha;
        private Label lblRol;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private Button btnValidaciones;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private Label lblInfoUsuario;
        private Button btnPerfil;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTipo;
    }
}