using DataEF;
using ModelsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesNegocio
{
    public class CredencialService
    {
        private readonly CredenSoftContext _context;

        public CredencialService(CredenSoftContext context)
        {
            _context = context;
        }

        public void GenerarCredencial(int idDeLaSolicitud)
        {
            var nuevaCredencial = new Credencial();

            
            nuevaCredencial.IdSolicitud = idDeLaSolicitud;

            
            nuevaCredencial.FechaEmision = DateTime.Now;

           
            nuevaCredencial.FechaVencimiento = DateTime.Now.AddYears(2);

            _context.Credenciales.Add(nuevaCredencial);
            _context.SaveChanges();
        }
    }
}