using Microsoft.EntityFrameworkCore;
using N67.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace N67.Persistence.DataContexts;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public DbSet<Course> Courses => Set<Course>();

    public DbSet<CourseStudent> StudentCourses => Set<CourseStudent>();

    public DbSet<Role> Roles => Set<Role>();

    public DbSet<Location> Locations => Set<Location>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}