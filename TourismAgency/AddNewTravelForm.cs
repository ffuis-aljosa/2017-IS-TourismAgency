using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db;
using System.Data.SqlServerCe;

namespace TourismAgency
{
    public partial class AddNewTravelForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public AddNewTravelForm()
        {
            InitializeComponent();
            StartDateTimePicker.MinDate = DateTime.Now;
            FinishDateTimePicker.MinDate = DateTime.Now;
            loadTravels();        
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            TravelsInfoForm travelsInfoForm = new TravelsInfoForm();
            this.Hide();
            travelsInfoForm.Show();
        }

        private void CreateTravelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Travels travel = new Travels(DestinationsTextBox.Text, StartDateTimePicker.Text, FinishDateTimePicker.Text,  BusAndNumber_Of_SeatsComboBox.Text, GuideComboBox.Text, PriceTextBox.Text);
            
                TravelRepository.CreateTravel(travel);

                DestinationsTextBox.Text = "";
                GuideComboBox.ResetText();
                BusAndNumber_Of_SeatsComboBox.Text = "";
                PriceTextBox.Text = "";

                MessageBox.Show("Travel is created succesfully!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadTravels()
        {
            TravelsListView.Items.Clear();

            string sql = @"SELECT id, destinations, start_date, finish_date, guide, number_of_seats,
                price FROM travels";

            SqlCeCommand command = new SqlCeCommand(sql, connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["destinations"].ToString());
                    item.SubItems.Add(reader["start_date"].ToString());
                    item.SubItems.Add(reader["finish_date"].ToString());
                    item.SubItems.Add(reader["guide"].ToString());
                    item.SubItems.Add(reader["number_of_seats"].ToString());
                    item.SubItems.Add(reader["price"].ToString());

                    TravelsListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

 }
