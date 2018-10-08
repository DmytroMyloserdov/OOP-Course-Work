using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class OrderItemMapping : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMapping()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Propereties

            ToTable("OrderItems");

            Property(t => t.HeadphoneId)
                .IsRequired()
                .HasColumnName("HeadphoneId")
                .HasColumnOrder(3)
                .HasColumnType("int");

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");

            Property(t => t.ItemAmount)
                .IsRequired()
                .HasColumnName("ItemAmount")
                .HasColumnOrder(2)
                .HasColumnType("int");

            Property(t => t.OrderId)
                .IsRequired()
                .HasColumnName("OrderId")
                .HasColumnOrder(1)
                .HasColumnType("uniqueidentifier");

            #endregion
        }
    }
}
