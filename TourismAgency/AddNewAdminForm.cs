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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreateAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
                    throw new Exception("Password and repeated password are not same!");

                User user = new User(UsernameTextBox.Text, PasswordTextBox.Text);

                UserRepository.CreateAdmin(user);
                DialogResult = DialogResult.OK;

                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                RepeatPasswordTextBox.Text = "";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
