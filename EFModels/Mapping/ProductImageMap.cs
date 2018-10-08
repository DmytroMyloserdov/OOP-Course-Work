using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class ProductImageMap : EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMap()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Properties

            ToTable("ProductImages");

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("int");

            Property(t => t.Image)
                .IsRequired()
                .HasColumnName("Image")
                .HasColumnOrder(1)
                .HasColumnType("image");

            Property(t => t.ProductId)
                .IsRequired()
                .HasColumnName("ProductId")
                .HasColumnOrder(2)
                .HasColumnType("int");

            #endregion
        }
    }
}
