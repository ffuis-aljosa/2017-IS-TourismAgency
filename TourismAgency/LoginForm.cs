using System;
using System.Windows.Forms;
using TourismAgency.Db;
using TourismAgency.Models;

namespace TourismAgency
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true; 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientTourismAgencyForm client = new ClientTourismAgencyForm();
            client.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(UsernameTextBox.Text, PasswordTextBox.Text);

                if (UserRepository.login(user) != null)
                {
                        AdminTourismAgencyForm adminTourismAgencyForm = new AdminTourismAgencyForm();
                        adminTourismAgencyForm.Show();
                        adminTourismAgencyForm.FormClosed += TourismAgencyForm_FormClosed;
                       
                        Hide();
                }
                else
                {
                    throw new Exception("Incorrect username or password!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void TourismAgencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
