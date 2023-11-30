﻿using Microsoft.EntityFrameworkCore;
using N67.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace N67.Persistence.DataContexts;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Automatic registration of entity configuration - bu narsa hamma entity configuration larni registration qiladi
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Manual registration of entity configuration
        // modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}