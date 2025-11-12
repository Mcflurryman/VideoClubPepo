


using Microsoft.EntityFrameworkCore;
using Videoclub.Shared.Models;
using VideoclubFinal.Models;


namespace Videoclub.Shared.Data;

public class PeliculasDbContext : DbContext
{
    public PeliculasDbContext()
    {
    }
    public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<AlquilerPelicula> AlquilerPeliculas { get; set; }
    public DbSet<PeliculasDisponible> PeliculasDisponibles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeliculasDisponible>(entity =>
        {
            entity.HasOne(d => d.IdPeliculaNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PeliculasDisponibles_Peliculas");
        });

        base.OnModelCreating(modelBuilder);
    }

    // 👇 Este método va FUERA del anterior, al mismo nivel
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=PeliculasDB1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}