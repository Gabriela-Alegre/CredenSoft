using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsEntidades
{
    [Table("detalles_anexo_e")]
    public class DetalleAnexoE
    {
        [Key]
        [Column("id_detalle_e")]
        public int IdDetalleE { get; set; }

        [Column("id_solicitud")]
        public int IdSolicitud { get; set; }

        [Column("dias_autorizados")]
        [StringLength(100)]
        public string DiasAutorizados { get; set; }

        [Column("horarios_desde")]
        [StringLength(20)]
        public string HorariosDesde { get; set; }

        [Column("horarios_hasta")]
        [StringLength(20)]
        public string HorariosHasta { get; set; }

        // Matriz de Autorización (Sectores 1 al 7)
        [Column("sector_1")] public bool Sector1 { get; set; }
        [Column("justificacion_sector_1")][StringLength(255)] public string JustificacionSector1 { get; set; }

        [Column("sector_2")] public bool Sector2 { get; set; }
        [Column("justificacion_sector_2")][StringLength(255)] public string JustificacionSector2 { get; set; }

        [Column("sector_3")] public bool Sector3 { get; set; }
        [Column("justificacion_sector_3")][StringLength(255)] public string JustificacionSector3 { get; set; }

        [Column("sector_4")] public bool Sector4 { get; set; }
        [Column("justificacion_sector_4")][StringLength(255)] public string JustificacionSector4 { get; set; }

        [Column("sector_5")] public bool Sector5 { get; set; }
        [Column("justificacion_sector_5")][StringLength(255)] public string JustificacionSector5 { get; set; }

        [Column("sector_6")] public bool Sector6 { get; set; }
        [Column("justificacion_sector_6")][StringLength(255)] public string JustificacionSector6 { get; set; }

        [Column("sector_7")] public bool Sector7 { get; set; }
        [Column("justificacion_sector_7")][StringLength(255)] public string JustificacionSector7 { get; set; }

        // Responsable de acompañamiento
        [Column("responsable_ap_nombre")][StringLength(100)] public string ResponsableApNombre { get; set; }
        [Column("responsable_nro_permiso")][StringLength(50)] public string ResponsableNroPermiso { get; set; }
        [Column("responsable_cargo")][StringLength(100)] public string ResponsableCargo { get; set; }

        // Relación de navegación con Solicitud
        [ForeignKey("IdSolicitud")]
        public virtual Solicitud Solicitud { get; set; }
    }
}