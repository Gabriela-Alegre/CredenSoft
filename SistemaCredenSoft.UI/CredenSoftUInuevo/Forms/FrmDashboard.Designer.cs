namespace CredenSoftUInuevo.Forms
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblInfoUsuario = new Label();
            lblTitulo = new Label();
            panelMenu = new Panel();
            btnCerrarSesion = new Button();
            btnAuditoria = new Button();
            btnUsuarios = new Button();
            btnCredenciales = new Button();
            btnSolicitudes = new Button();
            panelContent = new Panel();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(20, 40, 70);
            panelHeader.Controls.Add(lblInfoUsuario);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1167, 69);
            panelHeader.TabIndex = 0;
            // 
            // lblInfoUsuario
            // 
            lblInfoUsuario.Dock = DockStyle.Right;
            lblInfoUsuario.Font = new Font("Segoe UI", 10F);
            lblInfoUsuario.ForeColor = Color.FromArgb(224, 224, 224);
            lblInfoUsuario.Location = new Point(817, 0);
            lblInfoUsuario.Margin = new Padding(4, 0, 4, 0);
            lblInfoUsuario.Name = "lblInfoUsuario";
            lblInfoUsuario.Padding = new Padding(0, 0, 23, 0);
            lblInfoUsuario.Size = new Size(350, 69);
            lblInfoUsuario.TabIndex = 1;
            lblInfoUsuario.Text = "Oficial: Cargando...";
            lblInfoUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(23, 0, 0, 0);
            lblTitulo.Size = new Size(583, 69);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CredenSoft - PSA";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 35, 50);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnAuditoria);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnCredenciales);
            panelMenu.Controls.Add(btnSolicitudes);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 69);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(233, 623);
            panelMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 565);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(233, 58);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Cursor = Cursors.Hand;
            btnAuditoria.Dock = DockStyle.Top;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.ForeColor = Color.White;
            btnAuditoria.Location = new Point(0, 174);
            btnAuditoria.Margin = new Padding(4, 3, 4, 3);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(233, 58);
            btnAuditoria.TabIndex = 3;
            btnAuditoria.Text = "Auditoría";
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 116);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(233, 58);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCredenciales
            // 
            btnCredenciales.Cursor = Cursors.Hand;
            btnCredenciales.Dock = DockStyle.Top;
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.ForeColor = Color.White;
            btnCredenciales.Location = new Point(0, 58);
            btnCredenciales.Margin = new Padding(4, 3, 4, 3);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(233, 58);
            btnCredenciales.TabIndex = 1;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.Click += btnCredenciales_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.Cursor = Cursors.Hand;
            btnSolicitudes.Dock = DockStyle.Top;
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.ForeColor = Color.White;
            btnSolicitudes.Location = new Point(0, 0);
            btnSolicitudes.Margin = new Padding(4, 3, 4, 3);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(233, 58);
            btnSolicitudes.TabIndex = 0;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(233, 69);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(934, 623);
            panelContent.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(30, 40, 55);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(233, 670);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(934, 22);
            statusStrip.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(197, 17);
            lblStatus.Text = "● Sistema Online - Conexión Segura";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 692);
            Controls.Add(statusStrip);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CredenSoft v1.0 - Gestión de Credenciales";
            Load += FrmDashboard_Load;
            Shown += FrmDashboard_Shown;
            panelHeader.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCredenciales;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}