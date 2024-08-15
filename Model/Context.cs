using Microsoft.EntityFrameworkCore;

namespace api_cadastro_backend.Model;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) :base(options)
    {
        
    }

    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(usuario =>
        {
            usuario.HasKey(k => k.Id);
            usuario.HasIndex(e => e.Email)
                .IsUnique();
        });
        
        OnModelCreatingPartial(modelBuilder);
    }

    private void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        
    }
}