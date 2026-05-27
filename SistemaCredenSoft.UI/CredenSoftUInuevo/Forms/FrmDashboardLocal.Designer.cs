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
            btnProbarAccesoAdmin = new Button();
            btnGenerarReporte = new Button();
            btnCerrarSesión = new Button();
            btnSolicitudes = new Button();
            btnCredenciales = new Button();
            btnValidaciones = new Button();
            btnInicio = new Button();
            label1 = new Label();
            panelSuperior = new Panel();
            panelMenu = new Panel();
            btnConfiguración = new Button();
            btnValidaciones2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            AdmininLocal.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnVerCredenciales
            // 
            btnVerCredenciales.BackColor = Color.Gainsboro;
            btnVerCredenciales.FlatStyle = FlatStyle.Flat;
            btnVerCredenciales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVerCredenciales.Location = new Point(42, 650);
            btnVerCredenciales.Name = "btnVerCredenciales";
            btnVerCredenciales.Size = new Size(210, 55);
            btnVerCredenciales.TabIndex = 6;
            btnVerCredenciales.Text = "Ver Credenciales";
            btnVerCredenciales.UseVisualStyleBackColor = false;
            // 
            // lblSede
            // 
            lblSede.AutoSize = true;
            lblSede.Font = new Font("Segoe UI", 10F);
            lblSede.Location = new Point(6, 126);
            lblSede.Name = "lblSede";
            lblSede.Size = new Size(59, 28);
            lblSede.TabIndex = 3;
            lblSede.Text = "Sede:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(6, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.Location = new Point(6, 42);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(44, 28);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblAccionesRápidas
            // 
            lblAccionesRápidas.AutoSize = true;
            lblAccionesRápidas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAccionesRápidas.ForeColor = Color.MidnightBlue;
            lblAccionesRápidas.Location = new Point(25, 499);
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
            dgvSolicitudes.Location = new Point(16, 324);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(726, 157);
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
            btnValidarSolicitud.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnValidarSolicitud.Location = new Point(42, 570);
            btnValidarSolicitud.Name = "btnValidarSolicitud";
            btnValidarSolicitud.Size = new Size(210, 55);
            btnValidarSolicitud.TabIndex = 5;
            btnValidarSolicitud.Text = "Validar Solicitud";
            btnValidarSolicitud.UseVisualStyleBackColor = false;
            // 
            // lblÚltimasSolicitudes
            // 
            lblÚltimasSolicitudes.AutoSize = true;
            lblÚltimasSolicitudes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblÚltimasSolicitudes.ForeColor = Color.MidnightBlue;
            lblÚltimasSolicitudes.Location = new Point(25, 276);
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
            groupBox1.Size = new Size(350, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado General";
            // 
            // lblValidacionesdelDía
            // 
            lblValidacionesdelDía.AutoSize = true;
            lblValidacionesdelDía.Location = new Point(6, 110);
            lblValidacionesdelDía.Name = "lblValidacionesdelDía";
            lblValidacionesdelDía.Size = new Size(190, 28);
            lblValidacionesdelDía.TabIndex = 3;
            lblValidacionesdelDía.Text = "Validaciones del Día:";
            // 
            // lblCredencialesActivas
            // 
            lblCredencialesActivas.AutoSize = true;
            lblCredencialesActivas.Location = new Point(6, 76);
            lblCredencialesActivas.Name = "lblCredencialesActivas";
            lblCredencialesActivas.Size = new Size(192, 28);
            lblCredencialesActivas.TabIndex = 2;
            lblCredencialesActivas.Text = "Credenciales Activas:";
            // 
            // lblSolicitudesPendientes
            // 
            lblSolicitudesPendientes.AutoSize = true;
            lblSolicitudesPendientes.Location = new Point(6, 42);
            lblSolicitudesPendientes.Name = "lblSolicitudesPendientes";
            lblSolicitudesPendientes.Size = new Size(210, 28);
            lblSolicitudesPendientes.TabIndex = 1;
            lblSolicitudesPendientes.Text = "Solicitudes Pendientes:";
            // 
            // lblAccesosLocales
            // 
            lblAccesosLocales.AutoSize = true;
            lblAccesosLocales.Location = new Point(6, 144);
            lblAccesosLocales.Name = "lblAccesosLocales";
            lblAccesosLocales.Size = new Size(153, 28);
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
            groupBox2.Location = new Point(393, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 225);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Sesión";
            // 
            // AdmininLocal
            // 
            AdmininLocal.BackColor = Color.White;
            AdmininLocal.Controls.Add(btnValidaciones2);
            AdmininLocal.Controls.Add(btnProbarAccesoAdmin);
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
            AdmininLocal.Size = new Size(974, 793);
            AdmininLocal.TabIndex = 5;
            // 
            // btnProbarAccesoAdmin
            // 
            btnProbarAccesoAdmin.BackColor = Color.DarkOrange;
            btnProbarAccesoAdmin.FlatStyle = FlatStyle.Flat;
            btnProbarAccesoAdmin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProbarAccesoAdmin.Location = new Point(472, 570);
            btnProbarAccesoAdmin.Name = "btnProbarAccesoAdmin";
            btnProbarAccesoAdmin.Size = new Size(210, 55);
            btnProbarAccesoAdmin.TabIndex = 9;
            btnProbarAccesoAdmin.Text = "Probar Acceso Admin";
            btnProbarAccesoAdmin.UseVisualStyleBackColor = false;
            btnProbarAccesoAdmin.Click += btnProbarAcceso_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.Honeydew;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerarReporte.Location = new Point(42, 731);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(210, 55);
            btnGenerarReporte.TabIndex = 7;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.BackColor = Color.White;
            btnCerrarSesión.FlatAppearance.BorderSize = 0;
            btnCerrarSesión.FlatStyle = FlatStyle.Flat;
            btnCerrarSesión.Font = new Font("Segoe UI", 12F);
            btnCerrarSesión.Location = new Point(6, 792);
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(250, 60);
            btnCerrarSesión.TabIndex = 7;
            btnCerrarSesión.Text = "Cerrar Sesión";
            btnCerrarSesión.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesión.UseVisualStyleBackColor = false;
            btnCerrarSesión.Click += btnCerrarSesión_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.White;
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Segoe UI", 12F);
            btnSolicitudes.Location = new Point(6, 158);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(250, 60);
            btnSolicitudes.TabIndex = 6;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.UseVisualStyleBackColor = false;
            // 
            // btnCredenciales
            // 
            btnCredenciales.BackColor = Color.White;
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.Font = new Font("Segoe UI", 12F);
            btnCredenciales.Location = new Point(6, 235);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(250, 60);
            btnCredenciales.TabIndex = 5;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.TextAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.UseVisualStyleBackColor = false;
            // 
            // btnValidaciones
            // 
            btnValidaciones.BackColor = Color.White;
            btnValidaciones.FlatAppearance.BorderSize = 0;
            btnValidaciones.FlatStyle = FlatStyle.Flat;
            btnValidaciones.Font = new Font("Segoe UI", 12F);
            btnValidaciones.Location = new Point(6, 81);
            btnValidaciones.Name = "btnValidaciones";
            btnValidaciones.Size = new Size(250, 60);
            btnValidaciones.TabIndex = 2;
            btnValidaciones.Text = "Validaciones";
            btnValidaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnValidaciones.UseVisualStyleBackColor = false;
            btnValidaciones.Click += btnValidaciones_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Gainsboro;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F);
            btnInicio.Location = new Point(3, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(259, 60);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 51, 102);
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 46);
            label1.TabIndex = 0;
            label1.Text = "CredenSoft";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.MidnightBlue;
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(259, 0);
            panelSuperior.MaximumSize = new Size(0, 80);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(974, 65);
            panelSuperior.TabIndex = 3;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.WhiteSmoke;
            panelMenu.Controls.Add(btnConfiguración);
            panelMenu.Controls.Add(btnCerrarSesión);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Controls.Add(btnCredenciales);
            panelMenu.Controls.Add(btnValidaciones);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(259, 858);
            panelMenu.TabIndex = 4;
            // 
            // btnConfiguración
            // 
            btnConfiguración.BackColor = Color.White;
            btnConfiguración.FlatAppearance.BorderSize = 0;
            btnConfiguración.FlatStyle = FlatStyle.Flat;
            btnConfiguración.Font = new Font("Segoe UI", 12F);
            btnConfiguración.Location = new Point(3, 312);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(253, 60);
            btnConfiguración.TabIndex = 8;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguración.UseVisualStyleBackColor = false;
            // 
            // btnValidaciones2
            // 
            btnValidaciones2.BackColor = Color.DarkOrange;
            btnValidaciones2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnValidaciones2.Location = new Point(472, 650);
            btnValidaciones2.Name = "btnValidaciones2";
            btnValidaciones2.Size = new Size(210, 55);
            btnValidaciones2.TabIndex = 10;
            btnValidaciones2.Text = "Validaciones";
            btnValidaciones2.UseVisualStyleBackColor = false;
            btnValidaciones2.Click += btnValidaciones2_Click;
            // 
            // FrmDashboardLocal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 858);
            Controls.Add(AdmininLocal);
            Controls.Add(panelSuperior);
            Controls.Add(panelMenu);
            Name = "FrmDashboardLocal";
            Text = "FrmDashboardLocal";
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            AdmininLocal.ResumeLayout(false);
            AdmininLocal.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelMenu.ResumeLayout(false);
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
        private Button btnCerrarSesión;
        private Button btnSolicitudes;
        private Button btnCredenciales;
        private Button btnValidaciones;
        private Button btnInicio;
        private Label label1;
        private Panel panelSuperior;
        private Panel panelMenu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colAgente;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
        private Button btnProbarAccesoAdmin;
        private Button btnConfiguración;
        private Button btnValidaciones2;
    }
}