﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework`s table class specifies user`s info 
    /// </summary>
    public class User
    {
        /// <summary>
        /// Creates empty instance of User
        /// </summary>
        public User()
        {
            Orders = new HashSet<Order>();
        }

        /// <summary>
        /// Creates instance of User with selected fields 
        /// </summary>
        /// <param name="fistName">User`s first name</param>
        /// <param name="lastName">User`s last name</param>
        /// <param name="email">User`s email</param>
        /// <param name="phoneNumber">User`s phone number, default is null</param>
        public User(string firstName, string lastName, string email, string phoneNumber = null)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Guid identity field as primary key
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// User`s first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User`s last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Unique email field
        /// </summary>
        [Index(IsUnique = true)]
        public string Email { get; set; }

        /// <summary>
        /// User`s phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Foreign key to country field
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Relation filed many-to-one with table Countries
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Relation field many-to-many with table Orders
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}
