using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismAgency
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TourismAgencyForm adminForm = new TourismAgencyForm();
            adminForm.Show(); 
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = ""; 
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text = "";
        }

        private void PassportTextBox_Click(object sender, EventArgs e)
        {
            PassportTextBox.Text = ""; 
        }

        private void CityTextBox_Click(object sender, EventArgs e)
        {
            CityTextBox.Text = ""; 
        }

        private void CountryTextBox_Click(object sender, EventArgs e)
        {
            CountryTextBox.Text = ""; 
        }

        private void TelephoneNumberTextBox_Click(object sender, EventArgs e)
        {
            TelephoneNumberTextBox.Text = ""; 
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = ""; 
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PassportTextBox.Text = ""; 
        }

        private void RepeatPasswordTextBox_Click(object sender, EventArgs e)
        {
            RepeatPasswordTextBox.Text = ""; 
        }
    }
}
