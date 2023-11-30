using Microsoft.EntityFrameworkCore;
using N75.Models.Entities;

namespace N75.DataContexts;

public class IdentityDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public DbSet<EmailNotificationEvent> EmailNotificationEvents => Set<EmailNotificationEvent>();

    public IdentityDbContext() : base(new DbContextOptionsBuilder<IdentityDbContext>()
        .UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=3325")
        .Options)
    {
    }

    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
    }
}
