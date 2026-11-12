using ClassExampleModels;

namespace ClassExampleController
{
    /// <summary>
    /// Controller for search operations.
    /// </summary>
    public class SearchController
    {
        private InformationService InformationService { get; set; }

        /// <summary>
        /// Gets or sets the contact list.
        /// </summary>
        /// <value>
        /// The contact list.
        /// </value>
        public List<User> ContactList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchController"/> class.
        /// </summary>
        /// <param name="informationService">The information service.</param>
        public SearchController(InformationService informationService)
        {
            this.InformationService = informationService;
            this.ContactList = LoadContacts();
        }

        /// <summary>
        /// Filters the specified filter argument.
        /// </summary>
        /// <param name="filterArgument">The filter argument.</param>
        /// <returns>True if there are contacts into the criteria; otherwise, false.</returns>
        public bool Filter(string filterArgument)
        {
            if (string.IsNullOrWhiteSpace(filterArgument))
            {
                this.ContactList = LoadContacts();
                return false;
            }

            var fullContactList = new List<User>();
            fullContactList.AddRange(this.ContactList);

            this.ContactList.Clear();
            foreach (var contact in fullContactList)
            {
                if (contact.Username.Contains(filterArgument, StringComparison.OrdinalIgnoreCase) ||
                    contact.Name.Contains(filterArgument, StringComparison.OrdinalIgnoreCase) ||
                    contact.LastName.Contains(filterArgument, StringComparison.OrdinalIgnoreCase))
                {
                    this.ContactList.Add(contact);
                }
            }

            if (this.ContactList.Count == 0)
            {
                this.ContactList = fullContactList;
                return false;
            }

            return true; 
        }

        private List<User> LoadContacts()
        {
            var result = new List<User>();

            foreach(var contact in this.InformationService.CurrentUser!.Contacts)
            {
                result.Add(this.InformationService.Users[contact]);
            }

            return result;
        }
    }
}
