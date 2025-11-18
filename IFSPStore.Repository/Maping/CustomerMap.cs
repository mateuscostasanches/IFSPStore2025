using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Maping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Document).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Address).IsRequired().HasMaxLength(100);
            builder.Property(p => p.District).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.City);
        }
    }
}
