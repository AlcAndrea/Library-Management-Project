using System.DirectoryServices.ActiveDirectory;

namespace LibraryManagementPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Error. Please type something!");
            }

            else if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                Main form = new Main();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please enter correct details!");
            }
        }
    }
}