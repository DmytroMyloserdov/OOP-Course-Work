using EFModels.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFModels.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            #region Primary key

            HasKey(t => t.Id);

            #endregion

            #region Propereties

            Property(t => t.CountryId)
                .IsRequired()
                .HasColumnName("CountryId")
                .HasColumnOrder(3)
                .HasColumnType("int");

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(0)
                .HasColumnType("int");

            Property(t => t.Logo)
                .IsRequired()
                .HasColumnName("Logo")
                .HasColumnOrder(2)
                .HasColumnType("image");

            Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnOrder(1)
                .HasColumnType("varchar");

            #endregion
        }
    }
}
