using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModels.Entities
{
    /// <summary>
    /// Entite Framework table class specifies linking order with products
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Creaties empty instance of OrderItem
        /// </summary>
        public OrderItem()
        {
        }

        /// <summary>
        /// Creates instance of OrderItem with selected fields
        /// </summary>
        /// <param name="headphoneId">Foreign key to headphone field</param>
        /// <param name="orderId">Foreign key to Order field</param>
        /// <param name="itemAmount">Amount of selected headphone in order</param>
        public OrderItem(int headphoneId, Guid orderId, int itemAmount)
        {
            HeadphoneId = headphoneId;
            OrderId = orderId;
            ItemAmount = itemAmount;
        }

        /// <summary>
        /// Guid identity field as primary key
        /// </summary>
        [Key, Index(IsClustered = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key to headphone field
        /// </summary>
        [Required]
        public int HeadphoneId { get; set; }

        /// <summary>
        /// Relation field many-to-one with table Headphone
        /// </summary>
        public virtual Headphone Headphone { get; set; }

        /// <summary>
        /// Foreign key to order field
        /// </summary>
        [Required]
        public Guid OrderId { get; set; }

        /// <summary>
        /// Relation field many-to-one with table Order
        /// </summary>
        public virtual Order Order { get; set; }

        /// <summary>
        /// Amount of selected headphone in order
        /// </summary>
        [Required]
        public int ItemAmount { get; set; }
    }
}
