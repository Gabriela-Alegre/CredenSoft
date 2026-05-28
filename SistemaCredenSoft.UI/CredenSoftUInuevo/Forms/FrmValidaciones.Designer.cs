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
            colID = new DataGridViewTextBoxColumn();
            colAgente = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnAprobar = new Button();
            btnRechazar = new Button();
            btnVerDetalle = new Button();
            btnVolver = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvValidaciones).BeginInit();
            SuspendLayout();

            // 
            // lblGestióndeValidaciones
            // 
            lblGestióndeValidaciones.AutoSize = true;
            lblGestióndeValidaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGestióndeValidaciones.ForeColor = Color.FromArgb(28, 78, 128);
            lblGestióndeValidaciones.Location = new Point(12, 9);
            lblGestióndeValidaciones.Name = "lblGestióndeValidaciones";
            lblGestióndeValidaciones.Size = new Size(285, 32);
            lblGestióndeValidaciones.TabIndex = 0;
            lblGestióndeValidaciones.Text = "Gestión de Validaciones";

            // 
            // lblSolicitudesPendientesdeValidación
            // 
            lblSolicitudesPendientesdeValidación.AutoSize = true;
            lblSolicitudesPendientesdeValidación.Font = new Font("Segoe UI", 12F);
            lblSolicitudesPendientesdeValidación.Location = new Point(12, 108);
            lblSolicitudesPendientesdeValidación.Name = "lblSolicitudesPendientesdeValidación";
            lblSolicitudesPendientesdeValidación.Size = new Size(402, 32);
            lblSolicitudesPendientesdeValidación.TabIndex = 1;
            lblSolicitudesPendientesdeValidación.Text = "Solicitudes Pendientes de Validación";

            // 
            // dgvValidaciones
            // 
            dgvValidaciones.AllowUserToAddRows = false;
            dgvValidaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvValidaciones.BackgroundColor = Color.White;
            dgvValidaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValidaciones.Columns.AddRange(new DataGridViewColumn[]
            {
                colID,
                colAgente,
                colTipo,
                colFecha,
                colEstado
            });

            dgvValidaciones.GridColor = Color.WhiteSmoke;
            dgvValidaciones.Location = new Point(12, 168);
            dgvValidaciones.Name = "dgvValidaciones";
            dgvValidaciones.ReadOnly = true;
            dgvValidaciones.RowHeadersWidth = 62;
            dgvValidaciones.Size = new Size(1142, 268);
            dgvValidaciones.TabIndex = 2;

            // 
            // colID
            // 
            colID.HeaderText = "ID";
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
            // btnAprobar
            // 
            btnAprobar.BackColor = SystemColors.ActiveCaption;
            btnAprobar.ForeColor = Color.Black;
            btnAprobar.Location = new Point(12, 503);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(142, 50);
            btnAprobar.TabIndex = 3;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = false;
            btnAprobar.Click += btnAprobar_Click;

            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.IndianRed;
            btnRechazar.Location = new Point(226, 503);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(142, 50);
            btnRechazar.TabIndex = 4;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            btnRechazar.Click += btnRechazar_Click;

            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.DarkSeaGreen;
            btnVerDetalle.Location = new Point(440, 503);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(142, 50);
            btnVerDetalle.TabIndex = 5;
            btnVerDetalle.Text = "Ver Detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;

            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSalmon;
            btnVolver.Location = new Point(654, 503);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 50);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;

            // 
            // FrmValidaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 707);
            Controls.Add(btnVolver);
            Controls.Add(btnVerDetalle);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(dgvValidaciones);
            Controls.Add(lblSolicitudesPendientesdeValidación);
            Controls.Add(lblGestióndeValidaciones);

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
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colAgente;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEstado;
        private Button btnAprobar;
        private Button btnRechazar;
        private Button btnVerDetalle;
        private Button btnVolver;
    }
}