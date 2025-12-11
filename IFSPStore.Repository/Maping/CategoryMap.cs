
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Maping
{

    public class CategoryMap : IEntityTypeConfiguration<Category>
    {

        #region Mapping
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(50);
        }
        #endregion 

    }

}
