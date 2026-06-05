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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerContrasenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Italic);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(220, 50);
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
            txtUsuario.Location = new Point(635, 50);
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
            lblContrasenia.Location = new Point(220, 135);
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
            txtContrasenia.Location = new Point(635, 133);
            txtContrasenia.Margin = new Padding(6, 5, 6, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(614, 42);
            txtContrasenia.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.FromArgb(28, 78, 128);
            btnIngresar.BackgroundImageLayout = ImageLayout.None;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(322, 73);
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
            btnSalir.Anchor = AnchorStyles.Right;
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.White;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(1315, 254);
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
            lnkRecuperar.Anchor = AnchorStyles.Left;
            lnkRecuperar.AutoSize = true;
            lnkRecuperar.Font = new Font("Segoe UI", 13F);
            lnkRecuperar.Location = new Point(340, 185);
            lnkRecuperar.Margin = new Padding(4, 0, 4, 0);
            lnkRecuperar.Name = "lnkRecuperar";
            lnkRecuperar.Size = new Size(279, 36);
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
            pictureBox1.Location = new Point(554, 135);
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
            pictureBox2.Location = new Point(547, 50);
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
            picVerContrasenia.Location = new Point(1176, 135);
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
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(97, 14);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1016, 196);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // chkRecordarme
            // 
            chkRecordarme.Anchor = AnchorStyles.Top;
            chkRecordarme.AutoSize = true;
            chkRecordarme.BackColor = Color.Transparent;
            chkRecordarme.Cursor = Cursors.Hand;
            chkRecordarme.FlatStyle = FlatStyle.Flat;
            chkRecordarme.Font = new Font("Microsoft Sans Serif", 13F);
            chkRecordarme.ForeColor = SystemColors.ControlDarkDark;
            chkRecordarme.Location = new Point(934, 183);
            chkRecordarme.Margin = new Padding(4, 5, 4, 5);
            chkRecordarme.Name = "chkRecordarme";
            chkRecordarme.Size = new Size(345, 34);
            chkRecordarme.TabIndex = 20;
            chkRecordarme.Text = "Recordar mis Credenciales";
            chkRecordarme.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
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
            btnRegistrar.Location = new Point(934, 73);
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
            pictureBox6.Anchor = AnchorStyles.Right;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1330, 270);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(111, 66);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(chkRecordarme);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(lnkRecuperar);
            panel1.Controls.Add(btnSalir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 663);
            panel1.Name = "panel1";
            panel1.Size = new Size(1522, 387);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(lblContrasenia);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(picVerContrasenia);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtContrasenia);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(1522, 358);
            panel2.TabIndex = 26;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1522, 1050);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(lblErrorInactivo);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
    }
}