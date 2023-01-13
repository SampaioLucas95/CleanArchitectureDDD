using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SolutionName.Domain.Entities;
using Microsoft.Extensions.Options;

namespace SolutionName.Infrastructure.Context.Cotacao;

    public class EntityframeworkContext : DbContext
{
    public EntityframeworkContext(DbContextOptions<EntityframeworkContext> options) : base(options)
    {
  
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=dbCotacao; User Id=sa; Password=yourStrong(!)Password;TrustServerCertificate=True",
                     sqlServerOptionsAction: sqlOption =>
                         sqlOption.EnableRetryOnFailure(
                             maxRetryCount: 5,
                             maxRetryDelay: TimeSpan.FromSeconds(30),
                             errorNumbersToAdd: null));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

    public DbSet<Cliente> Cliente { get; set; }
} 