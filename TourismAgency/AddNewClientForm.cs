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

        private void PhoneNumberTextBox_Click(object sender, EventArgs e)
        {
            PhoneNumberTextBox.Text = "+387";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(FirstNameTextBox.Text, LastNameTextBox.Text, BirthDateTimePicker.Text, EmailTextBox.Text, PassportTextBox.Text, CitizenshipTextBox.Text, CityTextBox.Text, AdressTextBox.Text, PhoneNumberTextBox.Text);

                ClientRepository.CreateUser(client);
                
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextBox.Text = "";
                PassportTextBox.Text = "";
                CitizenshipTextBox.Text = "";
                CityTextBox.Text = "";
                AdressTextBox.Text = "";
                PhoneNumberTextBox.Text = "+387";

                MessageBox.Show("Client is created succesfully!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminTourismAgencyForm adminForm = new AdminTourismAgencyForm();
            adminForm.Show();
        }
    }
    
}
