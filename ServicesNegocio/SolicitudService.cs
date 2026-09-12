using DataEF;
using ModelsEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesNegocio
{
    public class SolicitudService
    {
        // Ya no necesitamos el _context global porque cada método abrirá su propio contexto fresco
        // (Podés borrar el campo privado y el constructor si ningún otro lado lo usa de forma externa)

        public void CrearSolicitud(Solicitud nuevaSolicitud)
        {
            if (nuevaSolicitud == null)
            {
                throw new ArgumentNullException(nameof(nuevaSolicitud));
            }

            if (string.IsNullOrEmpty(nuevaSolicitud.TipoSolicitud))
            {
                throw new Exception("El tipo de solicitud es requerido.");
            }

            nuevaSolicitud.FechaSolicitud = DateTime.Now;

            using (var context = new CredenSoftContext())
            {
                context.Solicitudes.Add(nuevaSolicitud);
                context.SaveChanges();
            }
        }

        public List<Solicitud> ObtenerTodas()
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .ToList();
            }
        }

        /// <summary>
        /// Obtiene una solicitud específica por su ID incluyendo los datos de su Usuario.
        /// </summary>
        public Solicitud ObtenerPorId(int idSolicitud)
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.DetalleAnexoC)
                    .Include(s => s.DetalleAnexoE)
                    .Include(s => s.ArchivosAdjuntos)
                    .FirstOrDefault(s => s.IdSolicitud == idSolicitud);
            }
        }

        /// <summary>
        /// Modifica la descripción o el estado de una solicitud en el sistema.
        /// </summary>
        public void ActualizarEstadoSolicitud(int idSolicitud, string nuevoEstado)
        {
            using (var context = new CredenSoftContext())
            {
                var solicitud = context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
                if (solicitud == null)
                {
                    throw new Exception("La solicitud especificada no existe.");
                }

                solicitud.Descripcion = $"Solicitud {nuevoEstado} el {DateTime.Now:dd/MM/yyyy}";
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina físicamente una solicitud del listado.
        /// </summary>
        public void EliminarSolicitud(int idSolicitud)
        {
            using (var context = new CredenSoftContext())
            {
                var solicitud = context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
                if (solicitud == null)
                {
                    throw new Exception("La solicitud que intenta eliminar no existe.");
                }

                context.Solicitudes.Remove(solicitud);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Consulta general: Trae todas las solicitudes con los datos del usuario que la pidió.
        /// </summary>
        public List<Solicitud> ObtenerTodasLasSolicitudes()
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .ToList();
            }
        }

        public void Inactivar(int idSolicitud)
        {
            using (var context = new CredenSoftContext())
            {
                var solicitud = context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
                if (solicitud == null)
                {
                    throw new Exception("Solicitud no encontrada.");
                }

                solicitud.Estado = "Inactivo";
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Consulta específica: Trae únicamente las solicitudes creadas por un agente en particular.
        /// </summary>
        public List<Solicitud> ObtenerSolicitudesPorUsuario(int idUsuario)
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .Where(s => s.IdUsuario == idUsuario)
                    .ToList();
            }
        }
        /// <summary>
        /// Filtra las solicitudes según el DNI del usuario titular.
        /// </summary>
        public List<Solicitud> ObtenerPorDni(string dni)
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .Where(s => s.Usuario.Dni.Contains(dni))
                    .ToList();
            }
        }

        /// <summary>
        /// Filtra las solicitudes por su estado.
        /// </summary>
        public List<Solicitud> ObtenerPorEstado(string estado)
        {
            using (var context = new CredenSoftContext())
            {
                if (string.IsNullOrEmpty(estado) || estado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                {
                    return ObtenerTodas();
                }

                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .Where(s => s.Estado != null && s.Estado.ToLower() == estado.ToLower())
                    .ToList();
            }
        }
        /// <summary>
        /// Actualiza todos los datos de una solicitud existente.
        /// </summary>
       // 2. UBICÁ TU MÉTODO ACTUALIZAR Y REEMPLAZALO POR ESTE COMPLETO
        public void Actualizar(Solicitud solicitudModificada)
        {
            if (solicitudModificada == null)
            {
                throw new ArgumentNullException(nameof(solicitudModificada));
            }

            using (var context = new CredenSoftContext())
            {
                // Buscamos la entidad existente incluyendo sus archivos adjuntos
                var solicitudExistente = context.Solicitudes
                    .Include(s => s.ArchivosAdjuntos)
                    .FirstOrDefault(s => s.IdSolicitud == solicitudModificada.IdSolicitud);

                if (solicitudExistente == null)
                {
                    throw new Exception("No se encontró la solicitud a actualizar.");
                }

                // Actualizamos las propiedades básicas
                solicitudExistente.IdUsuario = solicitudModificada.IdUsuario;
                solicitudExistente.TipoSolicitud = solicitudModificada.TipoSolicitud;
                solicitudExistente.Descripcion = solicitudModificada.Descripcion;
                solicitudExistente.Estado = solicitudModificada.Estado;

                // Gestionamos los archivos adjuntos
                if (solicitudModificada.ArchivosAdjuntos != null && solicitudModificada.ArchivosAdjuntos.Any())
                {
                    var archivoModificado = solicitudModificada.ArchivosAdjuntos.First();
                    var archivoExistente = solicitudExistente.ArchivosAdjuntos.FirstOrDefault();

                    if (archivoExistente != null)
                    {
                        // Actualiza el archivo que ya estaba
                        archivoExistente.RutaArchivo = archivoModificado.RutaArchivo;
                        archivoExistente.NombreArchivo = archivoModificado.NombreArchivo;
                        archivoExistente.TipoDocumento = archivoModificado.TipoDocumento;
                    }
                    else
                    {
                        // Agrega uno nuevo si antes no tenía
                        solicitudExistente.ArchivosAdjuntos.Add(new DocumentoAdjunto
                        {
                            IdSolicitud = solicitudExistente.IdSolicitud,
                            RutaArchivo = archivoModificado.RutaArchivo,
                            NombreArchivo = archivoModificado.NombreArchivo,
                            TipoDocumento = archivoModificado.TipoDocumento
                        });
                    }
                }

                context.SaveChanges();
            }
        }
    }
}