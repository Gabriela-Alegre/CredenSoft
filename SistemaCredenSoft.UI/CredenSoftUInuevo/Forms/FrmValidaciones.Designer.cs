namespace CredenSoftUInuevo.Forms
{
    partial class FrmValidaciones
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            lblGestióndeValidaciones = new Label();
            lblSolicitudesPendientesdeValidación = new Label();
            dgvValidaciones = new DataGridView();
            btnAprobar = new Button();
            btnRechazar = new Button();
            btnVerDetalle = new Button();
            btnVolver = new Button();
            colID = new DataGridViewTextBoxColumn();
            colAgente = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvValidaciones).BeginInit();
            SuspendLayout();
            // 
            // lblGestióndeValidaciones
            // 
            lblGestióndeValidaciones.AutoSize = true;
            lblGestióndeValidaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGestióndeValidaciones.ForeColor = Color.FromArgb(28, 78, 128);
            lblGestióndeValidaciones.Location = new Point(8, 5);
            lblGestióndeValidaciones.Margin = new Padding(2, 0, 2, 0);
            lblGestióndeValidaciones.Name = "lblGestióndeValidaciones";
            lblGestióndeValidaciones.Size = new Size(192, 21);
            lblGestióndeValidaciones.TabIndex = 0;
            lblGestióndeValidaciones.Text = "Gestión de Validaciones";
            // 
            // lblSolicitudesPendientesdeValidación
            // 
            lblSolicitudesPendientesdeValidación.AutoSize = true;
            lblSolicitudesPendientesdeValidación.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSolicitudesPendientesdeValidación.ForeColor = Color.FromArgb(28, 78, 128);
            lblSolicitudesPendientesdeValidación.Location = new Point(8, 65);
            lblSolicitudesPendientesdeValidación.Margin = new Padding(2, 0, 2, 0);
            lblSolicitudesPendientesdeValidación.Name = "lblSolicitudesPendientesdeValidación";
            lblSolicitudesPendientesdeValidación.Size = new Size(334, 25);
            lblSolicitudesPendientesdeValidación.TabIndex = 1;
            lblSolicitudesPendientesdeValidación.Text = "Solicitudes Pendientes de Validación";
            // 
            // dgvValidaciones
            // 
            dgvValidaciones.AllowUserToAddRows = false;
            dgvValidaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvValidaciones.BackgroundColor = Color.White;
            dgvValidaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValidaciones.Columns.AddRange(new DataGridViewColumn[] { colID, colAgente, colTipo, colFecha, colEstado });
            dgvValidaciones.GridColor = Color.WhiteSmoke;
            dgvValidaciones.Location = new Point(8, 101);
            dgvValidaciones.Margin = new Padding(2, 2, 2, 2);
            dgvValidaciones.Name = "dgvValidaciones";
            dgvValidaciones.ReadOnly = true;
            dgvValidaciones.RowHeadersWidth = 62;
            dgvValidaciones.Size = new Size(930, 161);
            dgvValidaciones.TabIndex = 2;
            dgvValidaciones.CellContentClick += dgvValidaciones_CellContentClick;
            // 
            // btnAprobar
            // 
            btnAprobar.BackColor = SystemColors.ActiveCaption;
            btnAprobar.Font = new Font("Segoe UI", 13F);
            btnAprobar.ForeColor = Color.Black;
            btnAprobar.Location = new Point(22, 344);
            btnAprobar.Margin = new Padding(2, 2, 2, 2);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(166, 47);
            btnAprobar.TabIndex = 3;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = false;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.IndianRed;
            btnRechazar.Font = new Font("Segoe UI", 13F);
            btnRechazar.Location = new Point(206, 344);
            btnRechazar.Margin = new Padding(2, 2, 2, 2);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(166, 47);
            btnRechazar.TabIndex = 4;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.Lavender;
            btnVerDetalle.Font = new Font("Segoe UI", 13F);
            btnVerDetalle.Location = new Point(389, 344);
            btnVerDetalle.Margin = new Padding(2, 2, 2, 2);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(166, 47);
            btnVerDetalle.TabIndex = 5;
            btnVerDetalle.Text = "Ver Detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSalmon;
            btnVolver.Font = new Font("Segoe UI", 13F);
            btnVolver.Location = new Point(573, 344);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(166, 47);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // colID
            // 
            colID.HeaderText = "Código de Solicitud";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colAgente
            // 
            colAgente.HeaderText = "Agente";
            colAgente.MinimumWidth = 8;
            colAgente.Name = "colAgente";
            colAgente.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 8;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 8;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmValidaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 424);
            Controls.Add(btnVolver);
            Controls.Add(btnVerDetalle);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(dgvValidaciones);
            Controls.Add(lblSolicitudesPendientesdeValidación);
            Controls.Add(lblGestióndeValidaciones);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmValidaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validaciones";
            WindowState = FormWindowState.Maximized;
            Load += FrmValidaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvValidaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestióndeValidaciones;
        private Label lblSolicitudesPendientesdeValidación;
        private DataGridView dgvValidaciones;
        private Button btnAprobar;
        private Button btnRechazar;
        private Button btnVerDetalle;
        private Button btnVolver;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colAgente;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEstado;
    }
}