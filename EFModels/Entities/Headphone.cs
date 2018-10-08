using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework table class specifies headphone info
    /// </summary>
    public class Headphone
    {
        /// <summary>
        /// Creates empty instance of Headphone
        /// </summary>
        public Headphone()
        {
            Images = new HashSet<ProductImage>();
            OrderItems = new HashSet<OrderItem>();
        }

        /// <summary>
        /// Creates instance of Headphone with selected fields
        /// </summary>
        /// <param name="title">Headphone`s title</param>
        /// <param name="price"></param>
        /// <param name="colour">Headphone`s main colour</param>
        /// <param name="frequencyRangeFrom">Frequency range of headphone from in Hz</param>
        /// <param name="frequencyRangeTo">Frequency range of headphone to in Hz</param>
        /// <param name="hasActiveNoiseCancellation">Does headphone has active noise cancelation</param>
        /// <param name="cableLength">Headphone`s cable length in meters</param>
        /// <param name="hasMicro">Does headphone have microphone</param>
        /// <param name="microId">Describes mounting type of microphone, as default has null</param>
        /// <param name="description">Optional description, as default has null</param>
        public Headphone(
            string title,
            decimal price,
            Colour colour,
            int frequencyRangeFrom,
            int frequencyRangeTo,
            bool hasActiveNoiseCancellation,
            double cableLength,
            bool hasMicro,
            MountingType? mountingType = null,
            string description = null
            )
            : this()
        {
            Title = title;
            Description = description;
            Price = price;
            Colour = colour;
            FrequencyRangeFrom = frequencyRangeFrom;
            FrequencyRangeTo = frequencyRangeTo;
            HasActiveNoiseCancellation = hasActiveNoiseCancellation;
            CableLength = cableLength;
            HasMicro = hasMicro;
            MountingType = mountingType;
        }

        /// <summary>
        /// Autoincrementing identity field as primary key
        /// </summary>
        [Key, Index(IsClustered = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Headphone`s title
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
        /// Headphone`s price in USD
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Headphone`s main colour
        /// </summary>
        [Required]
        public Colour Colour { get; set; }

        /// <summary>
        /// Frequency range of headphone from in Hz
        /// </summary>
        [Required]
        public int FrequencyRangeFrom { get; set; }

        /// <summary>
        /// Frequency range of headphone to in Hz
        /// </summary>
        [Required]
        public int FrequencyRangeTo { get; set; }

        /// <summary>
        /// Does headphone has active noise cancelation
        /// </summary>
        [Required]
        public bool HasActiveNoiseCancellation { get; set; }

        /// <summary>
        /// Headphone`s cable length in meters
        /// </summary>
        [Required]
        public double CableLength { get; set; }

        /// <summary>
        /// Does headphone have microphone
        /// </summary>
        [Required]
        public bool HasMicro { get; set; }

        /// <summary>
        /// Describes mounting type of microphone
        /// </summary>
        public MountingType? MountingType { get; set; }

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

    public enum MountingType
    {
        Static,
        Pullout,
        Builtin
    }
}
