using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEntidades
{
    [Table("documentos_adjuntos")]
    public class DocumentoAdjunto
    {
        [Key]
        [Column("id_documento")]
        public int IdAdjunto { get; set; }

        [Column("id_solicitud")]
        public int IdSolicitud { get; set; }

        [Column("tipo_documento")]
        [StringLength(50)]
        public string TipoDocumento { get; set; }

        [Column("nombre_archivo")]
        [StringLength(255)]
        public string NombreArchivo { get; set; }

        [Column("ruta_archivo")]
        [StringLength(500)]
        public string RutaArchivo { get; set; }

        // Propiedad de navegación hacia la solicitud padre
        [ForeignKey("IdSolicitud")]
        public virtual Solicitud Solicitud { get; set; }
    }
}
