namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework table class specifies storing product`s images
    /// </summary>
    public class ProductImage
    {
        /// <summary>
        /// Creates empty instance of ProductImage
        /// </summary>
        public ProductImage()
        {
        }

        /// <summary>
        /// Creates instance of ProductImage with selected fields
        /// </summary>
        public ProductImage(byte[] image, int productId)
        {
            Image = image;
            ProductId = productId;
        }

        /// <summary>
        /// Autoincrementing identity field as primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Byte image presentation
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Foreign key to product field
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Relation field many-to-one with table Product
        /// </summary>
        public virtual Headphone Product { get; set; }
    }
}
