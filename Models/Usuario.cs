public class Usuario
{
    public int IdUsuario { get; set; } // PK en SQL [cite: 398]
    public int IdRol { get; set; }     // FK en SQL [cite: 398]
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Dni { get; set; }
    public string Contrasenia { get; set; } // Los 255 caracteres que pusimos 
}