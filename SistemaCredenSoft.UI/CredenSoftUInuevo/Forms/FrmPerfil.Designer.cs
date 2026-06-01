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
            grpDatosNoEditables.SuspendLayout();
            grpDatosPersonales.SuspendLayout();
            grpSeguridad.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(372, 31);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(16, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(244, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(372, 31);
            txtApellido.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 31);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(16, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(16, 75);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(91, 28);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
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
            grpDatosNoEditables.Location = new Point(12, 277);
            grpDatosNoEditables.Name = "grpDatosNoEditables";
            grpDatosNoEditables.Size = new Size(857, 234);
            grpDatosNoEditables.TabIndex = 6;
            grpDatosNoEditables.TabStop = false;
            grpDatosNoEditables.Text = "Datos No Editables";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(244, 45);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(372, 31);
            txtUsuario.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(244, 95);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(372, 31);
            txtDni.TabIndex = 7;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(16, 126);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(43, 28);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(244, 145);
            txtRol.Name = "txtRol";
            txtRol.ReadOnly = true;
            txtRol.Size = new Size(372, 31);
            txtRol.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(16, 48);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 28);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(16, 87);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(49, 28);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI";
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
            grpDatosPersonales.Location = new Point(12, 21);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(857, 234);
            grpDatosPersonales.TabIndex = 7;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            // 
            // grpSeguridad
            // 
            grpSeguridad.BackColor = Color.White;
            grpSeguridad.Controls.Add(txtNuevaContrasenia);
            grpSeguridad.Controls.Add(lblNuevaContrasenia);
            grpSeguridad.Location = new Point(12, 538);
            grpSeguridad.Name = "grpSeguridad";
            grpSeguridad.Size = new Size(857, 158);
            grpSeguridad.TabIndex = 9;
            grpSeguridad.TabStop = false;
            grpSeguridad.Text = "Seguridad";
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(244, 45);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(372, 31);
            txtNuevaContrasenia.TabIndex = 6;
            // 
            // lblNuevaContrasenia
            // 
            lblNuevaContrasenia.AutoSize = true;
            lblNuevaContrasenia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNuevaContrasenia.Location = new Point(16, 48);
            lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            lblNuevaContrasenia.Size = new Size(185, 28);
            lblNuevaContrasenia.TabIndex = 7;
            lblNuevaContrasenia.Text = "Nueva Contraseña";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(72, 737);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(234, 66);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContrasenia.Location = new Point(417, 737);
            btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            btnCambiarContrasenia.Size = new Size(234, 66);
            btnCambiarContrasenia.TabIndex = 11;
            btnCambiarContrasenia.Text = "Cambiar Contraseña";
            btnCambiarContrasenia.UseVisualStyleBackColor = false;
            btnCambiarContrasenia.Click += btnCambiarContrasenia_Click;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1295, 815);
            Controls.Add(btnCambiarContrasenia);
            Controls.Add(btnGuardar);
            Controls.Add(grpSeguridad);
            Controls.Add(grpDatosPersonales);
            Controls.Add(grpDatosNoEditables);
            Name = "FrmPerfil";
            Text = "FrmPerfil";
            Load += FrmPerfil_Load;
            grpDatosNoEditables.ResumeLayout(false);
            grpDatosNoEditables.PerformLayout();
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpSeguridad.ResumeLayout(false);
            grpSeguridad.PerformLayout();
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
    }
}