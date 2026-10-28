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

        /*  public List<Solicitud> ObtenerTodas()
          {
              using (var context = new CredenSoftContext())
              {
                  return context.Solicitudes
                      .Include(s => s.Usuario)
                      .Include(s => s.ArchivosAdjuntos)
                      .ToList();
              }
          }
          */
        public List<Solicitud> ObtenerTodas()
        {
            using (var context = new CredenSoftContext())
            {
                try
                {
                    return context.Solicitudes
                        .Include(s => s.Usuario)
                        .Include(s => s.ArchivosAdjuntos)
                        .ToList();
                }
                catch (Exception ex)
                {
                    string mensajeReal = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    throw new Exception("Error al cargar solicitudes: " + mensajeReal, ex);
                }
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
                    .Include(s => s.ArchivosAdjuntos)
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
        /// HU16 / Transición del Admin Local: Cambia el estado de 'Pendiente' a 'Pendiente de revisión'
        /// para que el Administrador Central pueda visualizarlo en su bandeja.
        /// </summary>
        public void EnviarARevision(int idSolicitud)
        {
            using (var context = new CredenSoftContext())
            {
                var solicitud = context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
                if (solicitud == null)
                {
                    throw new Exception("La solicitud no existe.");
                }

                // Cambiamos el estado exacto requerido por el Sprint 5
                solicitud.Estado = "Pendiente de revisión";
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
                     .Include(s => s.ArchivosAdjuntos)
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
                    .Include(s => s.ArchivosAdjuntos)
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
                throw new ArgumentNullException(nameof(solicitudModificada),"La solicitud no puede ser nula.");
            }

            using (var context = new CredenSoftContext())
            {
                // Buscamos la entidad existente incluyendo sus archivos adjuntos
                var solicitudExistente = context.Solicitudes
                    .Include(s => s.ArchivosAdjuntos)
                    .FirstOrDefault(s => s.IdSolicitud == solicitudModificada.IdSolicitud);


                // 2. Validación de campos obligatorios principales
                if (solicitudModificada.IdSolicitud <= 0)
                {
                    throw new ArgumentException("El ID de la solicitud no es válido.", nameof(solicitudModificada.IdSolicitud));
                }

                if (string.IsNullOrWhiteSpace(solicitudModificada.Descripcion))
                {
                    throw new ArgumentException("La descripción de la solicitud no puede estar vacía.", nameof(solicitudModificada.Descripcion));
                }

                if (string.IsNullOrWhiteSpace(solicitudModificada.Estado))
                {
                    throw new ArgumentException("El estado de la solicitud es obligatorio.", nameof(solicitudModificada.Estado));
                }

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

        /// <summary>
        /// HU17: Aprueba una solicitud en estado 'Pendiente de revisión'.
        /// </summary>
        public void AprobarSolicitud(int idSolicitud)
        {
            using (var context = new CredenSoftContext())
            {
                var solicitud = context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
                if (solicitud == null)
                {
                    throw new Exception("La solicitud no existe.");
                }
                if (!solicitud.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception("Solo se pueden aprobar solicitudes que se encuentren en estado 'Pendiente de revisión'.");
                }
                solicitud.Estado = "Aprobado";
                context.SaveChanges();
            }
        }

        /// <summary>
        /// HU17: Rechaza una solicitud en estado 'Pendiente de revisión' exigiendo un motivo obligatorio.
        /// </summary>
        public void RechazarSolicitud(int idSolicitud, string motivo)
        {
            if (string.IsNullOrWhiteSpace(motivo))
            {
                throw new Exception("Debe especificar un motivo para rechazar la solicitud.");
            }

            using (var context = new CredenSoftContext())
            {
                var solicitud = context.Solicitudes.FirstOrDefault(s => s.IdSolicitud == idSolicitud);
                if (solicitud == null)
                {
                    throw new Exception("La solicitud no existe.");
                }
                if (!solicitud.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception("Solo se pueden rechazar solicitudes que se encuentren en estado 'Pendiente de revisión'.");
                }
                solicitud.Estado = "Rechazado";
                solicitud.MotivoRechazo = motivo.Trim();
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Filtra las solicitudes generales por un rango de fechas (Para Administradores).
        /// </summary>
        public List<Solicitud> ObtenerPorFecha(DateTime desde, DateTime hasta)
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.ArchivosAdjuntos)
                    .Where(s => s.FechaSolicitud >= desde && s.FechaSolicitud <= hasta)
                    .ToList();
            }
        }

        /// <summary>
        /// Filtra las solicitudes de un usuario específico por un rango de fechas (Para Agentes).
        /// </summary>
        public List<Solicitud> ObtenerPorUsuarioYFecha(int idUsuario, DateTime desde, DateTime hasta)
        {
            using (var context = new CredenSoftContext())
            {
                return context.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.ArchivosAdjuntos)
                    .Where(s => s.IdUsuario == idUsuario && s.FechaSolicitud >= desde && s.FechaSolicitud <= hasta)
                    .ToList();
            }
        }
    }
}