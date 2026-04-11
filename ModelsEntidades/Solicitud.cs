using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CredenSoft.Models
{
    [Table("solicitudes")]
    public class Solicitud
    {
        [Key]
        [Column("id_solicitud")]
        public int IdSolicitud { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; } // FK hacia usuarios

        [Required]
        [Column("tipo_solicitud")]
        [StringLength(50)]
        public string TipoSolicitud { get; set; }

        [Column("fecha_solicitud")]
        public DateTime FechaSolicitud { get; set; } = DateTime.Now; // Coincide con DEFAULT GETDATE()

        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }

        // Propiedad de navegación para el Backend
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}