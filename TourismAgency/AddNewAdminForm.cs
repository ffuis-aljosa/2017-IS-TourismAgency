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
            PasswordTextBox.UseSystemPasswordChar = true;
            RepeatPasswordTextBox.UseSystemPasswordChar = true; 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            UsersInfoForm usersInfoForm = new UsersInfoForm();
            this.Hide();
            usersInfoForm.Show();
             
        }

        private void CreateAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
                    throw new Exception("Password and repeated password are not same!");

                User user = new User(UsernameTextBox.Text, PasswordTextBox.Text);

                UserRepository.CreateAdmin(user);

                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                RepeatPasswordTextBox.Text = "";

                MessageBox.Show("Admin is created succesfully!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
