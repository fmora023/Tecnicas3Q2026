using ClassExampleController;
using ClassExampleModels;

namespace ClassExample
{
    /// <summary>
    /// Search contact information View.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchView : Form
    {
        private SearchController SearchController { get; set; }
        private List<User> UserContacts { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchView"/> class.
        /// </summary>
        /// <param name="searchController">The search controller.</param>
        public SearchView(SearchController searchController)
        {
            InitializeComponent();
            this.SearchController = searchController;
            this.UserContacts = this.SearchController.ContactList;
            this.LoadGrid();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var filterArgument = this.TxtFilter.Text;
            var result = this.SearchController.Filter(filterArgument);
            if (!result)
            {
                this.Refresh();
                if (!string.IsNullOrWhiteSpace(filterArgument))
                {
                    MessageBox.Show("No contacts found with the specified criteria.", "Search Result");
                }             
            }
            else
            {
                this.RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            this.UserContacts = this.SearchController.ContactList;
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            // name,lastName, email, number, username,birthDate,
            this.GrdSearchInformation.Columns.Clear();
            this.GrdSearchInformation.Rows.Clear();
            this.GrdSearchInformation.Columns.Add("Name", "Name");
            this.GrdSearchInformation.Columns.Add("LastName", "Lastname");
            this.GrdSearchInformation.Columns.Add("Email", "Email");
            this.GrdSearchInformation.Columns.Add("Number", "Number");
            this.GrdSearchInformation.Columns.Add("Username", "Username");
            this.GrdSearchInformation.Columns.Add("BirthDate", "BirthDate");

            foreach (var element in this.UserContacts)
            {
                this.GrdSearchInformation.Rows.Add(
                                element.Name,
                                element.LastName,
                                element.Email, 
                                element.Number,
                                element.Username,
                                element.BirthDate ?? DateTime.MinValue);

                // element.BirthDate ?? DateTime.MinValue
                // es equivalente a => 
                /* 
                 * if (element.BD != null)
                 * {
                 *      element.BD;
                 * }
                 * else
                 * {
                 *      DateTime.MinValue;
                 * }
                 * */
            }
        }
    }
}
