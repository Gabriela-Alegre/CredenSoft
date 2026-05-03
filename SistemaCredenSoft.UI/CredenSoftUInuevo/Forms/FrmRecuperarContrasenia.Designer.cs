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
            label2 = new Label();
            txtConfirmarContrasenia = new TextBox();
            picVerContrasenia = new PictureBox();
            picVerConfirmarContrasenia = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerConfirmarContrasenia).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 123);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(413, 31);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += LimpiarError_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(249, 197);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(413, 31);
            txtDni.TabIndex = 1;
            txtDni.TextChanged += LimpiarError_TextChanged;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(249, 283);
            txtNuevaContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(413, 31);
            txtNuevaContrasenia.TabIndex = 4;
            txtNuevaContrasenia.TextChanged += LimpiarError_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Location = new Point(151, 500);
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
            lblEmail.Location = new Point(11, 123);
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
            lblDni.Location = new Point(11, 197);
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
            lblNuevaContrasenia.Location = new Point(11, 290);
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
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(320, 32);
            label1.TabIndex = 0;
            label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(11, 372);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(224, 28);
            label2.TabIndex = 9;
            label2.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.Location = new Point(249, 365);
            txtConfirmarContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.Size = new Size(413, 31);
            txtConfirmarContrasenia.TabIndex = 4;
            // 
            // picVerContrasenia
            // 
            picVerContrasenia.BackColor = Color.White;
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerContrasenia.Location = new Point(599, 290);
            picVerContrasenia.Margin = new Padding(4, 5, 4, 5);
            picVerContrasenia.Name = "picVerContrasenia";
            picVerContrasenia.Size = new Size(43, 21);
            picVerContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerContrasenia.TabIndex = 11;
            picVerContrasenia.TabStop = false;
            picVerContrasenia.Click += picVerContrasenia_Click;
            // 
            // picVerConfirmarContrasenia
            // 
            picVerConfirmarContrasenia.BackColor = Color.White;
            picVerConfirmarContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerConfirmarContrasenia.Location = new Point(589, 372);
            picVerConfirmarContrasenia.Margin = new Padding(4, 5, 4, 5);
            picVerConfirmarContrasenia.Name = "picVerConfirmarContrasenia";
            picVerConfirmarContrasenia.Size = new Size(53, 22);
            picVerConfirmarContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerConfirmarContrasenia.TabIndex = 12;
            picVerConfirmarContrasenia.TabStop = false;
            picVerConfirmarContrasenia.Click += picVerConfirmarContrasenia_Click;
            // 
            // FrmRecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 648);
            Controls.Add(picVerConfirmarContrasenia);
            Controls.Add(picVerContrasenia);
            Controls.Add(txtConfirmarContrasenia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMensajeExito);
            Controls.Add(btnCancelar);
            Controls.Add(lblNuevaContrasenia);
            Controls.Add(lblDni);
            Controls.Add(lblEmail);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDni);
            Controls.Add(txtEmail);
            Controls.Add(txtNuevaContrasenia);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmRecuperarContrasenia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recuperar Contraseña - CredenSoft";
            Load += FrmRecuperarContrasenia_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerConfirmarContrasenia).EndInit();
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
        private Label label2;
        private TextBox txtConfirmarContrasenia;
        private PictureBox picVerContrasenia;
        private PictureBox picVerConfirmarContrasenia;
    }
}