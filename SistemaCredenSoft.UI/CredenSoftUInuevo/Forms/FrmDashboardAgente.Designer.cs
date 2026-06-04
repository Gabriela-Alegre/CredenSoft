namespace CredenSoftUInuevo.Forms
{
    partial class FrmDashboardAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardAgente));
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btnCerrarSesion = new Button();
            btnPerfil = new Button();
            btnConfiguracion = new Button();
            btnSolicitudes = new Button();
            btnMiCredencial = new Button();
            btnInicio = new Button();
            panelContenido = new Panel();
            btnActualizarPerfil = new Button();
            btnNuevaSolicitud = new Button();
            btnVerCredencial = new Button();
            lblAccionesRápidas = new Label();
            dgvSolicitudes = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            lblÚltimasSolicitudes = new Label();
            groupCredencial = new GroupBox();
            lblEstadoDeCredencial = new Label();
            lblFechaVencimiento = new Label();
            lblFechaEmisión = new Label();
            lblCredencial = new Label();
            groupDatosUsuario = new GroupBox();
            lblEstado = new Label();
            lblRol = new Label();
            lblLegajo = new Label();
            lbDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblMiPaneldeUsuario = new Label();
            lblInfoUsuario = new Label();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            groupCredencial.SuspendLayout();
            groupDatosUsuario.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(25, 35, 50);
            panelTop.Controls.Add(lblInfoUsuario);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.MinimumSize = new Size(0, 80);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1465, 80);
            panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-49, -51);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 35, 50);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnPerfil);
            panelMenu.Controls.Add(btnConfiguracion);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnMiCredencial);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 80);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(262, 961);
            panelMenu.TabIndex = 1;
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
            btnCerrarSesion.Location = new Point(0, 864);
            btnCerrarSesion.Margin = new Padding(6, 5, 6, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(262, 97);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(44, 62, 80);
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 13F);
            btnPerfil.Location = new Point(6, 213);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(256, 55);
            btnPerfil.TabIndex = 4;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextAlign = ContentAlignment.BottomLeft;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(44, 62, 80);
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 13F);
            btnConfiguracion.Location = new Point(6, 282);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(256, 55);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.TextAlign = ContentAlignment.BottomLeft;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.FromArgb(44, 62, 80);
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Segoe UI", 13F);
            btnSolicitudes.Location = new Point(6, 144);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(256, 55);
            btnSolicitudes.TabIndex = 2;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextAlign = ContentAlignment.BottomLeft;
            btnSolicitudes.UseVisualStyleBackColor = false;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // btnMiCredencial
            // 
            btnMiCredencial.BackColor = Color.FromArgb(44, 62, 80);
            btnMiCredencial.FlatAppearance.BorderSize = 0;
            btnMiCredencial.FlatStyle = FlatStyle.Flat;
            btnMiCredencial.Font = new Font("Segoe UI", 13F);
            btnMiCredencial.Location = new Point(6, 75);
            btnMiCredencial.Name = "btnMiCredencial";
            btnMiCredencial.Size = new Size(256, 55);
            btnMiCredencial.TabIndex = 1;
            btnMiCredencial.Text = "Mi Credencial";
            btnMiCredencial.TextAlign = ContentAlignment.BottomLeft;
            btnMiCredencial.UseVisualStyleBackColor = false;
            btnMiCredencial.Click += btnMiCredencial_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(44, 62, 80);
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 13F);
            btnInicio.Location = new Point(6, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(256, 55);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.BottomLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(statusStrip);
            panelContenido.Controls.Add(btnActualizarPerfil);
            panelContenido.Controls.Add(btnNuevaSolicitud);
            panelContenido.Controls.Add(btnVerCredencial);
            panelContenido.Controls.Add(lblAccionesRápidas);
            panelContenido.Controls.Add(dgvSolicitudes);
            panelContenido.Controls.Add(lblÚltimasSolicitudes);
            panelContenido.Controls.Add(groupCredencial);
            panelContenido.Controls.Add(groupDatosUsuario);
            panelContenido.Controls.Add(lblMiPaneldeUsuario);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(262, 80);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1203, 961);
            panelContenido.TabIndex = 2;
            // 
            // btnActualizarPerfil
            // 
            btnActualizarPerfil.BackColor = Color.DarkSeaGreen;
            btnActualizarPerfil.FlatAppearance.BorderSize = 0;
            btnActualizarPerfil.FlatStyle = FlatStyle.Flat;
            btnActualizarPerfil.Font = new Font("Segoe UI", 11F);
            btnActualizarPerfil.Location = new Point(271, 855);
            btnActualizarPerfil.Name = "btnActualizarPerfil";
            btnActualizarPerfil.Size = new Size(223, 55);
            btnActualizarPerfil.TabIndex = 8;
            btnActualizarPerfil.Text = "Actualizar Perfil";
            btnActualizarPerfil.UseVisualStyleBackColor = false;
            btnActualizarPerfil.Click += btnActualizarPerfil_Click;
            // 
            // btnNuevaSolicitud
            // 
            btnNuevaSolicitud.BackColor = Color.LightSteelBlue;
            btnNuevaSolicitud.FlatAppearance.BorderSize = 0;
            btnNuevaSolicitud.FlatStyle = FlatStyle.Flat;
            btnNuevaSolicitud.Font = new Font("Segoe UI", 11F);
            btnNuevaSolicitud.Location = new Point(518, 855);
            btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            btnNuevaSolicitud.Size = new Size(223, 55);
            btnNuevaSolicitud.TabIndex = 7;
            btnNuevaSolicitud.Text = "Nueva Solicitud";
            btnNuevaSolicitud.UseVisualStyleBackColor = false;
            btnNuevaSolicitud.Click += btnNuevaSolicitud_Click;
            // 
            // btnVerCredencial
            // 
            btnVerCredencial.BackColor = Color.Lavender;
            btnVerCredencial.FlatAppearance.BorderSize = 0;
            btnVerCredencial.FlatStyle = FlatStyle.Flat;
            btnVerCredencial.Font = new Font("Segoe UI", 11F);
            btnVerCredencial.Location = new Point(15, 855);
            btnVerCredencial.Name = "btnVerCredencial";
            btnVerCredencial.Size = new Size(223, 55);
            btnVerCredencial.TabIndex = 6;
            btnVerCredencial.Text = "Ver Credencial";
            btnVerCredencial.UseVisualStyleBackColor = false;
            btnVerCredencial.Click += btnVerCredencial_Click;
            // 
            // lblAccionesRápidas
            // 
            lblAccionesRápidas.AutoSize = true;
            lblAccionesRápidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccionesRápidas.ForeColor = Color.MidnightBlue;
            lblAccionesRápidas.Location = new Point(30, 789);
            lblAccionesRápidas.Name = "lblAccionesRápidas";
            lblAccionesRápidas.Size = new Size(279, 45);
            lblAccionesRápidas.TabIndex = 5;
            lblAccionesRápidas.Text = "Acciones Rápidas";
            lblAccionesRápidas.Click += lblAccionesRápidas_Click;
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.BackgroundColor = Color.White;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { colID, colTipo, colEstado, colFecha });
            dgvSolicitudes.Location = new Point(20, 547);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(1198, 225);
            dgvSolicitudes.TabIndex = 4;
            dgvSolicitudes.CellContentClick += dgvSolicitudes_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 8;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
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
            // lblÚltimasSolicitudes
            // 
            lblÚltimasSolicitudes.AutoSize = true;
            lblÚltimasSolicitudes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblÚltimasSolicitudes.ForeColor = Color.MidnightBlue;
            lblÚltimasSolicitudes.Location = new Point(20, 468);
            lblÚltimasSolicitudes.Name = "lblÚltimasSolicitudes";
            lblÚltimasSolicitudes.Size = new Size(304, 45);
            lblÚltimasSolicitudes.TabIndex = 3;
            lblÚltimasSolicitudes.Text = "Últimas Solicitudes";
            // 
            // groupCredencial
            // 
            groupCredencial.Controls.Add(lblEstadoDeCredencial);
            groupCredencial.Controls.Add(lblFechaVencimiento);
            groupCredencial.Controls.Add(lblFechaEmisión);
            groupCredencial.Controls.Add(lblCredencial);
            groupCredencial.Location = new Point(516, 80);
            groupCredencial.Name = "groupCredencial";
            groupCredencial.Size = new Size(581, 348);
            groupCredencial.TabIndex = 2;
            groupCredencial.TabStop = false;
            groupCredencial.Text = "Estado de Credencial";
            groupCredencial.Enter += groupCredencial_Enter;
            // 
            // lblEstadoDeCredencial
            // 
            lblEstadoDeCredencial.AutoSize = true;
            lblEstadoDeCredencial.Font = new Font("Segoe UI", 10F);
            lblEstadoDeCredencial.Location = new Point(6, 142);
            lblEstadoDeCredencial.Name = "lblEstadoDeCredencial";
            lblEstadoDeCredencial.Size = new Size(75, 28);
            lblEstadoDeCredencial.TabIndex = 3;
            lblEstadoDeCredencial.Text = "Estado:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Font = new Font("Segoe UI", 10F);
            lblFechaVencimiento.Location = new Point(6, 102);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(179, 28);
            lblFechaVencimiento.TabIndex = 2;
            lblFechaVencimiento.Text = "Fecha Vencimiento:";
            lblFechaVencimiento.Click += lblFechaVencimiento_Click;
            // 
            // lblFechaEmisión
            // 
            lblFechaEmisión.AutoSize = true;
            lblFechaEmisión.Font = new Font("Segoe UI", 10F);
            lblFechaEmisión.Location = new Point(6, 65);
            lblFechaEmisión.Name = "lblFechaEmisión";
            lblFechaEmisión.Size = new Size(139, 28);
            lblFechaEmisión.TabIndex = 1;
            lblFechaEmisión.Text = "Fecha Emisión:";
            // 
            // lblCredencial
            // 
            lblCredencial.AutoSize = true;
            lblCredencial.Font = new Font("Segoe UI", 10F);
            lblCredencial.Location = new Point(6, 28);
            lblCredencial.Name = "lblCredencial";
            lblCredencial.Size = new Size(135, 28);
            lblCredencial.TabIndex = 0;
            lblCredencial.Text = "N° Credencial:";
            // 
            // groupDatosUsuario
            // 
            groupDatosUsuario.Controls.Add(lblEstado);
            groupDatosUsuario.Controls.Add(lblRol);
            groupDatosUsuario.Controls.Add(lblLegajo);
            groupDatosUsuario.Controls.Add(lbDNI);
            groupDatosUsuario.Controls.Add(lblApellido);
            groupDatosUsuario.Controls.Add(lblNombre);
            groupDatosUsuario.Location = new Point(30, 80);
            groupDatosUsuario.Name = "groupDatosUsuario";
            groupDatosUsuario.Size = new Size(402, 348);
            groupDatosUsuario.TabIndex = 1;
            groupDatosUsuario.TabStop = false;
            groupDatosUsuario.Text = "Datos del Usuario";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(6, 234);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(75, 28);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.Location = new Point(6, 195);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(44, 28);
            lblRol.TabIndex = 4;
            lblRol.Text = "Rol:";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Segoe UI", 10F);
            lblLegajo.Location = new Point(6, 156);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(74, 28);
            lblLegajo.TabIndex = 3;
            lblLegajo.Text = "Legajo:";
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Font = new Font("Segoe UI", 10F);
            lbDNI.Location = new Point(6, 117);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(50, 28);
            lbDNI.TabIndex = 2;
            lbDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F);
            lblApellido.Location = new Point(6, 78);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 28);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(6, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblMiPaneldeUsuario
            // 
            lblMiPaneldeUsuario.AutoSize = true;
            lblMiPaneldeUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMiPaneldeUsuario.ForeColor = Color.MidnightBlue;
            lblMiPaneldeUsuario.Location = new Point(20, 6);
            lblMiPaneldeUsuario.Name = "lblMiPaneldeUsuario";
            lblMiPaneldeUsuario.Size = new Size(320, 45);
            lblMiPaneldeUsuario.TabIndex = 0;
            lblMiPaneldeUsuario.Text = "Mi Panel de Usuario";
            lblMiPaneldeUsuario.Click += lblMiPaneldeUsuario_Click;
            // 
            // lblInfoUsuario
            // 
            lblInfoUsuario.AutoSize = true;
            lblInfoUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblInfoUsuario.Location = new Point(1288, 27);
            lblInfoUsuario.Name = "lblInfoUsuario";
            lblInfoUsuario.Size = new Size(165, 25);
            lblInfoUsuario.TabIndex = 5;
            lblInfoUsuario.Text = "Cargando usuario...";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(30, 40, 55);
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 929);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 23, 0);
            statusStrip.Size = new Size(1203, 32);
            statusStrip.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(297, 25);
            lblStatus.Text = "● Sistema Online - Conexión Segura";
            // 
            // FrmDashboardAgente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1465, 1041);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmDashboardAgente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDashboardAgente";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            groupCredencial.ResumeLayout(false);
            groupCredencial.PerformLayout();
            groupDatosUsuario.ResumeLayout(false);
            groupDatosUsuario.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelMenu;
        private Button btnPerfil;
        private Button btnConfiguracion;
        private Button btnSolicitudes;
        private Button btnMiCredencial;
        private Button btnInicio;
        private Panel panelContenido;
        private Label lblMiPaneldeUsuario;
        private GroupBox groupDatosUsuario;
        private Label lblEstado;
        private Label lblRol;
        private Label lblLegajo;
        private Label lbDNI;
        private Label lblApellido;
        private Label lblNombre;
        private GroupBox groupCredencial;
        private Label lblEstadoDeCredencial;
        private Label lblFechaVencimiento;
        private Label lblFechaEmisión;
        private Label lblCredencial;
        private DataGridView dgvSolicitudes;
        private Label lblÚltimasSolicitudes;
        private Button btnActualizarPerfil;
        private Button btnNuevaSolicitud;
        private Button btnVerCredencial;
        private Label lblAccionesRápidas;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private Label lblInfoUsuario;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
    }
}