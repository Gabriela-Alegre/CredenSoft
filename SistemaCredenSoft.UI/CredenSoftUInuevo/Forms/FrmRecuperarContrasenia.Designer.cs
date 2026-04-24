namespace CredenSoftUInuevo.Forms
{
    partial class FrmRecuperarContrasenia
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
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtNuevaContrasenia = new TextBox();
            btnConfirmar = new Button();
            lblEmail = new Label();
            lblDni = new Label();
            lblNuevaContrasenia = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(234, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(234, 99);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(200, 23);
            txtDni.TabIndex = 1;
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(234, 154);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(200, 23);
            txtNuevaContrasenia.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(234, 210);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 30);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // LA LÍNEA MÁGICA ESTÁ AQUÍ ABAJO:
            btnConfirmar.Click += new EventHandler(btnConfirmar_Click);
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(92, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Correo Electronico";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(128, 99);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(83, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI del Oficial";
            // 
            // lblNuevaContrasenia
            // 
            lblNuevaContrasenia.AutoSize = true;
            lblNuevaContrasenia.Location = new Point(84, 155);
            lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            lblNuevaContrasenia.Size = new Size(107, 15);
            lblNuevaContrasenia.TabIndex = 6;
            lblNuevaContrasenia.Text = "Nueva Contrasenia";
            // 
            // FrmRecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(lblNuevaContrasenia);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(btnConfirmar);
            Controls.Add(txtNuevaContrasenia);
            Controls.Add(txtDni);
            Controls.Add(txtEmail);
            Name = "FrmRecuperarContrasenia";
            Text = "Recuperar Contraseña - CredenSoft";
            Load += FrmRecuperarContrasenia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtDni;
        private TextBox txtNuevaContrasenia;
        private Button btnConfirmar;
        private Label lblEmail;
        private Label lblDni;
        private Label lblNuevaContrasenia;
    }
}