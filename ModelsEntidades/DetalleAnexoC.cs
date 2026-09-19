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

        // --- DATOS PERSONALES FALTANTES ---
        [Column("apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Column("nombres")]
        [StringLength(100)]
        public string Nombres { get; set; }

        [Column("dni_pasaporte")]
        [StringLength(30)]
        public string DniPasaporte { get; set; }

        [Column("estado_civil")]
        [StringLength(30)]
        public string EstadoCivil { get; set; }

        [Column("lugar_nacimiento")]
        [StringLength(100)]
        public string LugarNacimiento { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("cargo_funcion")]
        [StringLength(100)]
        public string CargoFuncion { get; set; }

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

        // Emergencia y adicionales (OACI Doc. 8973)
        [Column("grupo_sanguineo")][StringLength(10)] public string GrupoSanguineo { get; set; }
        [Column("factor_rh")][StringLength(10)] public string FactorRh { get; set; }
        [Column("enfermedades_alergias")] public string EnfermedadesAlergias { get; set; }

        [Column("socorrista")]
        public bool Socorrista { get; set; }

        [Column("conductor")]
        public bool Conductor { get; set; }

        // --- MATRIZ DE SECTORES Y JUSTIFICACIONES ---
        [Column("sector_1")] public bool Sector1 { get; set; }
        [Column("sector_1_justif")] public string Sector1Justif { get; set; }

        [Column("sector_2")] public bool Sector2 { get; set; }
        [Column("sector_2_justif")] public string Sector2Justif { get; set; }

        [Column("sector_3")] public bool Sector3 { get; set; }
        [Column("sector_3_justif")] public string Sector3Justif { get; set; }

        [Column("sector_4")] public bool Sector4 { get; set; }
        [Column("sector_4_justif")] public string Sector4Justif { get; set; }

        [Column("sector_5")] public bool Sector5 { get; set; }
        [Column("sector_5_justif")] public string Sector5Justif { get; set; }

        [Column("sector_6")] public bool Sector6 { get; set; }
        [Column("sector_6_justif")] public string Sector6Justif { get; set; }

        [Column("sector_7")] public bool Sector7 { get; set; }
        [Column("sector_7_justif")] public string Sector7Justif { get; set; }

        [Column("justif_sna_regionales")]
        public string JustifSnaRegionales { get; set; }

        // Relación de navegación con Solicitud
        [ForeignKey("IdSolicitud")]
        public virtual Solicitud Solicitud { get; set; }
    }
}

