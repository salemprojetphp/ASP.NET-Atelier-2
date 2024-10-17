using Microsoft.EntityFrameworkCore;
using MyFrstMVCApp.Models;

public class ApplicationDbContext : DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }	
    public DbSet<Client> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>()
            .HasOne(m => m.Genre)
            .WithMany(g => g.Movies)
            .HasForeignKey(m => m.GenreId)
            .OnDelete(DeleteBehavior.Cascade);  
    }


    //Peut ne pas etre implementer car EF Core peut le faire automatiquement
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Movie>()
    //         .HasOne(m=>m.Genre)
    //         .WithMany(g=>g.Movies)
    //         .HasForeignKey(m=>m.GenreId);
    // }
}