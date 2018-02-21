﻿using System;
using System.Windows.Forms;
using TourismAgency.Db;
using TourismAgency.Models;

namespace TourismAgency
{
    public partial class InfoClientsForm : Form
    {
        public InfoClientsForm()
        {
            InitializeComponent();
            ClientRepository.LoadClients(ClientsListView, SearchTextBox);
            ClientsListView.FullRowSelect = true; 
        }

        private void UsersListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ClientsListView.Columns[e.ColumnIndex].Width;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourismAgencyForm = new AdminTourismAgencyForm();
            this.Hide();
            adminTourismAgencyForm.Show(); 
        }

        private void ClientsListView_Click(object sender, EventArgs e)
        {
                string firstName = ClientsListView.SelectedItems[0].SubItems[0].Text;
                string lastName = ClientsListView.SelectedItems[0].SubItems[1].Text;
                string dateOfBirth = ClientsListView.SelectedItems[0].SubItems[2].Text;
                string email = ClientsListView.SelectedItems[0].SubItems[3].Text;
                string passportNumber = ClientsListView.SelectedItems[0].SubItems[4].Text;
                string citizenship = ClientsListView.SelectedItems[0].SubItems[5].Text;
                string city = ClientsListView.SelectedItems[0].SubItems[6].Text;
                string adress = ClientsListView.SelectedItems[0].SubItems[7].Text;
                string phoneNumber = ClientsListView.SelectedItems[0].SubItems[8].Text;

                FirstNameTextBox.Text = firstName;
                LastNameTextBox.Text = lastName;
                DateOfBirthDateTimePicker.Text = dateOfBirth;
                EmailTextBox.Text = email;
                PassportNumberTextBox.Text = passportNumber;
                CitizenshipTextBox.Text = citizenship;
                CityTextBox.Text = city;
                AdressTextBox.Text = adress;
                PhoneNumberTextBox.Text = phoneNumber; 
        }

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            try
            {

                Client guide = new Client (FirstNameTextBox.Text, LastNameTextBox.Text, 
                    DateOfBirthDateTimePicker.Text, EmailTextBox.Text, PassportNumberTextBox.Text, 
                    CitizenshipTextBox.Text, CityTextBox.Text, AdressTextBox.Text, PhoneNumberTextBox.Text);

                ClientRepository.CreateClient(guide);

                DialogResult = DialogResult.OK;
                ClientRepository.LoadClients(ClientsListView, SearchTextBox);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
