using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework`s table class specifies country of manufacter
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Creates empty instance of Country
        /// </summary>
        public Country()
        {
            Manufacters = new HashSet<Company>();
            Users = new HashSet<User>();
        }

        /// <summary>
        /// Creates instance of Country with selected fields
        /// </summary>
        /// <param name="name">Country`s name</param>
        /// <param name="shortName">Sort coutry`s name with max size 4 symbols</param>
        /// <param name="worldPart">Country`s world part</param>
        public Country(string name, string shortName, WorldPart worldPart)
            : this()
        {
            Name = name;
            ShortName = shortName;
            WorldPart = worldPart;
        }

        /// <summary>
        /// Autoincrementing identity field as primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Country`s name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Short 4-symbol name
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Enum world part
        /// </summary>
        public WorldPart WorldPart { get; set; }

        /// <summary>
        /// Relation field many-to-one with table Manufacters
        /// </summary>
        public virtual ICollection<Company> Manufacters { get; set; }

        /// <summary>
        /// Relation field many-to-one with table Users
        /// </summary>
        public virtual ICollection<User> Users { get; set; }
    }

    public enum WorldPart
    {
        NorthAmerica,
        SouthAmerica,
        Europe,
        Asia,
        Africa
    }
}
