namespace EFModels.Entities
{
    /// <summary>
    /// Entity Framework`s table class specifies company`s info
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Creates empty instance of Company
        /// </summary>
        public Company()
        {

        }

        /// <summary>
        /// Creates instance of Company with selected fields
        /// </summary>
        /// <param name="name">Company`s name</param>
        /// <param name="countryId">Country`s identifer</param>
        /// <param name="logo">Logo`s byte presentation</param>
        public Company(string name, int countryId, byte[] logo)
        {
            Name = name;
            CountryId = countryId;
            Logo = logo;
        }

        /// <summary>
        /// Autoincrementing identity field as primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Company`s name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Foreign key to country field
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Realtion field many-to-one with table Country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Logo`s byte presentation
        /// </summary>
        public byte[] Logo { get; set; }
    }
}
