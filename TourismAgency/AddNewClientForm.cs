using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismAgency.Db;
using TourismAgency.Models;

namespace TourismAgency
{
    public partial class AddNewClientForm : Form
    {
        public AddNewClientForm()
        {
            InitializeComponent();
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(FirstNameTextBox.Text, LastNameTextBox.Text,
                    DateOfBirthDateTimePicker.Text, EmailTextBox.Text, PassportNumberTextBox.Text,
                    CitizenshipTextBox.Text, CityTextBox.Text, AdressTextBox.Text, PhoneNumberTextBox.Text);

                ClientRepository.CreateClient(client);

                DialogResult = DialogResult.OK;

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                DateOfBirthDateTimePicker.Value = DateOfBirthDateTimePicker.MinDate;
                EmailTextBox.Text = "";
                PassportNumberTextBox.Text = "";
                CitizenshipTextBox.Text = "";
                CityTextBox.Text = "";
                AdressTextBox.Text = "";
                PhoneNumberTextBox.Text = "";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InfoClientsForm info = new InfoClientsForm();
            this.Close();
            info.Show(); 
        }
    }
}
