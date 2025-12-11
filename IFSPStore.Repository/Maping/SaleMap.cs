
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Maping
{

    internal class SaleMap : IEntityTypeConfiguration<Sale>
    {

        #region Mapping
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.SaleDate);
            builder.Property(prop => prop.SaleTotal);
            builder.HasOne(prop => prop.Customer);
            builder.HasOne(prop => prop.Salesman);
            builder.HasMany(prop => prop.SaleItems).WithOne(prop => prop.Sale).OnDelete(DeleteBehavior.Cascade);
        }
        #endregion 

    }

    internal class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {

        #region Mapping
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItem");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Quantity);
            builder.Property(prop => prop.UnitPrice);
            builder.Property(prop => prop.TotalPrice);
            builder.HasOne(prop => prop.Product);
            builder.HasOne(prop => prop.Sale).WithMany(prop => prop.SaleItems).OnDelete(DeleteBehavior.Cascade);
        }
        #endregion

    }

}
