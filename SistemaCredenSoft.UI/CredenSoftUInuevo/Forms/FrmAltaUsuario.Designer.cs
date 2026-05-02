namespace CredenSoftUInuevo.Forms
{
    partial class FrmAltaUsuario
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContrasenia = new Label();
            txtContrasenia = new TextBox();
            cmbRol = new ComboBox();
            lblRol = new Label();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtConfirmarContrasenia = new TextBox();
            lblConfirmar = new Label();
            label2 = new Label();
            picVerContrasenia = new PictureBox();
            picVerConfirmarContrasenia = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerConfirmarContrasenia).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(10, 56);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 56);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(10, 89);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 19);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(144, 89);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(10, 125);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 19);
            lblDni.TabIndex = 11;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(144, 123);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(233, 23);
            txtDni.TabIndex = 2;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(10, 158);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 157);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContrasenia.Location = new Point(10, 192);
            lblContrasenia.Margin = new Padding(4, 0, 4, 0);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(88, 19);
            lblContrasenia.TabIndex = 9;
            lblContrasenia.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(144, 190);
            txtContrasenia.Margin = new Padding(4, 3, 4, 3);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(233, 23);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador Central", "Administrador Local", "Agente" });
            cmbRol.Location = new Point(144, 257);
            cmbRol.Margin = new Padding(4, 3, 4, 3);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(233, 23);
            cmbRol.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(10, 260);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 19);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.Location = new Point(10, 295);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 19);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(144, 292);
            cmbEstado.Margin = new Padding(4, 3, 4, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(233, 23);
            cmbEstado.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(60, 349);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(288, 349);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.Location = new Point(144, 224);
            txtConfirmarContrasenia.Margin = new Padding(2, 2, 2, 2);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.PasswordChar = '*';
            txtConfirmarContrasenia.Size = new Size(233, 23);
            txtConfirmarContrasenia.TabIndex = 14;
            txtConfirmarContrasenia.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmar.Location = new Point(10, 226);
            lblConfirmar.Margin = new Padding(2, 0, 2, 0);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(82, 19);
            lblConfirmar.TabIndex = 15;
            lblConfirmar.Text = "Confirmar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(28, 78, 128);
            label2.Location = new Point(8, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 21);
            label2.TabIndex = 16;
            label2.Text = "REGISTRAR NUEVO USUARIO";
            // 
            // picVerContrasenia
            // 
            picVerContrasenia.BackColor = Color.White;
            picVerContrasenia.Cursor = Cursors.Hand;
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerContrasenia.Location = new Point(350, 192);
            picVerContrasenia.Margin = new Padding(2, 2, 2, 2);
            picVerContrasenia.Name = "picVerContrasenia";
            picVerContrasenia.Size = new Size(15, 15);
            picVerContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerContrasenia.TabIndex = 17;
            picVerContrasenia.TabStop = false;
            picVerContrasenia.Click += picVerContrasenia_Click;
            // 
            // picVerConfirmarContrasenia
            // 
            picVerConfirmarContrasenia.BackColor = Color.Transparent;
            picVerConfirmarContrasenia.Cursor = Cursors.Hand;
            picVerConfirmarContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerConfirmarContrasenia.Location = new Point(350, 226);
            picVerConfirmarContrasenia.Margin = new Padding(2, 2, 2, 2);
            picVerConfirmarContrasenia.Name = "picVerConfirmarContrasenia";
            picVerConfirmarContrasenia.Size = new Size(15, 15);
            picVerConfirmarContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerConfirmarContrasenia.TabIndex = 18;
            picVerConfirmarContrasenia.TabStop = false;
            picVerConfirmarContrasenia.Click += picVerConfirmarContrasenia_Click;
            // 
            // FrmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 392);
            Controls.Add(picVerConfirmarContrasenia);
            Controls.Add(picVerContrasenia);
            Controls.Add(label2);
            Controls.Add(lblConfirmar);
            Controls.Add(txtConfirmarContrasenia);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(cmbRol);
            Controls.Add(txtContrasenia);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEstado);
            Controls.Add(lblRol);
            Controls.Add(lblContrasenia);
            Controls.Add(lblEmail);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAltaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta de Usuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerConfirmarContrasenia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private ErrorProvider errorProvider1;
        private TextBox txtConfirmarContrasenia;
        private Label label2;
        private Label lblConfirmar;
        private PictureBox picVerContrasenia;
        private PictureBox picVerConfirmarContrasenia;
    }
}