using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SolutionName.Domain.Entities;
using Microsoft.Extensions.Options;

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

    }

    public DbSet<Cliente> Cliente { get; set; }
}