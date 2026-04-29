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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblInfoUsuario = new Label();
            panelMenu = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUsuarios = new Button();
            btnCredenciales = new Button();
            btnSolicitudes = new Button();
            btnAuditoria = new Button();
            btnCerrarSesion = new Button();
            panelContent = new Panel();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(20, 40, 70);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblInfoUsuario);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1167, 69);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-85, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 35, 50);
            panelMenu.Controls.Add(flowLayoutPanel1);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 69);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(207, 623);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSolicitudes);
            flowLayoutPanel1.Controls.Add(btnCredenciales);
            flowLayoutPanel1.Controls.Add(btnUsuarios);
            flowLayoutPanel1.Controls.Add(btnAuditoria);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(207, 565);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Anchor = AnchorStyles.Top;
            btnUsuarios.BackColor = Color.FromArgb(44, 62, 80);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 13F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(4, 105);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(200, 45);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCredenciales
            // 
            btnCredenciales.Anchor = AnchorStyles.Top;
            btnCredenciales.BackColor = Color.FromArgb(44, 62, 80);
            btnCredenciales.Cursor = Cursors.Hand;
            btnCredenciales.FlatAppearance.BorderSize = 0;
            btnCredenciales.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnCredenciales.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnCredenciales.FlatStyle = FlatStyle.Flat;
            btnCredenciales.Font = new Font("Segoe UI", 13F);
            btnCredenciales.ForeColor = Color.White;
            btnCredenciales.ImageAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.Location = new Point(4, 54);
            btnCredenciales.Margin = new Padding(4, 3, 4, 3);
            btnCredenciales.Name = "btnCredenciales";
            btnCredenciales.Size = new Size(200, 45);
            btnCredenciales.TabIndex = 5;
            btnCredenciales.Text = "Credenciales";
            btnCredenciales.TextAlign = ContentAlignment.MiddleLeft;
            btnCredenciales.UseVisualStyleBackColor = false;
            btnCredenciales.Click += btnCredenciales_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.Anchor = AnchorStyles.Top;
            btnSolicitudes.BackColor = Color.FromArgb(44, 62, 80);
            btnSolicitudes.Cursor = Cursors.Hand;
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnSolicitudes.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Segoe UI", 13F);
            btnSolicitudes.ForeColor = Color.White;
            btnSolicitudes.Location = new Point(4, 3);
            btnSolicitudes.Margin = new Padding(4, 3, 4, 3);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Size = new Size(200, 45);
            btnSolicitudes.TabIndex = 4;
            btnSolicitudes.Text = "Solicitudes";
            btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.UseVisualStyleBackColor = false;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Anchor = AnchorStyles.Top;
            btnAuditoria.BackColor = Color.FromArgb(44, 62, 80);
            btnAuditoria.Cursor = Cursors.Hand;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnAuditoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180);
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI", 13F);
            btnAuditoria.ForeColor = Color.White;
            btnAuditoria.Location = new Point(4, 156);
            btnAuditoria.Margin = new Padding(4, 3, 4, 3);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(200, 45);
            btnAuditoria.TabIndex = 7;
            btnAuditoria.Text = "Auditoría";
            btnAuditoria.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.UseVisualStyleBackColor = false;
            btnAuditoria.Click += btnAuditoria_Click;
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
            btnCerrarSesion.Location = new Point(0, 565);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(207, 58);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(207, 69);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(960, 623);
            panelContent.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(30, 40, 55);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(207, 670);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(960, 22);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAuditoria;
        private Button btnUsuarios;
        private Button btnCredenciales;
        private Button btnSolicitudes;
        private PictureBox pictureBox1;
    }
}