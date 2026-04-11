using Microsoft.EntityFrameworkCore;
using CredenSoft.Models;// Esto conecta con tu carpeta de Entidades
namespace CredenSoft.Data // Esto le dice a Visual Studio que este archivo vive en la carpeta Data
{
    public class CredenSoftContext : DbContext
    {
        public CredenSoftContext() { } // Constructor vacío necesario
        public CredenSoftContext(DbContextOptions<CredenSoftContext> options)
            : base(options)
        {
        }
        [cite_start] // Mapeo según tu Script SQL 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }
    
    }protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Aquí va tu conexión local
                optionsBuilder.UseSqlServer("Server=localhost;Database=CredenSoft;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            [cite_start]// Esto asegura que EF encuentre las tablas aunque en SQL estén en minúsculas 
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Rol>().ToTable("roles");
            modelBuilder.Entity<Solicitud>().ToTable("solicitudes");
            modelBuilder.Entity<Credencial>().ToTable("credenciales");
        }
    }
}