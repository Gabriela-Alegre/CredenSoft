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

        public void CrearSolicitud(Solicitud nueva)
        {
            nueva.FechaSolicitud = DateTime.Now;
            // Podés setear un estado inicial por defecto (ej: ID 1 = Pendiente)
            // nueva.EstadoId = 1; 

            _context.Solicitudes.Add(nueva);
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
    }
}