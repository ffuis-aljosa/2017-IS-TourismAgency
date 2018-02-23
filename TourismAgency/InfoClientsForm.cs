using System;
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
            LoadClients();
            ClientsListView.FullRowSelect = true; 
        }

        private void ClientsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ClientsListView.Columns[e.ColumnIndex].Width;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourismAgencyForm = new AdminTourismAgencyForm();
            this.Close();
            adminTourismAgencyForm.Show(); 
        }

        public void LoadClients()
        {
            ClientsListView.Items.Clear();

            try
            {
                ClientRepository.ClientsToListView(ClientsListView, SearchTextBox.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientsListView_Click(object sender, EventArgs e)
        {
            string id = ClientsListView.SelectedItems[0].SubItems[0].Text;
            string firstName = ClientsListView.SelectedItems[0].SubItems[1].Text;
            string lastName = ClientsListView.SelectedItems[0].SubItems[2].Text;
            string dateOfBirth = ClientsListView.SelectedItems[0].SubItems[3].Text;
            string email = ClientsListView.SelectedItems[0].SubItems[4].Text;
            string passportNumber = ClientsListView.SelectedItems[0].SubItems[5].Text;
            string citizenship = ClientsListView.SelectedItems[0].SubItems[6].Text;
            string city = ClientsListView.SelectedItems[0].SubItems[7].Text;
            string adress = ClientsListView.SelectedItems[0].SubItems[8].Text;
            string phoneNumber = ClientsListView.SelectedItems[0].SubItems[9].Text;

            IdLabel.Text = id; 
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
            AddNewClientForm add = new AddNewClientForm();
            this.Hide();
            add.Show(); 
        }

        public void ClearAllBoxes()
        {
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(FirstNameTextBox.Text, LastNameTextBox.Text,
                    DateOfBirthDateTimePicker.Text, EmailTextBox.Text, PassportNumberTextBox.Text,
                    CitizenshipTextBox.Text, CityTextBox.Text, AdressTextBox.Text, PhoneNumberTextBox.Text);

                ClientRepository.UpdateClient(client, IdLabel.Text);

                ClientsListView.Items.Clear();
                MessageBox.Show("Successful updated", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadClients();

                ClearAllBoxes();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ClientsListView.Items.Clear();
            LoadClients();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Delete client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Client client = new Client(FirstNameTextBox.Text, LastNameTextBox.Text,
                    DateOfBirthDateTimePicker.Text, EmailTextBox.Text, PassportNumberTextBox.Text,
                    CitizenshipTextBox.Text, CityTextBox.Text, AdressTextBox.Text, PhoneNumberTextBox.Text);

                    ClientRepository.DeleteClient(client, IdLabel.Text);

                    ClientsListView.Items.Clear();

                    LoadClients();

                    ClearAllBoxes();
                }
                else
                {
                    ClientsListView.Items.Clear();

                    LoadClients();

                    ClearAllBoxes();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
