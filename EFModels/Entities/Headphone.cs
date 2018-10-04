using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework table class specifies product info
    /// </summary>
    public class Headphone
    {
        /// <summary>
        /// Creates empty instance of Product
        /// </summary>
        public Headphone()
        {
            Images = new HashSet<ProductImage>();
            OrderItems = new HashSet<OrderItem>();
        }

        /// <summary>
        /// Autoincrementing identity field as primary key
        /// </summary>
        [Key, Index(IsClustered = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Product`s title
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// Optional description
        /// </summary>
        [StringLength(400)]
        public string Description { get; set; }

        /// <summary>
        /// Product`s price in USD
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Product`s main colour
        /// </summary>
        [Required]
        public Colour Colour { get; set; }

        /// <summary>
        /// Product`s cable length in meters
        /// </summary>
        [Required]
        public double CableLength { get; set; }

        /// <summary>
        /// Does product have microphone
        /// </summary>
        [Required]
        public bool HasMicro { get; set; }

        /// <summary>
        /// Foreign key to microphone feild if headphone has one
        /// </summary>
        public int? MicroId { get; set; }

        /// <summary>
        /// Relation filed many-to-one with table Microphone
        /// </summary>
        public virtual Microphone Microphone { get; set; }

        /// <summary>
        /// Relation filed one-to-many with table ProductImages
        /// </summary>
        public virtual ICollection<ProductImage> Images { get; set; }

        /// <summary>
        /// Relation filed one-to-many with table ProductImages
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

    [Flags]
    public enum Colour
    {
        White,
        Black,
        Red,
        Blue,
        Yellow,
        Green,
        Grey,
        Light,
        Dark
    }
}
