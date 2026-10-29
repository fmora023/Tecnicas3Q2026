namespace ClassExampleModels
{
    /// <summary>
    /// Class to represent the user's contacts, which can be used to store the user's friends and family members.
    /// </summary>
    public class Contact : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="number">The number.</param>
        /// <param name="direction">The direction.</param>
        public Contact(string id, string name, string lastName, string email, string number, string direction)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Number = new Number(number);
            this.Direction = direction;
        }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the adition date.
        /// </summary>
        /// <value>
        /// The adition date.
        /// </value>
        public DateTime AditionDate { get; set; } = DateTime.Now;
    }
}
