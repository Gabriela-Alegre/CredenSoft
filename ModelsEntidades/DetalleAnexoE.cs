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

        [Column("tareas")]
        public string Tareas { get; set; }

        // --- SOLICITANTE 1 ---
        [Column("sol1_apenom")]
        [StringLength(150)]
        public string Sol1ApeNom { get; set; }

        [Column("sol1_tipodoc")]
        [StringLength(50)]
        public string Sol1TipoDoc { get; set; }

        [Column("sol1_docnro")]
        [StringLength(50)]
        public string Sol1DocNro { get; set; }

        [Column("sol1_cargo")]
        [StringLength(100)]
        public string Sol1Cargo { get; set; }

        // --- SOLICITANTE 2 ---
        [Column("sol2_apenom")]
        [StringLength(150)]
        public string Sol2ApeNom { get; set; }

        [Column("sol2_tipodoc")]
        [StringLength(50)]
        public string Sol2TipoDoc { get; set; }

        [Column("sol2_docnro")]
        [StringLength(50)]
        public string Sol2DocNro { get; set; }

        [Column("sol2_cargo")]
        [StringLength(100)]
        public string Sol2Cargo { get; set; }

        // --- SOLICITANTE 3 ---
        [Column("sol3_apenom")]
        [StringLength(150)]
        public string Sol3ApeNom { get; set; }

        [Column("sol3_tipodoc")]
        [StringLength(50)]
        public string Sol3TipoDoc { get; set; }

        [Column("sol3_docnro")]
        [StringLength(50)]
        public string Sol3DocNro { get; set; }

        [Column("sol3_cargo")]
        [StringLength(100)]
        public string Sol3Cargo { get; set; }

        // --- SOLICITANTE 4 ---
        [Column("sol4_apenom")]
        [StringLength(150)]
        public string Sol4ApeNom { get; set; }

        [Column("sol4_tipodoc")]
        [StringLength(50)]
        public string Sol4TipoDoc { get; set; }

        [Column("sol4_docnro")]
        [StringLength(50)]
        public string Sol4DocNro { get; set; }

        [Column("sol4_cargo")]
        [StringLength(100)]
        public string Sol4Cargo { get; set; }

        // --- SOLICITANTE 5 ---
        [Column("sol5_apenom")]
        [StringLength(150)]
        public string Sol5ApeNom { get; set; }

        [Column("sol5_tipodoc")]
        [StringLength(50)]
        public string Sol5TipoDoc { get; set; }

        [Column("sol5_docnro")]
        [StringLength(50)]
        public string Sol5DocNro { get; set; }

        [Column("sol5_cargo")]
        [StringLength(100)]
        public string Sol5Cargo { get; set; }

        // --- Matriz de Autorización (Sectores 1 al 7) ---
        [Column("sector_1")]
        public bool Sector1 { get; set; }

        [Column("justificacion_sector_1")]
        [StringLength(255)]
        public string JustificacionSector1 { get; set; }

        [Column("sector_2")]
        public bool Sector2 { get; set; }

        [Column("justificacion_sector_2")]
        [StringLength(255)]
        public string JustificacionSector2 { get; set; }

        [Column("sector_3")]
        public bool Sector3 { get; set; }

        [Column("justificacion_sector_3")]
        [StringLength(255)]
        public string JustificacionSector3 { get; set; }

        [Column("sector_4")]
        public bool Sector4 { get; set; }

        [Column("justificacion_sector_4")]
        [StringLength(255)]
        public string JustificacionSector4 { get; set; }

        [Column("sector_5")]
        public bool Sector5 { get; set; }

        [Column("justificacion_sector_5")]
        [StringLength(255)]
        public string JustificacionSector5 { get; set; }

        [Column("sector_6")]
        public bool Sector6 { get; set; }

        [Column("justificacion_sector_6")]
        [StringLength(255)]
        public string JustificacionSector6 { get; set; }

        [Column("sector_7")]
        public bool Sector7 { get; set; }

        [Column("justificacion_sector_7")]
        [StringLength(255)]
        public string JustificacionSector7 { get; set; }

        // --- Responsables / Acompañantes (1 y 2) ---
        [Column("responsable_ap_nombre")]
        [StringLength(100)]
        public string ResponsableApNombre { get; set; }

        [Column("responsable_nro_permiso")]
        [StringLength(50)]
        public string ResponsableNroPermiso { get; set; }

        [Column("responsable_cargo")]
        [StringLength(100)]
        public string ResponsableCargo { get; set; }

        [Column("resp2_apenom")]
        [StringLength(150)]
        public string Resp2ApeNom { get; set; }

        [Column("resp2_nro_permiso")]
        [StringLength(50)]
        public string Resp2NroPermiso { get; set; }

        [Column("resp2_cargo")]
        [StringLength(100)]
        public string Resp2Cargo { get; set; }

        // Relación de navegación con Solicitud
        [ForeignKey("IdSolicitud")]
        public virtual Solicitud Solicitud { get; set; }
    }
}