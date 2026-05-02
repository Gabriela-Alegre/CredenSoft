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
            txtEmail.Location = new Point(174, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += LimpiarError_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(174, 118);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(290, 23);
            txtDni.TabIndex = 1;
            txtDni.TextChanged += LimpiarError_TextChanged;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(174, 170);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.PasswordChar = '*';
            txtNuevaContrasenia.Size = new Size(290, 23);
            txtNuevaContrasenia.TabIndex = 4;
            txtNuevaContrasenia.TextChanged += LimpiarError_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Location = new Point(106, 300);
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
            btnCancelar.Location = new Point(347, 297);
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
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(8, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(134, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Correo Electrónico";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(8, 118);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(106, 19);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI del Oficial";
            // 
            // lblNuevaContrasenia
            // 
            lblNuevaContrasenia.AutoSize = true;
            lblNuevaContrasenia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNuevaContrasenia.Location = new Point(8, 174);
            lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            lblNuevaContrasenia.Size = new Size(131, 19);
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
            lblMensajeExito.Location = new Point(174, 100);
            lblMensajeExito.Name = "lblMensajeExito";
            lblMensajeExito.Size = new Size(269, 15);
            lblMensajeExito.TabIndex = 8;
            lblMensajeExito.Text = "✔ Se envio un enlace de recuperación a su correo";
            lblMensajeExito.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(8, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 21);
            label1.TabIndex = 0;
            label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(8, 223);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 9;
            label2.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.Location = new Point(174, 219);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.Size = new Size(290, 23);
            txtConfirmarContrasenia.TabIndex = 4;
            // 
            // picVerContrasenia
            // 
            picVerContrasenia.BackColor = Color.White;
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerContrasenia.Location = new Point(417, 223);
            picVerContrasenia.Name = "picVerContrasenia";
            picVerContrasenia.Size = new Size(37, 14);
            picVerContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerContrasenia.TabIndex = 11;
            picVerContrasenia.TabStop = false;
            picVerContrasenia.Click += picVerContrasenia_Click;
            // 
            // picVerConfirmarContrasenia
            // 
            picVerConfirmarContrasenia.BackColor = Color.White;
            picVerConfirmarContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerConfirmarContrasenia.Location = new Point(417, 174);
            picVerConfirmarContrasenia.Name = "picVerConfirmarContrasenia";
            picVerConfirmarContrasenia.Size = new Size(37, 14);
            picVerConfirmarContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerConfirmarContrasenia.TabIndex = 12;
            picVerConfirmarContrasenia.TabStop = false;
            picVerConfirmarContrasenia.Click += picVerConfirmarContrasenia_Click;
            // 
            // FrmRecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 389);
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