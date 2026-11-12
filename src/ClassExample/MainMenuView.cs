using ClassExampleController;

namespace ClassExample
{
    /// <summary>
    /// Main Menu View.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainMenuView : Form
    {
        private InformationService InformationService { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainMenuView"/> class.
        /// </summary>
        /// <param name="informationService">The information service.</param>
        public MainMenuView(InformationService informationService)
        {
            this.InformationService = informationService;
            InitializeComponent();
            this.InitializeMessages();
        }

        private void InitializeMessages()
        {
            if (this.InformationService.CurrentUser != null)
            {
                this.LblWelcome.Text = $"Welcome, {this.InformationService.CurrentUser.Username}!";
                this.LblInfo.Text = $"{this.InformationService.CurrentUser.Name} {Environment.NewLine}" +
                    $"{this.InformationService.CurrentUser.LastName}, {Environment.NewLine}" +
                    $"{this.InformationService.CurrentUser.Number} {Environment.NewLine}";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchController = new SearchController(this.InformationService);
            var searchView = new SearchView(searchController);
            searchView.Show();
        }
    }
}
