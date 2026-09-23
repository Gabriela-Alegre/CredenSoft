using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmSolicitud : Form
    {
        // =====================================================
        // SERVICIO DE SOLICITUDES
        // =====================================================

        SolicitudService _solicitudService = new SolicitudService();
        // NUEVAS VARIABLES DE SESIÓN
        private string _rolUsuario;
        private int _idUsuarioLogueado;


        public FrmSolicitud(string rolUsuario, int idUsuarioLogueado)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
            _idUsuarioLogueado = idUsuarioLogueado;

            ConfigurarPropiedadesIniciales();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 500);   // tamaño inicial
            this.MinimumSize = new Size(900, 650); // tamaño mínimo

            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSolicitudes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSolicitudes.MultiSelect = false;

            this.Activated += FrmSolicitud_Activated;
        }
        // (Opcional) Constructor vacio por si en alguna parte vieja se llama sin parámetros
        public FrmSolicitud() : this("Agente", 1) { }


        private void ConfigurarPropiedadesIniciales()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 500);
            this.MinimumSize = new Size(900, 650);

            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.MultiSelect = false;

            this.Activated += FrmSolicitud_Activated;
        }
        // =====================================================
        // CARGA DEL FORMULARIO
        // =====================================================

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            dgvSolicitudes.CellFormatting += dgvSolicitudes_CellFormatting;

            // Seleccionamos "Todos" por defecto en el ComboBox (si cargaste los items en orden: 0=Todos)
            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            // APLICAR RESTRICCIONES VISUALES SEGÚN EL ROL
            ConfigurarInterfazSegunRol();

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            CargarGrilla();
            // Conectamos el evento TextChanged por código para asegurarnos de que funcione al instante
            txtBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged; // <--- ¡Acá lo conectás!

        }

        // =====================================================
        // CONFIGURAR INTERFAZ SEGUN ROL
        // =====================================================
        private void ConfigurarInterfazSegunRol()
        {
            if (_rolUsuario == "Agente")
            {
                // El agente crea, edita y ve, pero NO inactiva registros
                btnEliminar.Visible = false;

                // Ocultar controles de búsqueda por DNI
                txtBuscarDni.Visible = false;
                lblBuscarDni.Visible = false;
                btnBuscarDni.Visible = false;

                // === SUBIR AUTOMÁTICAMENTE EL FILTRO DE ESTADO ===
                if (label3 != null && lblBuscarDni != null)
                {
                    label3.Top = lblBuscarDni.Top;
                }

                if (cmbEstado != null && txtBuscarDni != null)
                {
                    cmbEstado.Top = txtBuscarDni.Top;
                }
            }
            else if (_rolUsuario == "Administrador Central")
            {
                // El Administrador Central solo audita y consulta histórico (No crea, ni edita, ni inactiva aquí)
                btnNueva.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                // === ACOMODAR EL BOTÓN VER ===
                // Como quedan los otros botones ocultos, movemos el botón "Ver" 
                // a la posición inicial (donde estaba el botón "Nueva") para que no quede flotando solo
                if (btnVer != null && btnNueva != null)
                {
                    btnVer.Left = btnNueva.Left;
                }
            }
            else if (_rolUsuario == "Administrador Local")
            {
                // El Administrador Local tiene control total en esta pantalla
                btnNueva.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;

                // Nos aseguramos de que el botón Ver esté en su posición original si fuera necesario
                // (puedes omitirlo si ya lo tienes fijo en el diseñador)
            }
        }

        private void FrmSolicitud_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // =====================================================
        // CARGAR GRILLA
        // =====================================================

        private void CargarGrilla()
        {
            try
            {
                // 1. Limpiamos el origen de datos para evitar duplicación de columnas
                dgvSolicitudes.DataSource = null;
                // FILTRO SEGÚN EL ROL:
                if (_rolUsuario == "Agente")
                {
                    // El agente solo ve sus propias solicitudes activas por defecto
                    var misSolicitudes = _solicitudService.ObtenerSolicitudesPorUsuario(_idUsuarioLogueado);
                    dgvSolicitudes.DataSource = misSolicitudes
                        .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                else
                {
                    // Los administradores ven el listado completo excluyendo las inactivas por defecto
                    var todas = _solicitudService.ObtenerTodas();
                    dgvSolicitudes.DataSource = todas
                        .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                // APLICAR RESTRICCIONES VISUALES SEGÚN EL ROL
                ConfigurarInterfazSegunRol();

                if (cmbEstado.Items.Count > 0)
                {
                    cmbEstado.SelectedIndex = 0;
                }

                // 2. Ocultar columnas técnicas que no deben verse
                if (dgvSolicitudes.Columns["IdSolicitud"] != null)
                    dgvSolicitudes.Columns["IdSolicitud"].Visible = false;

                if (dgvSolicitudes.Columns["IdUsuario"] != null)
                    dgvSolicitudes.Columns["IdUsuario"].Visible = false;

                if (dgvSolicitudes.Columns["DetalleAnexoC"] != null)
                    dgvSolicitudes.Columns["DetalleAnexoC"].Visible = false;

                if (dgvSolicitudes.Columns["DetalleAnexoE"] != null)
                    dgvSolicitudes.Columns["DetalleAnexoE"].Visible = false;
                if (dgvSolicitudes.Columns["ArchivosAdjuntos"] != null)
                    dgvSolicitudes.Columns["ArchivosAdjuntos"].Visible = false;

                // 3. Crear la columna DNI personalizada solo si no existe previamente
                if (!dgvSolicitudes.Columns.Contains("DniUsuario"))
                {
                    DataGridViewTextBoxColumn colDni = new DataGridViewTextBoxColumn();
                    colDni.Name = "DniUsuario";
                    colDni.HeaderText = "DNI";
                    dgvSolicitudes.Columns.Add(colDni);
                }

                // 4. Configurar Títulos de las columnas visibles
                if (dgvSolicitudes.Columns["Usuario"] != null)
                    dgvSolicitudes.Columns["Usuario"].HeaderText = "Titular";

                if (dgvSolicitudes.Columns["TipoSolicitud"] != null)
                    dgvSolicitudes.Columns["TipoSolicitud"].HeaderText = "Tipo de Trámite";

                if (dgvSolicitudes.Columns["FechaSolicitud"] != null)
                    dgvSolicitudes.Columns["FechaSolicitud"].HeaderText = "Fecha de Solicitud";

                if (dgvSolicitudes.Columns["Descripcion"] != null)
                    dgvSolicitudes.Columns["Descripcion"].HeaderText = "Motivo / Descripción";

                if (dgvSolicitudes.Columns["Estado"] != null)
                    dgvSolicitudes.Columns["Estado"].HeaderText = "Estado";

                // 5. Orden de las columnas (DisplayIndex) para que se vea profesional y prolijo
                if (dgvSolicitudes.Columns["Usuario"] != null)
                    dgvSolicitudes.Columns["Usuario"].DisplayIndex = 0;

                if (dgvSolicitudes.Columns["DniUsuario"] != null)
                    dgvSolicitudes.Columns["DniUsuario"].DisplayIndex = 1;

                if (dgvSolicitudes.Columns["TipoSolicitud"] != null)
                    dgvSolicitudes.Columns["TipoSolicitud"].DisplayIndex = 2;

                if (dgvSolicitudes.Columns["FechaSolicitud"] != null)
                    dgvSolicitudes.Columns["FechaSolicitud"].DisplayIndex = 3;

                if (dgvSolicitudes.Columns["Descripcion"] != null)
                    dgvSolicitudes.Columns["Descripcion"].DisplayIndex = 4;

                if (dgvSolicitudes.Columns["Estado"] != null)
                    dgvSolicitudes.Columns["Estado"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar solicitudes: " + ex.Message,
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitudes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var solicitud = dgvSolicitudes.Rows[e.RowIndex].DataBoundItem as ModelsEntidades.Solicitud;

            if (solicitud != null && solicitud.Usuario != null)
            {
                string nombreColumna = dgvSolicitudes.Columns[e.ColumnIndex].Name;

                // Muestra Nombre y Apellido en la columna Titular
                if (nombreColumna == "Usuario")
                {
                    e.Value = solicitud.Usuario.Nombre + " " + solicitud.Usuario.Apellido;
                    e.FormattingApplied = true;
                }

                // Muestra el DNI de la base de datos en la columna creada
                if (nombreColumna == "DniUsuario")
                {
                    e.Value = solicitud.Usuario.Dni?.ToString();
                    e.FormattingApplied = true;
                }
            }
        }
        // =====================================================
        // NUEVA SOLICITUD
        // =====================================================

        private void btnNueva_Click(object sender, EventArgs e)
        {
            FrmAltaSolicitud frmAlta = new FrmAltaSolicitud();

            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                CargarGrilla();
            }
        }

        // =====================================================
        // VER DETALLE DE SOLICITUD
        // =====================================================

        private void btnVer_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya una fila seleccionada
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una solicitud.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el ID de la solicitud seleccionada desde la celda correspondiente
            // (Asegurate de que el nombre de la columna sea exactamente "IdSolicitud" o el que uses en tu grilla)
            int idSeleccionado = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["IdSolicitud"].Value);

            // 3. Abrir el formulario reutilizable pasando el ID y 'true' para el modo solo lectura
            FrmAltaSolicitud frm = new FrmAltaSolicitud(idSeleccionado, true);
            frm.ShowDialog();
        }

        // =====================================================
        // ELIMINAR SOLICITUD
        // =====================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitudes.SelectedRows.Count == 0 && dgvSolicitudes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una solicitud.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filaActual = dgvSolicitudes.SelectedRows.Count > 0 ? dgvSolicitudes.SelectedRows[0] : dgvSolicitudes.CurrentRow;
                var solicitudSeleccionada = filaActual.DataBoundItem as ModelsEntidades.Solicitud;

                if (solicitudSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la solicitud seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea INACTIVAR la solicitud seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Llamamos al servicio igual que en los usuarios
                    _solicitudService.Inactivar(solicitudSeleccionada.IdSolicitud);

                    MessageBox.Show("La solicitud fue inactivada correctamente.", "CredenSoft",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos la grilla al instante
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BUSCAR DNI
        // =====================================================
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            try
            {
                string dniBuscado = txtBuscarDni.Text.Trim();

                // Si la caja de texto está vacía, recargamos la grilla completa por defecto
                if (string.IsNullOrEmpty(dniBuscado))
                {
                    CargarGrilla();
                    return;
                }

                // Llamamos al nuevo método del servicio que busca por DNI
                var listaFiltrada = _solicitudService.ObtenerPorDni(dniBuscado);

                if (listaFiltrada == null || listaFiltrada.Count == 0)
                {
                    MessageBox.Show("No se encontraron solicitudes asociadas a ese DNI.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: si no encuentra nada, podés limpiar la grilla o dejar la anterior
                    dgvSolicitudes.DataSource = null;
                    return;
                }

                // Mostramos el resultado filtrado en la grilla
                dgvSolicitudes.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            // Si el usuario borró todo y el textbox quedó vacío, recargamos la grilla completa al instante
            if (string.IsNullOrWhiteSpace(txtBuscarDni.Text))
            {
                CargarGrilla();
            }
        }


        // =====================================================
        // BUSCAR POR ESTADO
        // =====================================================

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                string estadoSeleccionado = cmbEstado.SelectedItem?.ToString();

                if (_rolUsuario == "Agente")
                {
                    var misSolicitudes = _solicitudService.ObtenerSolicitudesPorUsuario(_idUsuarioLogueado);

                    if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                    {
                        // Por defecto "Todos" para el agente excluye inactivos
                        dgvSolicitudes.DataSource = misSolicitudes
                            .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    else
                    {
                        // Si selecciona explícitamente "Inactivo" u otro estado, filtra exacto
                        dgvSolicitudes.DataSource = misSolicitudes
                            .Where(s => s.Estado != null && s.Estado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                }
                else
                {
                    // Lógica para administradores
                    if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                    {
                        // Si el combo está en "Todos", ocultamos las inactivas
                        var todas = _solicitudService.ObtenerTodas();
                        dgvSolicitudes.DataSource = todas
                            .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    else
                    {
                        // Si el usuario elige explícitamente "Inactivo" (o Pendiente, Aprobado, etc.), trae los que coincidan
                        var listaFiltrada = _solicitudService.ObtenerPorEstado(estadoSeleccionado);
                        dgvSolicitudes.DataSource = listaFiltrada;
                    }
                }

                OcultarColumnasTecnicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por estado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OcultarColumnasTecnicas()
        {
            if (dgvSolicitudes.Columns["IdSolicitud"] != null)
                dgvSolicitudes.Columns["IdSolicitud"].Visible = false;

            if (dgvSolicitudes.Columns["IdUsuario"] != null)
                dgvSolicitudes.Columns["IdUsuario"].Visible = false;

            if (dgvSolicitudes.Columns["ArchivosAdjuntos"] != null)
                dgvSolicitudes.Columns["ArchivosAdjuntos"].Visible = false;
        }

        // =====================================================
        // EDITAR SOLICITUD
        // =====================================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                // 1. Obtenemos la solicitud seleccionada de la grilla
                Solicitud solicitudSeleccionada = (Solicitud)dgvSolicitudes.SelectedRows[0].DataBoundItem;

                // 2. Abrimos el formulario pasándole el ID al constructor (para que active el modo edición)
                using (FrmAltaSolicitud frm = new FrmAltaSolicitud(solicitudSeleccionada.IdSolicitud))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarGrilla(); // Refresca tu DataGridView principal
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una solicitud de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================
        // SALIR
        // =====================================================

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}