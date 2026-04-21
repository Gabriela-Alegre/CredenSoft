namespace CredenSoftUInuevo.Forms
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCredenciales = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(950, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CredenSoft - Sistema de Credenciales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnAuditoria);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnCredenciales);
            this.panelMenu.Controls.Add(this.btnSolicitudes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 390);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 340);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 50);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditoria.FlatAppearance.BorderSize = 0;
            this.btnAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoria.ForeColor = System.Drawing.Color.White;
            this.btnAuditoria.Location = new System.Drawing.Point(0, 150);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(200, 50);
            this.btnAuditoria.TabIndex = 3;
            this.btnAuditoria.Text = "Auditoría";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 100);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 50);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCredenciales
            // 
            this.btnCredenciales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCredenciales.FlatAppearance.BorderSize = 0;
            this.btnCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredenciales.ForeColor = System.Drawing.Color.White;
            this.btnCredenciales.Location = new System.Drawing.Point(0, 50);
            this.btnCredenciales.Name = "btnCredenciales";
            this.btnCredenciales.Size = new System.Drawing.Size(200, 50);
            this.btnCredenciales.TabIndex = 1;
            this.btnCredenciales.Text = "Credenciales";
            this.btnCredenciales.UseVisualStyleBackColor = true;
            this.btnCredenciales.Click += new System.EventHandler(this.btnCredenciales_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(200, 50);
            this.btnSolicitudes.TabIndex = 0;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(750, 390);
            this.panelContent.TabIndex = 2;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Credenciales Aeroportuarias";
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCredenciales;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}