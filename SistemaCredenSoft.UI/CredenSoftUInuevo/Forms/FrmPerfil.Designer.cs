namespace CredenSoftUInuevo.Forms
{
    partial class FrmPerfil
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblApellido = new Label();
            grpDatosNoEditables = new GroupBox();
            txtUsuario = new TextBox();
            txtDni = new TextBox();
            lblRol = new Label();
            txtRol = new TextBox();
            lblUsuario = new Label();
            lblDni = new Label();
            grpDatosPersonales = new GroupBox();
            grpSeguridad = new GroupBox();
            txtNuevaContrasenia = new TextBox();
            lblNuevaContrasenia = new Label();
            btnGuardar = new Button();
            btnCambiarContrasenia = new Button();
            panel1 = new Panel();
            grpDatosNoEditables.SuspendLayout();
            grpDatosPersonales.SuspendLayout();
            grpSeguridad.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 18);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(11, 18);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre *";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(171, 48);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(262, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 78);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(11, 72);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email *";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(11, 45);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 19);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido *";
            // 
            // grpDatosNoEditables
            // 
            grpDatosNoEditables.BackColor = Color.White;
            grpDatosNoEditables.Controls.Add(txtUsuario);
            grpDatosNoEditables.Controls.Add(txtDni);
            grpDatosNoEditables.Controls.Add(lblRol);
            grpDatosNoEditables.Controls.Add(txtRol);
            grpDatosNoEditables.Controls.Add(lblUsuario);
            grpDatosNoEditables.Controls.Add(lblDni);
            grpDatosNoEditables.Location = new Point(8, 166);
            grpDatosNoEditables.Margin = new Padding(2, 2, 2, 2);
            grpDatosNoEditables.Name = "grpDatosNoEditables";
            grpDatosNoEditables.Padding = new Padding(2, 2, 2, 2);
            grpDatosNoEditables.Size = new Size(600, 140);
            grpDatosNoEditables.TabIndex = 6;
            grpDatosNoEditables.TabStop = false;
            grpDatosNoEditables.Text = "Datos No Editables";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(171, 27);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(262, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(171, 57);
            txtDni.Margin = new Padding(2, 2, 2, 2);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(262, 23);
            txtDni.TabIndex = 7;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(11, 76);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(41, 19);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol *";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(171, 87);
            txtRol.Margin = new Padding(2, 2, 2, 2);
            txtRol.Name = "txtRol";
            txtRol.ReadOnly = true;
            txtRol.Size = new Size(262, 23);
            txtRol.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(11, 29);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 19);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(11, 52);
            lblDni.Margin = new Padding(2, 0, 2, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(44, 19);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI *";
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.BackColor = Color.White;
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Controls.Add(lblApellido);
            grpDatosPersonales.Controls.Add(txtApellido);
            grpDatosPersonales.Controls.Add(lblEmail);
            grpDatosPersonales.Controls.Add(txtEmail);
            grpDatosPersonales.Location = new Point(8, 13);
            grpDatosPersonales.Margin = new Padding(2, 2, 2, 2);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Padding = new Padding(2, 2, 2, 2);
            grpDatosPersonales.Size = new Size(600, 140);
            grpDatosPersonales.TabIndex = 7;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            // 
            // grpSeguridad
            // 
            grpSeguridad.BackColor = Color.White;
            grpSeguridad.Controls.Add(txtNuevaContrasenia);
            grpSeguridad.Controls.Add(lblNuevaContrasenia);
            grpSeguridad.Location = new Point(8, 323);
            grpSeguridad.Margin = new Padding(2, 2, 2, 2);
            grpSeguridad.Name = "grpSeguridad";
            grpSeguridad.Padding = new Padding(2, 2, 2, 2);
            grpSeguridad.Size = new Size(600, 95);
            grpSeguridad.TabIndex = 9;
            grpSeguridad.TabStop = false;
            grpSeguridad.Text = "Seguridad";
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(171, 27);
            txtNuevaContrasenia.Margin = new Padding(2, 2, 2, 2);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(262, 23);
            txtNuevaContrasenia.TabIndex = 6;
            // 
            // lblNuevaContrasenia
            // 
            lblNuevaContrasenia.AutoSize = true;
            lblNuevaContrasenia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNuevaContrasenia.Location = new Point(11, 29);
            lblNuevaContrasenia.Margin = new Padding(2, 0, 2, 0);
            lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            lblNuevaContrasenia.Size = new Size(141, 19);
            lblNuevaContrasenia.TabIndex = 7;
            lblNuevaContrasenia.Text = "Nueva Contraseña *";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(2, 2);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 46);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCambiarContrasenia
            // 
            btnCambiarContrasenia.Anchor = AnchorStyles.Bottom;
            btnCambiarContrasenia.BackColor = SystemColors.ActiveCaption;
            btnCambiarContrasenia.Location = new Point(284, 2);
            btnCambiarContrasenia.Margin = new Padding(2, 2, 2, 2);
            btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            btnCambiarContrasenia.Size = new Size(188, 46);
            btnCambiarContrasenia.TabIndex = 11;
            btnCambiarContrasenia.Text = "Cambiar Contraseña";
            btnCambiarContrasenia.UseVisualStyleBackColor = false;
            btnCambiarContrasenia.Click += btnCambiarContrasenia_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCambiarContrasenia);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 411);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 86);
            panel1.TabIndex = 12;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(663, 497);
            Controls.Add(panel1);
            Controls.Add(grpSeguridad);
            Controls.Add(grpDatosPersonales);
            Controls.Add(grpDatosNoEditables);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPerfil";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mi Perfil";
            Load += FrmPerfil_Load;
            grpDatosNoEditables.ResumeLayout(false);
            grpDatosNoEditables.PerformLayout();
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpSeguridad.ResumeLayout(false);
            grpSeguridad.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblApellido;
        private GroupBox grpDatosNoEditables;
        private GroupBox grpDatosPersonales;
        private TextBox txtUsuario;
        private TextBox txtDni;
        private Label lblRol;
        private TextBox txtRol;
        private Label lblUsuario;
        private Label lblDni;
        private GroupBox grpSeguridad;
        private TextBox txtNuevaContrasenia;
        private Label lblNuevaContrasenia;
        private Button btnGuardar;
        private Button btnCambiarContrasenia;
        private Panel panel1;
    }
}