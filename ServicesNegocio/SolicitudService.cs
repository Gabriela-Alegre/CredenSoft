using DataEF;
using ModelsEntidades;
using Microsoft.EntityFrameworkCore;

namespace ServicesNegocio
{
    public class SolicitudService
    {
        private readonly CredenSoftContext _context;

        public SolicitudService(CredenSoftContext context)
        {
            _context = context;
        }

        public void CrearSolicitud(Solicitud nuevaSolicitud)
        {
            // 1. Validaciones iniciales (siempre al principio)
            if (nuevaSolicitud == null)
            {
                throw new ArgumentNullException(nameof(nuevaSolicitud));
            }

            if (string.IsNullOrEmpty(nuevaSolicitud.TipoSolicitud))
            {
                throw new Exception("El tipo de solicitud es requerido.");
                // Nota: Es mejor usar excepciones personalizadas que 'Exception' genérica
            }

            // 2. Asignación de valores por defecto
            nuevaSolicitud.FechaSolicitud = DateTime.Now;
            // nuevaSolicitud.EstadoId = 1; // Descomentalo si lo necesitás

            // 3. Persistencia en la base de datos
            _context.Solicitudes.Add(nuevaSolicitud);
            _context.SaveChanges();
        }

        public List<Solicitud> ObtenerTodas()
        {
            return _context.Solicitudes
                .Include(s => s.Usuario) // Quién la pidió
                .ToList();
        }
        /// <summary>
        /// Obtiene una solicitud específica por su ID incluyendo los datos de su Usuario.
        /// </summary>
        public Solicitud ObtenerPorId(int idSolicitud)
        {
            return _context.Solicitudes
                .Include(s => s.Usuario)
                .FirstOrDefault(s => s.IdSolicitud == idSolicitud);
        }

        /// <summary>
        /// Modifica la descripción o el estado de una solicitud en el sistema.
        /// </summary>
        public void ActualizarEstadoSolicitud(int idSolicitud, string nuevoEstado)
        {
            var solicitud = _context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
            if (solicitud == null)
            {
                throw new Exception("La solicitud especificada no existe.");
            }

            // Aquí podrías cambiar el estado o la descripción según tu lógica de negocio
            solicitud.Descripcion = $"Solicitud {nuevoEstado} el {DateTime.Now:dd/MM/yyyy}";

            _context.SaveChanges();
        }

        /// <summary>
        /// Elimina físicamente una solicitud del listado (si aplica según tu HU).
        /// </summary>
        public void EliminarSolicitud(int idSolicitud)
        {
            var solicitud = _context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
            if (solicitud == null)
            {
                throw new Exception("La solicitud que intenta eliminar no existe.");
            }

            _context.Solicitudes.Remove(solicitud);
            _context.SaveChanges();
        }
        /// <summary>
        /// Inserta una nueva solicitud de credencial en la Base de Datos.
        /// </summary>
        
        

        /// <summary>
        /// Consulta general: Trae todas las solicitudes con los datos del usuario que la pidió.
        /// </summary>
        public List<Solicitud> ObtenerTodasLasSolicitudes()
        {
            return _context.Solicitudes
                .Include(s => s.Usuario) // Para saber qué agente hizo la solicitud
                .ToList();
        }
        /// <summary>
        /// Consulta específica: Trae únicamente las solicitudes creadas por un agente en particular.
        /// </summary>
        public List<Solicitud> ObtenerSolicitudesPorUsuario(int idUsuario)
        {
            return _context.Solicitudes
                .Include(s => s.Usuario)
                .Where(s => s.IdUsuario == idUsuario)
                .ToList();
        }
    }
}