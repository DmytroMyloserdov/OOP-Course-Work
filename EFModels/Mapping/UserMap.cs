using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Properies

            ToTable("Users");

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");

            Property(t => t.CountryId)
                .IsRequired()
                .HasColumnName("CountryId")
                .HasColumnOrder(5)
                .HasColumnType("int");

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Email")
                .HasColumnOrder(3)
                .HasColumnType("varchar");

            Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("FirstName")
                .HasColumnOrder(1)
                .HasColumnType("varchar");

            Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("LastName")
                .HasColumnOrder(2)
                .HasColumnType("varchar");

            Property(t => t.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("PhoneNumber")
                .HasColumnOrder(4)
                .HasColumnType("varchar");

            #endregion

            #region Relations

            HasMany(t => t.Orders)
                .WithRequired(t => t.User)
                .HasForeignKey(t => t.UserId);

            #endregion
        }
    }
}
