using System.Xml.Linq;

namespace ClassExampleModels
{
    /// <summary>
    /// Class to represent the principal user of the application.
    /// </summary>
    public class User : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="number">The number.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="birthDate">The birth date.</param>
        public User(string id, string name, string lastName, string email, string number, string username, string password, string birthDate, string contacts)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.BirthDate = DateTime.Parse(birthDate);
            this.Number = new Number(number);
            this.Contacts = ProccessContactSring(contacts)!;
        }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username{ get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password{ get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>
        /// The contacts.
        /// </value>
        public List<int> Contacts { get; set; }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// Return 0 if the birth date is not set.
        /// </value>
        public int Age
        {
            get
            {
                if (BirthDate.HasValue)
                {
                    var today = DateTime.Today;
                    var age = today.Year - BirthDate.Value.Year;
                    if (BirthDate.Value.Date > today.AddYears(-age)) 
                    {
                        age--;
                    }
                    return age;
                }
                else
                {
                    return 0;
                }
            }
        }

        private static List<int>? ProccessContactSring(string contacts)
        {
            if (string.IsNullOrWhiteSpace(contacts))
            {
                return new List<int>();
            }
            
            var result = new List<int>();

            var cleanContact = contacts.Substring(1, contacts.Length - 2);
            var contactList = cleanContact.Split(';');

            foreach (var contact in contactList)
            {
                if (int.TryParse(contact, out int contactId))
                {
                    result.Add(contactId);
                }
            }

            return result;
        }
    }
}
