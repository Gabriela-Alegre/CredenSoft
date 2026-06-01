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
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            btnSolicitudes = new Button();
            btnCredenciales = new Button();
            btnAuditoría = new Button();
            btnConfiguración = new Button();
            btnGestiónDeUsuarios = new Button();
            btnInicio = new Button();
            panelPrincipal = new Panel();
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
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(25, 35, 50);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(274, 0);
            panelSuperior.MaximumSize = new Size(0, 80);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1088, 80);
            panelSuperior.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 35, 50);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnCredenciales);
            panelMenu.Controls.Add(btnAuditoría);
            panelMenu.Controls.Add(btnConfiguración);
            panelMenu.Controls.Add(btnGestiónDeUsuarios);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(274, 1050);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-44, -7);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            btnCerrarSesion.Location = new Point(0, 953);
            btnCerrarSesion.Margin = new Padding(6, 5, 6, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(274, 97);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.FromArgb(44, 62, 80);
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Segoe UI", 12F);
            btnSolicitudes.ForeColor = Color.White;
            btnSolicitudes.Location = new Point(3, 276);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(268, 60);
            btnSolicitudes.TabIndex = 6;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.UseVisualStyleBackColor = false;
            // 
            // btnCredenciales
            // 
            btnCredenciales.BackColor = Color.FromArgb(44, 62, 80);
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.Font = new Font("Segoe UI", 12F);
            btnCredenciales.ForeColor = Color.White;
            btnCredenciales.Location = new Point(3, 353);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(268, 60);
            btnCredenciales.TabIndex = 5;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.TextAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.UseVisualStyleBackColor = false;
            // 
            // btnAuditoría
            // 
            btnAuditoría.BackColor = Color.FromArgb(44, 62, 80);
            btnAuditoría.FlatAppearance.BorderSize = 0;
            btnAuditoría.FlatStyle = FlatStyle.Flat;
            btnAuditoría.Font = new Font("Segoe UI", 12F);
            btnAuditoría.ForeColor = Color.White;
            btnAuditoría.Location = new Point(3, 429);
            btnAuditoría.Name = "btnAuditoría";
            btnAuditoría.Size = new Size(268, 60);
            btnAuditoría.TabIndex = 4;
            btnAuditoría.Text = "Auditoría";
            btnAuditoría.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditoría.UseVisualStyleBackColor = false;
            // 
            // btnConfiguración
            // 
            btnConfiguración.BackColor = Color.FromArgb(44, 62, 80);
            btnConfiguración.FlatAppearance.BorderSize = 0;
            btnConfiguración.FlatStyle = FlatStyle.Flat;
            btnConfiguración.Font = new Font("Segoe UI", 12F);
            btnConfiguración.ForeColor = Color.White;
            btnConfiguración.Location = new Point(3, 506);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(268, 60);
            btnConfiguración.TabIndex = 3;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguración.UseVisualStyleBackColor = false;
            // 
            // btnGestiónDeUsuarios
            // 
            btnGestiónDeUsuarios.BackColor = Color.FromArgb(44, 62, 80);
            btnGestiónDeUsuarios.FlatAppearance.BorderSize = 0;
            btnGestiónDeUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestiónDeUsuarios.Font = new Font("Segoe UI", 12F);
            btnGestiónDeUsuarios.ForeColor = Color.White;
            btnGestiónDeUsuarios.Location = new Point(3, 199);
            btnGestiónDeUsuarios.Name = "btnGestiónDeUsuarios";
            btnGestiónDeUsuarios.Size = new Size(268, 60);
            btnGestiónDeUsuarios.TabIndex = 2;
            btnGestiónDeUsuarios.Text = "Gestión de Usuarios";
            btnGestiónDeUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnGestiónDeUsuarios.UseVisualStyleBackColor = false;
            btnGestiónDeUsuarios.Click += btnGestiónDeUsuarios_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(44, 62, 80);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(3, 124);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(268, 60);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
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
            panelPrincipal.Location = new Point(274, 80);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1088, 970);
            panelPrincipal.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblRol);
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Location = new Point(507, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(581, 348);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Sesión";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(8, 156);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(75, 28);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(8, 114);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.Location = new Point(8, 72);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(44, 28);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(8, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 28);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // btnEmitirCredencial
            // 
            btnEmitirCredencial.BackColor = Color.DarkSeaGreen;
            btnEmitirCredencial.FlatStyle = FlatStyle.Flat;
            btnEmitirCredencial.Font = new Font("Segoe UI", 11F);
            btnEmitirCredencial.Location = new Point(306, 908);
            btnEmitirCredencial.Name = "btnEmitirCredencial";
            btnEmitirCredencial.Size = new Size(210, 55);
            btnEmitirCredencial.TabIndex = 7;
            btnEmitirCredencial.Text = "Emitir Credencial";
            btnEmitirCredencial.UseVisualStyleBackColor = false;
            // 
            // btnVerSolicitudes
            // 
            btnVerSolicitudes.BackColor = Color.Lavender;
            btnVerSolicitudes.FlatStyle = FlatStyle.Flat;
            btnVerSolicitudes.Font = new Font("Segoe UI", 11F);
            btnVerSolicitudes.Location = new Point(47, 908);
            btnVerSolicitudes.Name = "btnVerSolicitudes";
            btnVerSolicitudes.Size = new Size(210, 55);
            btnVerSolicitudes.TabIndex = 6;
            btnVerSolicitudes.Text = "Ver Solicitudes";
            btnVerSolicitudes.UseVisualStyleBackColor = false;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.LightSteelBlue;
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Segoe UI", 11F);
            btnNuevoUsuario.Location = new Point(565, 908);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(210, 55);
            btnNuevoUsuario.TabIndex = 5;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // lblAccionesRápidas
            // 
            lblAccionesRápidas.AutoSize = true;
            lblAccionesRápidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccionesRápidas.ForeColor = Color.MidnightBlue;
            lblAccionesRápidas.Location = new Point(25, 801);
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
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { colID, colEstado, colFecha, colTipo });
            dgvSolicitudes.Location = new Point(25, 542);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(1063, 157);
            dgvSolicitudes.TabIndex = 3;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
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
            lblÚltimasSolicitudes.Location = new Point(25, 478);
            lblÚltimasSolicitudes.Name = "lblÚltimasSolicitudes";
            lblÚltimasSolicitudes.Size = new Size(304, 45);
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
            groupBox1.Location = new Point(30, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 348);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado General";
            // 
            // lblAccesosRegistradosHoy
            // 
            lblAccesosRegistradosHoy.AutoSize = true;
            lblAccesosRegistradosHoy.Location = new Point(6, 146);
            lblAccesosRegistradosHoy.Name = "lblAccesosRegistradosHoy";
            lblAccesosRegistradosHoy.Size = new Size(233, 28);
            lblAccesosRegistradosHoy.TabIndex = 3;
            lblAccesosRegistradosHoy.Text = "Accesos Registrados Hoy:";
            // 
            // lblCredencialesEmitidas
            // 
            lblCredencialesEmitidas.AutoSize = true;
            lblCredencialesEmitidas.Location = new Point(6, 109);
            lblCredencialesEmitidas.Name = "lblCredencialesEmitidas";
            lblCredencialesEmitidas.Size = new Size(204, 28);
            lblCredencialesEmitidas.TabIndex = 2;
            lblCredencialesEmitidas.Text = "Credenciales Emitidas:";
            // 
            // lblSolicitudesPendientes
            // 
            lblSolicitudesPendientes.AutoSize = true;
            lblSolicitudesPendientes.Location = new Point(6, 72);
            lblSolicitudesPendientes.Name = "lblSolicitudesPendientes";
            lblSolicitudesPendientes.Size = new Size(210, 28);
            lblSolicitudesPendientes.TabIndex = 1;
            lblSolicitudesPendientes.Text = "Solicitudes Pendientes:";
            // 
            // lblUsuariosActivos
            // 
            lblUsuariosActivos.AutoSize = true;
            lblUsuariosActivos.Location = new Point(6, 35);
            lblUsuariosActivos.Name = "lblUsuariosActivos";
            lblUsuariosActivos.Size = new Size(160, 28);
            lblUsuariosActivos.TabIndex = 0;
            lblUsuariosActivos.Text = "Usuarios Activos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(25, 3);
            label2.Name = "label2";
            label2.Size = new Size(459, 45);
            label2.TabIndex = 0;
            label2.Text = "Resumen General del Sistema";
            label2.Click += label2_Click;
            // 
            // FrmDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 1050);
            Controls.Add(panelPrincipal);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            Name = "FrmDashboardAdmin";
            Text = "FrmDashboardAdmin";
            Load += FrmDashboardAdmin_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
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
        private Button btnSolicitudes;
        private Button btnCredenciales;
        private Button btnAuditoría;
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
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTipo;
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
    }
}