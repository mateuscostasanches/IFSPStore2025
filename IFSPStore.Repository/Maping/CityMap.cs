
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Maping
{

    public class CityMap : IEntityTypeConfiguration<City>
    {

        #region Mapping
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(50);
            builder.Property(prop => prop.State).IsRequired().HasMaxLength(50);
        }
        #endregion 

    }

}
