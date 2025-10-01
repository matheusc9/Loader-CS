using LoaderC_.Properties;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoaderC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputUser.Text = Properties.Settings.Default.username;
            inputPass.Text = Properties.Settings.Default.password;
            rememberMe.Checked = Properties.Settings.Default.rememberMe;

            // CENTERING ELEMENTS:
            // Header elements
            center(title);
            center(subtitleLabel);
            // Login elements
            center(inputUser, true, false);
            center(inputPass, true, false);
            center(loginBtn, true, false);

        }

        private void center(Control c, bool x = true, bool y = false)
        {
            if (x)
            {
                c.Left = (this.ClientSize.Width - c.Width) / 2;
            }
            else
            {
                c.Top = (this.ClientSize.Height - c.Height) / 2;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = inputUser.Text;
            string password = inputPass.Text;

            if (username == "adm" && password == "123")
            {
                if (rememberMe.Checked)
                {
                    Properties.Settings.Default.username = username;
                    Properties.Settings.Default.password = password;
                    Properties.Settings.Default.rememberMe = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.password = "";
                    Properties.Settings.Default.rememberMe = false;
                }

                checkLogin(username, password);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void checkLogin(string username, string password)
        {
            loadscreen loadscreen = new("Checking...", 2);
            loadscreen.Show();
            this.Hide();

            await Task.Delay(1000);

            Launcher launcher = new(username);
            launcher.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
            this.Close();
            Environment.Exit(0 );
            Application.Exit();
        }
    }
}