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
            panelTop = new Panel();
            label1 = new Label();
            panelMenu = new Panel();
            btnCerrarSesion = new Button();
            btnPerfil = new Button();
            btnConfiguracion = new Button();
            btnSolicitudes = new Button();
            btnMiCredencial = new Button();
            btnInicio = new Button();
            panelContenido = new Panel();
            btnProbarValidaciones = new Button();
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
            panelTop.SuspendLayout();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            groupCredencial.SuspendLayout();
            groupDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 51, 102);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.MinimumSize = new Size(0, 80);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1465, 80);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(232, 46);
            label1.TabIndex = 0;
            label1.Text = "CredenSoft";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnPerfil);
            panelMenu.Controls.Add(btnConfiguracion);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnMiCredencial);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 80);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(235, 961);
            panelMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F);
            btnCerrarSesion.Location = new Point(3, 903);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(230, 55);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.Font = new Font("Segoe UI", 12F);
            btnPerfil.Location = new Point(6, 235);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(230, 55);
            btnPerfil.TabIndex = 4;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.Font = new Font("Segoe UI", 12F);
            btnConfiguracion.Location = new Point(6, 311);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(230, 55);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.Font = new Font("Segoe UI", 12F);
            btnSolicitudes.Location = new Point(6, 158);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(230, 55);
            btnSolicitudes.TabIndex = 2;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.UseVisualStyleBackColor = true;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // btnMiCredencial
            // 
            btnMiCredencial.FlatAppearance.BorderSize = 0;
            btnMiCredencial.Font = new Font("Segoe UI", 12F);
            btnMiCredencial.Location = new Point(6, 81);
            btnMiCredencial.Name = "btnMiCredencial";
            btnMiCredencial.Size = new Size(230, 55);
            btnMiCredencial.TabIndex = 1;
            btnMiCredencial.Text = "Mi Credencial";
            btnMiCredencial.UseVisualStyleBackColor = true;
            btnMiCredencial.Click += btnMiCredencial_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Gainsboro;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Font = new Font("Segoe UI", 12F);
            btnInicio.Location = new Point(6, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(230, 55);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(btnProbarValidaciones);
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
            panelContenido.Location = new Point(235, 80);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1230, 961);
            panelContenido.TabIndex = 2;
            // 
            // btnProbarValidaciones
            // 
            btnProbarValidaciones.Location = new Point(0, 0);
            btnProbarValidaciones.Name = "btnProbarValidaciones";
            btnProbarValidaciones.Size = new Size(75, 23);
            btnProbarValidaciones.TabIndex = 0;
            // 
            // btnActualizarPerfil
            // 
            btnActualizarPerfil.BackColor = Color.Gainsboro;
            btnActualizarPerfil.FlatAppearance.BorderSize = 0;
            btnActualizarPerfil.FlatStyle = FlatStyle.Flat;
            btnActualizarPerfil.Location = new Point(422, 903);
            btnActualizarPerfil.Name = "btnActualizarPerfil";
            btnActualizarPerfil.Size = new Size(152, 34);
            btnActualizarPerfil.TabIndex = 8;
            btnActualizarPerfil.Text = "Actualizar Perfil";
            btnActualizarPerfil.UseVisualStyleBackColor = false;
            btnActualizarPerfil.Click += btnActualizarPerfil_Click;
            // 
            // btnNuevaSolicitud
            // 
            btnNuevaSolicitud.BackColor = Color.Honeydew;
            btnNuevaSolicitud.FlatAppearance.BorderSize = 0;
            btnNuevaSolicitud.FlatStyle = FlatStyle.Flat;
            btnNuevaSolicitud.Location = new Point(227, 903);
            btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            btnNuevaSolicitud.Size = new Size(152, 34);
            btnNuevaSolicitud.TabIndex = 7;
            btnNuevaSolicitud.Text = "Nueva Solicitud";
            btnNuevaSolicitud.UseVisualStyleBackColor = false;
            btnNuevaSolicitud.Click += btnNuevaSolicitud_Click;
            // 
            // btnVerCredencial
            // 
            btnVerCredencial.BackColor = Color.LightSteelBlue;
            btnVerCredencial.FlatAppearance.BorderSize = 0;
            btnVerCredencial.FlatStyle = FlatStyle.Flat;
            btnVerCredencial.Location = new Point(33, 903);
            btnVerCredencial.Name = "btnVerCredencial";
            btnVerCredencial.Size = new Size(152, 34);
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
            dgvSolicitudes.Size = new Size(1077, 225);
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
            groupDatosUsuario.Size = new Size(448, 348);
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
            panelMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            groupCredencial.ResumeLayout(false);
            groupCredencial.PerformLayout();
            groupDatosUsuario.ResumeLayout(false);
            groupDatosUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelMenu;
        private Button btnCerrarSesion;
        private Button btnPerfil;
        private Button btnConfiguracion;
        private Button btnSolicitudes;
        private Button btnMiCredencial;
        private Button btnInicio;
        private Label label1;
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
        private Button btnProbarValidaciones;
    }
}