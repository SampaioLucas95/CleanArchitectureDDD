using Microsoft.EntityFrameworkCore;
using SolutionName.Domain.Entities;
using SolutionName.Infrastructure.Data.Mapping;

namespace SolutionName.Infrastructure.Data.Context;

public class EntityframeworkContext : DbContext
{
    public EntityframeworkContext(DbContextOptions<EntityframeworkContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(new ClienteMap().Configure);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Cliente> Cliente { get; set; }
}