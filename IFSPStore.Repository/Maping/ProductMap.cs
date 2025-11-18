using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Maping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
    
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(100);
            builder.Property(prop => prop.Price);
            builder.Property(prop => prop.Quantity);
            builder.Property(prop => prop.SalesUnity).HasMaxLength(10);
            builder.HasOne(prop => prop.Category); //Relacionamento
        }
    }
}
