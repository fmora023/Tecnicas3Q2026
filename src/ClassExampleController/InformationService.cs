using ClassExampleController.Abstractions;
using ClassExampleModels;

namespace ClassExampleController
{
    /// <summary>
    /// Service for handling the information.
    /// </summary>
    public class InformationService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationService"/> class.
        /// </summary>
        /// <param name="userDataHandler">The user data handler.</param>
        public InformationService(IDataHandler<User> userDataHandler)
        {
            this.UserDataHandler = userDataHandler;
            this.Users = this.UserDataHandler.LoadData(Configuration.UsersFilePath);
        }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>
        /// The contacts.
        /// </value>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Gets or sets the current user. Once logged in, here'll be stored the curent user information.
        /// </summary>
        /// <value>
        /// The current user.
        /// </value>
        public User? CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets the data handler.
        /// </summary>
        /// <value>
        /// The data handler.
        /// </value>
        public IDataHandler<User> UserDataHandler { get; set; }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public List<User> Users { get; set; }
    }
}
