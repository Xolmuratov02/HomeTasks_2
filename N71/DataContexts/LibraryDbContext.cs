using Microsoft.EntityFrameworkCore;
using N71.Models;

namespace N71.DataContexts;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();

    public DbSet<Author> Authors => Set<Author>();

    public DbSet<Review> Reviews => Set<Review>();

    public LibraryDbContext() : base(new DbContextOptionsBuilder<LibraryDbContext>()
        .UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=3325")
        .Options)
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
    }
}