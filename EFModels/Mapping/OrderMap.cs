using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Prpereties

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");

            Property(t => t.TotalPrice)
                .IsRequired()
                .HasColumnName("TotalPrice")
                .HasColumnOrder(1)
                .HasColumnType("money");

            Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .HasColumnOrder(2)
                .HasColumnType("uniqueidentifier");

            #endregion

            #region Relations

            HasMany(t => t.OrderItems)
                .WithRequired(t => t.Order)
                .HasForeignKey(t => t.OrderId);

            #endregion
        }
    }
}
