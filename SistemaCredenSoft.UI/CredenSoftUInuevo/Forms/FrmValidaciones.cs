using ModelsEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmValidaciones : Form
    {
        public FrmValidaciones()
        {
            InitializeComponent();
        }

        // =====================================================
        // VALIDACIÓN DE ACCESO
        // PASO 3.7 - Protección de Formularios
        // =====================================================

        private void FrmValidaciones_Load(object sender, EventArgs e)
        {
            // Evita errores al abrir el diseñador de Visual Studio
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // Validamos sesión
            if (SesionActual.UsuarioLogueado == null)
            {
                MessageBox.Show(
                    "No hay sesión iniciada.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
                return;
            }

            // Solo Administrador Local puede acceder
            if (SesionActual.UsuarioLogueado.IdRol != 2)
            {
                MessageBox.Show(
                    "ACCESO DENEGADO.\nNo posee permisos para ingresar a Validaciones.",
                    "Seguridad del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                this.Close();
            }
        }

        // =====================================================
        // APROBAR SOLICITUD
        // PASO 3.6 - Validaciones Simuladas
        // =====================================================

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Solicitud aprobada correctamente.",
                "CredenSoft",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // =====================================================
        // RECHAZAR SOLICITUD
        // PASO 3.6 - Validaciones Simuladas
        // =====================================================

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Solicitud rechazada.",
                "CredenSoft",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        // =====================================================
        // VER DETALLE DE SOLICITUD
        // PASO 3.6 - Navegación
        // =====================================================

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.Show();

            this.Hide();
        }

        // =====================================================
        // VOLVER AL DASHBOARD LOCAL
        // PASO 3.6 - Navegación
        // =====================================================

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmDashboardLocal frm = new FrmDashboardLocal();
            frm.Show();

            this.Hide();
        }
    }
}