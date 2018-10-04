using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework table class specifies storing product`s images
    /// </summary>
    public class ProductImage
    {
        /// <summary>
        /// Creates instance of ProductImage with selected fields
        /// </summary>
        public ProductImage(byte[] image, Guid productId)
        {
            Image = image;
            ProductId = productId;
        }

        /// <summary>
        /// Autoincrementing identity field as primary key
        /// </summary>
        [Key, Index(IsClustered = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Byte image presentation
        /// </summary>
        [Required]
        public byte[] Image { get; set; }

        /// <summary>
        /// Foreign key to product field
        /// </summary>
        [Required]
        public int ProductId { get; set; }

        /// <summary>
        /// Relation field many-to-one with table Product
        /// </summary>
        public virtual Headphone Product { get; set; }
    }
}
