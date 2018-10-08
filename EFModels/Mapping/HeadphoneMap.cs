using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class HeadphoneMap : EntityTypeConfiguration<Headphone>
    {
        public HeadphoneMap()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Propereties

            Property(t => t.CableLength)
                .IsRequired()
                .HasColumnName("CableLength")
                .HasColumnOrder(6)
                .HasColumnType("double");

            Property(t => t.Colour)
                .IsRequired()
                .HasColumnName("Colour")
                .HasColumnOrder(5);

            Property(t => t.Description)
                .IsOptional()
                .HasMaxLength(400)
                .HasColumnName("Description")
                .HasColumnOrder(10)
                .HasColumnType("text");

            Property(t => t.FrequencyRangeFrom)
                .IsRequired()
                .HasColumnName("FrequencyRangeFrom")
                .HasColumnOrder(3)
                .HasColumnType("int");

            Property(t => t.FrequencyRangeTo)
                .IsRequired()
                .HasColumnName("FrequencyRangeTo")
                .HasColumnOrder(4)
                .HasColumnType("int");

            Property(t => t.HasActiveNoiseCancellation)
                .IsRequired()
                .HasColumnName("HasActiveNoiseCancellation")
                .HasColumnOrder(7)
                .HasColumnType("bool");

            Property(t => t.HasMicro)
                .IsRequired()
                .HasColumnName("HasMicro")
                .HasColumnOrder(8)
                .HasColumnType("bool");

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("int");

            Property(t => t.MountingType)
                .IsRequired()
                .HasColumnName("MountingType")
                .HasColumnOrder(9);

            Property(t => t.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnOrder(2)
                .HasColumnType("money");

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Title")
                .HasColumnOrder(1)
                .HasColumnType("varchar");

            #endregion

            #region Relations

            HasMany(t => t.OrderItems)
                .WithRequired(t => t.Headphone)
                .HasForeignKey(t => t.HeadphoneId);

            HasMany(t => t.Images)
                .WithRequired(t => t.Product)
                .HasForeignKey(t => t.ProductId);

            #endregion
        }
    }
}
