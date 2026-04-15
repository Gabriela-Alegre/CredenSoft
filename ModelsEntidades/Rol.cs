using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsEntidades
{
	[Table("roles")]
	public class Rol
	{
		[Key]
		[Column("id_rol")]
		public int IdRol { get; set; }

		[Required]
		[Column("nombre_rol")]
		[StringLength(50)]
		public string NombreRol { get; set; } // Ej: Admin, Operador
	}
}