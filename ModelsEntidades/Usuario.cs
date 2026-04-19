using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsEntidades
{
    [Table("usuarios")] // Coincide con tu script SQL
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; } // IDENTITY(1,1)

        [Column("id_rol")]
        public int IdRol { get; set; } // FK a roles

        [Required]
        [StringLength(50)]
        [Column("nombre")]
        public string Nombre { get; set; } // NOT NULL

        [Required]
        [StringLength(50)]
        [Column("apellido")]
        public string Apellido { get; set; } // NOT NULL

        [Required]
        [StringLength(20)]
        [Column("dni")]
        public string Dni { get; set; } // VARCHAR(20) y UNIQUE

        [Required]
        [StringLength(100)]
        [Column("email")]
        public string Email { get; set; } // VARCHAR(100) y UNIQUE

        [Required]
        [StringLength(255)]
        [Column("contrasenia")]
        public string Contrasenia { get; set; } // Soporta Hashes de seguridad

        [Required]
        [StringLength(20)]
        [Column("estado")]
        public string Estado { get; set; } // NOT NULL

        // Relación para navegación en el Backend
        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; }
    }
}