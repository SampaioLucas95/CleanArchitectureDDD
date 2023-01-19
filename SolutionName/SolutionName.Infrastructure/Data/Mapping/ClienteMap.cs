using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolutionName.Domain.Entities;

namespace SolutionName.Infrastructure.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> modelBiulder)
        {
            modelBiulder.ToTable("Cliente");

            modelBiulder.HasKey(x => x.Id);
            modelBiulder.Property(x => x.Id).HasColumnType("uniqueidentifier").ValueGeneratedOnAdd();
            modelBiulder.Property(x => x.Nome).HasColumnType("varchar(80)").HasMaxLength(60).IsRequired();
            modelBiulder.Property(x => x.Email).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();
            modelBiulder.Property(x => x.MultiplicadorBase).HasColumnType("decimal(6,5)").IsRequired();
        }
    }
}
