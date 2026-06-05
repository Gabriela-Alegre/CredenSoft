namespace CredenSoftUInuevo.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasenia = new Label();
            txtContrasenia = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            lnkRecuperar = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            picVerContrasenia = new PictureBox();
            lblErrorInactivo = new Label();
            pictureBox3 = new PictureBox();
            chkRecordarme = new CheckBox();
            btnRegistrar = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Italic);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(122, 319);
            lblUsuario.Margin = new Padding(6, 0, 6, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(291, 37);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Correo Electrónico ";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top;
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 13F);
            txtUsuario.Location = new Point(537, 319);
            txtUsuario.Margin = new Padding(6, 5, 6, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(614, 42);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasenia
            // 
            lblContrasenia.Anchor = AnchorStyles.Top;
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.Transparent;
            lblContrasenia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Italic);
            lblContrasenia.ForeColor = SystemColors.ActiveCaptionText;
            lblContrasenia.Location = new Point(122, 404);
            lblContrasenia.Margin = new Padding(6, 0, 6, 0);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(192, 37);
            lblContrasenia.TabIndex = 3;
            lblContrasenia.Text = "Contraseña ";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.Top;
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 13F);
            txtContrasenia.Location = new Point(537, 402);
            txtContrasenia.Margin = new Padding(6, 5, 6, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(614, 42);
            txtContrasenia.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top;
            btnIngresar.BackColor = Color.FromArgb(28, 78, 128);
            btnIngresar.BackgroundImageLayout = ImageLayout.None;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(282, 722);
            btnIngresar.Margin = new Padding(6, 5, 6, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(315, 100);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "▷ INICIAR SESIÓN";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.BackColor = SystemColors.ButtonHighlight;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.White;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(1024, 943);
            btnSalir.Margin = new Padding(6, 5, 6, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(201, 106);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lnkRecuperar
            // 
            lnkRecuperar.Anchor = AnchorStyles.Top;
            lnkRecuperar.AutoSize = true;
            lnkRecuperar.Font = new Font("Segoe UI", 16F);
            lnkRecuperar.Location = new Point(282, 847);
            lnkRecuperar.Margin = new Padding(4, 0, 4, 0);
            lnkRecuperar.Name = "lnkRecuperar";
            lnkRecuperar.Size = new Size(346, 45);
            lnkRecuperar.TabIndex = 7;
            lnkRecuperar.TabStop = true;
            lnkRecuperar.Text = "¿Olvido su contraseña?";
            lnkRecuperar.LinkClicked += lnkRecuperar_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.b6e50688_f5a5_4dfc_8398_dbfd6d6f8a81;
            pictureBox1.InitialImage = Properties.Resources.b6e50688_f5a5_4dfc_8398_dbfd6d6f8a81;
            pictureBox1.Location = new Point(456, 404);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(449, 319);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // picVerContrasenia
            // 
            picVerContrasenia.Anchor = AnchorStyles.Top;
            picVerContrasenia.BackColor = Color.Transparent;
            picVerContrasenia.Cursor = Cursors.Hand;
            picVerContrasenia.Image = (Image)resources.GetObject("picVerContrasenia.Image");
            picVerContrasenia.Location = new Point(1078, 404);
            picVerContrasenia.Margin = new Padding(4, 5, 4, 5);
            picVerContrasenia.Name = "picVerContrasenia";
            picVerContrasenia.Size = new Size(43, 37);
            picVerContrasenia.SizeMode = PictureBoxSizeMode.Zoom;
            picVerContrasenia.TabIndex = 10;
            picVerContrasenia.TabStop = false;
            picVerContrasenia.Click += picVerContrasenia_Click;
            // 
            // lblErrorInactivo
            // 
            lblErrorInactivo.AutoSize = true;
            lblErrorInactivo.BackColor = Color.IndianRed;
            lblErrorInactivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblErrorInactivo.ForeColor = Color.SeaShell;
            lblErrorInactivo.Location = new Point(516, 160);
            lblErrorInactivo.Margin = new Padding(4, 0, 4, 0);
            lblErrorInactivo.Name = "lblErrorInactivo";
            lblErrorInactivo.Size = new Size(334, 25);
            lblErrorInactivo.TabIndex = 13;
            lblErrorInactivo.Text = "ACCESO DENEGADO: Usuario Inactivo";
            lblErrorInactivo.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(122, 14);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1068, 217);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // chkRecordarme
            // 
            chkRecordarme.Anchor = AnchorStyles.Top;
            chkRecordarme.AutoSize = true;
            chkRecordarme.Cursor = Cursors.Hand;
            chkRecordarme.FlatStyle = FlatStyle.Flat;
            chkRecordarme.Font = new Font("Arial", 15.75F);
            chkRecordarme.Location = new Point(122, 511);
            chkRecordarme.Margin = new Padding(4, 5, 4, 5);
            chkRecordarme.Name = "chkRecordarme";
            chkRecordarme.Size = new Size(416, 40);
            chkRecordarme.TabIndex = 20;
            chkRecordarme.Text = "Recordar mis Credenciales";
            chkRecordarme.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top;
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.BackgroundImageLayout = ImageLayout.Center;
            btnRegistrar.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnRegistrar.FlatAppearance.BorderSize = 2;
            btnRegistrar.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnRegistrar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.Highlight;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(735, 722);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(315, 100);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.Text = "✚ REGISTRARSE";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1039, 959);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(111, 66);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1327, 1050);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox6);
            Controls.Add(chkRecordarme);
            Controls.Add(pictureBox3);
            Controls.Add(lblErrorInactivo);
            Controls.Add(picVerContrasenia);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lnkRecuperar);
            Controls.Add(btnSalir);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(btnRegistrar);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión ";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private LinkLabel lnkRecuperar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picVerContrasenia;
        private Label lblErrorInactivo;
        private PictureBox pictureBox3;
        private CheckBox chkRecordarme;
        private Button btnRegistrar;
        private PictureBox pictureBox6;
    }
}