using FilmDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDataAPI.Data;

public class ApplicationDBContext: DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }
    
    public DbSet<Film> Films { get; set; }
    
    public DbSet<Director> Directors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasOne(f => f.Director)
                .WithMany(d => d.Films)
                .HasForeignKey(f => f.DirectorId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}