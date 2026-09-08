using Microsoft.EntityFrameworkCore;
using ModelsEntidades;// Esto conecta con tu carpeta de Entidades
namespace DataEF // Esto le dice a Visual Studio que este archivo vive en la carpeta Data
{
    public class CredenSoftContext : DbContext
    {
        public CredenSoftContext() { } // Constructor vacío necesario
        public CredenSoftContext(DbContextOptions<CredenSoftContext> options)
            : base(options)
        {
        }
      
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }
        public DbSet<DetalleAnexoC> DetallesAnexoC { get; set; }
        public DbSet<DetalleAnexoE> DetallesAnexoE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //  
                optionsBuilder.UseSqlServer("Server=localhost;Database=CredenSoft;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Rol>().ToTable("roles");
            modelBuilder.Entity<Solicitud>().ToTable("solicitudes");
            modelBuilder.Entity<Credencial>().ToTable("credenciales");
            modelBuilder.Entity<DetalleAnexoC>().ToTable("detalles_anexo_c");
            modelBuilder.Entity<DetalleAnexoE>().ToTable("detalles_anexo_e");
        }
    }
}