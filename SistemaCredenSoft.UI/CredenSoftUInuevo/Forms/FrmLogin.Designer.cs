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
            lblCredenSoft = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasenia = new Label();
            txtContrasenia = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            lnkRecuperar = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblIdentificacionDeSeguridad = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblCredenSoft
            // 
            lblCredenSoft.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Underline);
            lblCredenSoft.ForeColor = Color.FromArgb(10, 48, 78);
            lblCredenSoft.Location = new Point(256, 23);
            lblCredenSoft.Margin = new Padding(4, 0, 4, 0);
            lblCredenSoft.Name = "lblCredenSoft";
            lblCredenSoft.Size = new Size(423, 91);
            lblCredenSoft.TabIndex = 0;
            lblCredenSoft.Text = "  CredenSoft   ";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 13F);
            lblUsuario.ForeColor = SystemColors.ControlDarkDark;
            lblUsuario.Location = new Point(180, 143);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(121, 22);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Email/Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(341, 142);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(255, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.Transparent;
            lblContrasenia.Font = new Font("Microsoft Sans Serif", 13F);
            lblContrasenia.ForeColor = SystemColors.ControlDarkDark;
            lblContrasenia.Location = new Point(180, 204);
            lblContrasenia.Margin = new Padding(4, 0, 4, 0);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(103, 22);
            lblContrasenia.TabIndex = 3;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Location = new Point(341, 206);
            txtContrasenia.Margin = new Padding(4, 3, 4, 3);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(255, 23);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Font = new Font("Segoe UI", 9F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(475, 307);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(121, 27);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INICIAR SESION";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(180, 387);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lnkRecuperar
            // 
            lnkRecuperar.AutoSize = true;
            lnkRecuperar.Location = new Point(298, 343);
            lnkRecuperar.Name = "lnkRecuperar";
            lnkRecuperar.Size = new Size(128, 15);
            lnkRecuperar.TabIndex = 7;
            lnkRecuperar.TabStop = true;
            lnkRecuperar.Text = "¿Olvido su contraseña?";
            lnkRecuperar.LinkClicked += lnkRecuperar_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.b6e50688_f5a5_4dfc_8398_dbfd6d6f8a81;
            pictureBox1.InitialImage = Properties.Resources.b6e50688_f5a5_4dfc_8398_dbfd6d6f8a81;
            pictureBox1.Location = new Point(308, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._3b1b6ede_8345_4121_a42d_39862e99710c;
            pictureBox2.Location = new Point(308, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(568, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // lblIdentificacionDeSeguridad
            // 
            lblIdentificacionDeSeguridad.AutoSize = true;
            lblIdentificacionDeSeguridad.Font = new Font("Segoe UI", 13F);
            lblIdentificacionDeSeguridad.ForeColor = Color.FromArgb(10, 48, 78);
            lblIdentificacionDeSeguridad.Location = new Point(256, 73);
            lblIdentificacionDeSeguridad.Name = "lblIdentificacionDeSeguridad";
            lblIdentificacionDeSeguridad.Size = new Size(284, 25);
            lblIdentificacionDeSeguridad.TabIndex = 11;
            lblIdentificacionDeSeguridad.Text = "Identificación de Seguridad Digital";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(235, 272);
            label1.Name = "label1";
            label1.Size = new Size(426, 20);
            label1.TabIndex = 0;
            label1.Text = "Para obtener su cuenta, solicite el Alta al Administrador Central";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(278, 309);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 12;
            label2.Text = "¿ya tienes una cuenta?";
            label2.Click += label2_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(916, 561);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIdentificacionDeSeguridad);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lnkRecuperar);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblCredenSoft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión ";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredenSoft;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private LinkLabel lnkRecuperar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblIdentificacionDeSeguridad;
        private Label label1;
        private Label label2;
    }
}