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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 123);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(412, 31);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += LimpiarError_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(249, 255);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(412, 31);
            txtDni.TabIndex = 1;
            txtDni.TextChanged += LimpiarError_TextChanged;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(249, 343);
            txtNuevaContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(412, 31);
            txtNuevaContrasenia.TabIndex = 2;
            txtNuevaContrasenia.TextChanged += LimpiarError_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Location = new Point(151, 495);
            btnConfirmar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(136, 58);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(496, 495);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 58);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(12, 123);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(187, 28);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Correo Electrónico";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(12, 255);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(152, 28);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI del Oficial";
            // 
            // lblNuevaContrasenia
            // 
            lblNuevaContrasenia.AutoSize = true;
            lblNuevaContrasenia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNuevaContrasenia.Location = new Point(12, 343);
            lblNuevaContrasenia.Margin = new Padding(4, 0, 4, 0);
            lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            lblNuevaContrasenia.Size = new Size(185, 28);
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
            lblMensajeExito.BackColor = Color.DarkSeaGreen;
            lblMensajeExito.ForeColor = Color.DarkGreen;
            lblMensajeExito.Location = new Point(249, 167);
            lblMensajeExito.Margin = new Padding(4, 0, 4, 0);
            lblMensajeExito.Name = "lblMensajeExito";
            lblMensajeExito.Size = new Size(412, 25);
            lblMensajeExito.TabIndex = 8;
            lblMensajeExito.Text = "✔ Se envio un enlace de recuperación a su correo";
            lblMensajeExito.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(320, 32);
            label1.TabIndex = 0;
            label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // FrmRecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 587);
            Controls.Add(label1);
            Controls.Add(lblMensajeExito);
            Controls.Add(btnCancelar);
            Controls.Add(lblNuevaContrasenia);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(btnConfirmar);
            Controls.Add(txtNuevaContrasenia);
            Controls.Add(txtDni);
            Controls.Add(txtEmail);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label1;
    }
}