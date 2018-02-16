using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db;

namespace TourismAgency
{
    public partial class AddNewAdminForm : Form
    {
        public AddNewAdminForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourismAgency = new AdminTourismAgencyForm(); 
            this.Close();
            adminTourismAgency.Show(); 
        }

        private void CreateAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
                    throw new Exception("Password and repeated password are not same!");

                Users user = new Users(UsernameTextBox.Text, PasswordTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text);
                user.Role = "admin";

                UserRepository.CreateAdmin(user);

                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                RepeatPasswordTextBox.Text = "";
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";

                MessageBox.Show("Admin is created succesfully!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
