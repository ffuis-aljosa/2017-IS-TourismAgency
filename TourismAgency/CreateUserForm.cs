﻿using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db; 

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
            AdminTourismAgencyForm adminForm = new AdminTourismAgencyForm();
            adminForm.Show(); 
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
                    throw new Exception("Password and repeated password are not same!");

                Users user = new Users(UsernameTextBox.Text, PasswordTextBox.Text, RoleComboBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, BirthDateTimePicker.Value.Date, EmailTextBox.Text, PassportTextBox.Text, CountryTextBox.Text, CityTextBox.Text, AdressTextBox.Text, Convert.ToInt16(PhoneNumberTextBox));

                UserRepository.createUser(user);

                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                RepeatPasswordTextBox.Text = "";
                RoleComboBox.Text = "";
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextBox.Text = "";
                PassportTextBox.Text = "";
                CountryTextBox.Text = "";
                CityTextBox.Text = "";
                AdressTextBox.Text = "";
                PhoneNumberTextBox.Text = "";

                MessageBox.Show("User is created succesfully!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
    
}
