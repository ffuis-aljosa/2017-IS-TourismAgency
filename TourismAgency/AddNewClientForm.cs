using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db; 

namespace TourismAgency
{
    public partial class AddNewClientForm : Form
    {
        public AddNewClientForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); 
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
                    throw new Exception("Password and repeated password are not same!");

                Users user = new Users(FirstNameTextBox.Text, LastNameTextBox.Text, BirthDateTimePicker.Text, EmailTextBox.Text, PassportTextBox.Text, CountryTextBox.Text, CityTextBox.Text, AdressTextBox.Text, PhoneNumberTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text);
                user.Role = "client"; 

                UserRepository.CreateUser(user);

                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                RepeatPasswordTextBox.Text = "";
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextBox.Text = "";
                PassportTextBox.Text = "";
                CountryTextBox.Text = "";
                CityTextBox.Text = "";
                AdressTextBox.Text = "";
                PhoneNumberTextBox.Text = "";

                MessageBox.Show("Client is created succesfully!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
    
}
