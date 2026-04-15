using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsEntidades
{
    [Table("credenciales")]
    public class Credencial
    {
        [Key]
        [Column("id_credencial")]
        public int IdCredencial { get; set; }

        [Column("id_solicitud")]
        public int IdSolicitud { get; set; }

        [Column("fecha_emision")]
        public DateTime FechaEmision { get; set; }

        [Column("fecha_vencimiento")]
        public DateTime FechaVencimiento { get; set; }

        [Required]
        [Column("estado")]
        [StringLength(20)]
        public string Estado { get; set; } // Ej: Activa, Vencida

        [ForeignKey("IdSolicitud")]
        public virtual Solicitud Solicitud { get; set; }
    }
}