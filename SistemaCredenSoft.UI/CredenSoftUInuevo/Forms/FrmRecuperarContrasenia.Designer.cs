namespace CredenSoftUInuevo.Forms
{
    partial class FrmRecuperarContrasenia
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtNuevaContrasenia = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblEmail = new Label();
            lblDni = new Label();
            lblNuevaContrasenia = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblMensajeExito = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += LimpiarError_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(174, 100);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(269, 23);
            txtDni.TabIndex = 1;
            txtDni.TextChanged += LimpiarError_TextChanged;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(174, 150);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(269, 23);
            txtNuevaContrasenia.TabIndex = 2;
            txtNuevaContrasenia.TextChanged += LimpiarError_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Location = new Point(200, 210);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(95, 35);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(305, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Correo Electrónico";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(50, 103);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(83, 15);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI del Oficial";
            // 
            // lblNuevaContrasenia
            // 
            lblNuevaContrasenia.AutoSize = true;
            lblNuevaContrasenia.Location = new Point(50, 153);
            lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            lblNuevaContrasenia.Size = new Size(104, 15);
            lblNuevaContrasenia.TabIndex = 5;
            lblNuevaContrasenia.Text = "Nueva Contraseña";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblMensajeExito
            // 
            lblMensajeExito.AutoSize = true;
            lblMensajeExito.BackColor = Color.LightGreen;
            lblMensajeExito.ForeColor = Color.DarkGreen;
            lblMensajeExito.Location = new Point(174, 76);
            lblMensajeExito.Name = "lblMensajeExito";
            lblMensajeExito.Size = new Size(269, 15);
            lblMensajeExito.TabIndex = 8;
            lblMensajeExito.Text = "✔ Se envio un enlace de recuperación a su correo";
            lblMensajeExito.Visible = false;
            // 
            // FrmRecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 280);
            Controls.Add(lblMensajeExito);
            Controls.Add(btnCancelar);
            Controls.Add(lblNuevaContrasenia);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(btnConfirmar);
            Controls.Add(txtNuevaContrasenia);
            Controls.Add(txtDni);
            Controls.Add(txtEmail);
            Name = "FrmRecuperarContrasenia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recuperar Contraseña - CredenSoft";
            Load += FrmRecuperarContrasenia_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNuevaContrasenia;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNuevaContrasenia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label lblMensajeExito;
    }
}