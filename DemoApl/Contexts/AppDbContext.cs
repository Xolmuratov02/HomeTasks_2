using Microsoft.EntityFrameworkCore;
using DemoApl.Entities;

namespace DemoApl.Contexts;

public class AppDbContext : DbContext
{
    public virtual DbSet<User> Users {get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DemoApl;Username=postgres;Password=3325");
    }
}