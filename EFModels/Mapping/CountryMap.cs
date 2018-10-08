using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Propereties

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("int");

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Name")
                .HasColumnOrder(1)
                .HasColumnType("varchar");

            Property(t => t.ShortName)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("ShortName")
                .HasColumnOrder(2)
                .HasColumnType("varchar");

            Property(t => t.WorldPart)
                .IsRequired()
                .HasColumnName("WorldPart")
                .HasColumnOrder(4);

            #endregion

            #region Relations

            HasMany(t => t.Users)
                .WithOptional(t => t.Country)
                .HasForeignKey(t => t.CountryId);

            HasMany(t => t.Manufacters)
                .WithOptional(t => t.Country)
                .HasForeignKey(t => t.CountryId);

            #endregion
        }
    }
}
