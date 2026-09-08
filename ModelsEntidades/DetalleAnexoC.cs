using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEntidades
{
    
    [Table("detalles_anexo_c")]
    public class DetalleAnexoC
    {
        [Key]
        [Column("id_detalle_c")]
        public int IdDetalleC { get; set; }

        [Column("id_solicitud")]
        public int IdSolicitud { get; set; }

        [Column("aeropuerto")]
        [StringLength(100)]
        public string Aeropuerto { get; set; }

        [Column("numero_nota_permiso")]
        [StringLength(50)]
        public string NumeroNotaPermiso { get; set; }

        [Column("estado_civil")]
        [StringLength(30)]
        public string EstadoCivil { get; set; }

        // Domicilio separado
        [Column("calle")][StringLength(100)] public string Calle { get; set; }
        [Column("nro")][StringLength(20)] public string Nro { get; set; }
        [Column("piso")][StringLength(10)] public string Piso { get; set; }
        [Column("depto")][StringLength(10)] public string Depto { get; set; }
        [Column("cp")][StringLength(20)] public string Cp { get; set; }
        [Column("localidad")][StringLength(100)] public string Localidad { get; set; }

        // Contacto
        [Column("tel_particular")][StringLength(30)] public string TelParticular { get; set; }
        [Column("tel_laboral")][StringLength(30)] public string TelLaboral { get; set; }
        [Column("mail")][StringLength(100)] public string Mail { get; set; }

        // Emergencia y adicionales
        [Column("grupo_sanguineo")][StringLength(10)] public string GrupoSanguineo { get; set; }
        [Column("factor_rh")][StringLength(10)] public string FactorRh { get; set; }
        [Column("enfermedades_alergias")] public string EnfermedadesAlergias { get; set; }
        [Column("datos_socorrista_conductor")] public string DatosSocorristaConductor { get; set; }

        // Relación de navegación con Solicitud
        [ForeignKey("IdSolicitud")]
        public virtual Solicitud Solicitud { get; set; }
    }
}

