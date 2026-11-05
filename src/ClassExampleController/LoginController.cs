namespace ClassExampleController
{
    /// <summary>
    /// Controller for Login operations.
    /// </summary>
    public class LoginController
    {
        /// <summary>
        /// Gets or sets the information service.
        /// </summary>
        /// <value>
        /// The information service.
        /// </value>
        public InformationService InformationService { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="informationService">The information service.</param>
        public LoginController(InformationService informationService)
        {
            this.InformationService = informationService;
        }

        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>true if login is successful, otherwise false.</returns>
        public bool Login(string username, string password)
        {
            // validar los datos user y pass
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            foreach(var element in this.InformationService.Users)
            {
                if ((element.Username == username || element.Email == username) && element.Password == password)
                {
                    this.InformationService.CurrentUser = element;
                    return true;
                }
            }

            return false;
        }
    }
}
