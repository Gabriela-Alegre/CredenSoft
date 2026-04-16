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
    }
}