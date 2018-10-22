using System;
using System.Collections.Generic;

namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework`s table class specifies order`s info
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Creates empty instance of Order
        /// </summary>
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        /// <summary>
        /// Creates instance of Order without total price 
        /// </summary>
        /// <param name="userId">Foreign key to user field</param>
        public Order(Guid userId)
            : this()
        {
            UserId = userId;
        }

        /// <summary>
        /// CReates instance of User with selected fields
        /// </summary>
        /// <param name="userId">Foreign key to user field</param>
        /// <param name="totalPrice">Total order price from its order items</param>
        public Order(Guid userId, decimal totalPrice)
            : this(userId)
        {
            TotalPrice = totalPrice;
        }

        /// <summary>
        /// Guid identity field as primary key
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key to user field
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Realtion field many-to-one with table User
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Total order price from its order items
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Realtion field one-to-many with table OrderItems
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
