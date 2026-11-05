using ClassExampleController;
using System.ComponentModel;

namespace ClassExample
{
    /// <summary>
    /// Login View.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginView : Form
    {
        /// <summary>
        /// Gets or sets the login controller.
        /// </summary>
        /// <value>
        /// The login controller.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LoginController LoginController { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginView"/> class.
        /// </summary>
        /// <param name="loginController">The login controller.</param>
        public LoginView(LoginController loginController)
        {
            this.LoginController = loginController;
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = this.TxtUser.Text;
            var password = this.TxtPassword.Text;
            var result = this.LoginController.Login(username, password);

            if (result)
            {
                // de momento nada
                MessageBox.Show("Exito!!.", "Login Success");
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed");
            }
        }
    }
}
