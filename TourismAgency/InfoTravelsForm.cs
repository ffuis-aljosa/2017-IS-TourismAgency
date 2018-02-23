using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db;
using System.Collections.Generic;

namespace TourismAgency
{
    public partial class InfoTravelsForm : Form
    {
        public InfoTravelsForm()
        {
            InitializeComponent();
            StartDateTimePicker.MinDate = DateTime.Now;
            LoadTravels();
            LoadGuides();
            TravelsListView.FullRowSelect = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminForm = new AdminTourismAgencyForm();
            this.Close();
            adminForm.Show();
        }

        private void LoadGuides()
        {
            List<Guide> guides = GuideRepository.FetchAllGuides();

            foreach (Guide guide in guides)
                GuideComboBox.Items.Add(guide);
        }

        private void LoadTravels()
        {
            TravelsListView.Items.Clear();

            try
            {
                TravelRepository.TravelsToListView(TravelsListView, SearchTextBox.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewTravelButton_Click(object sender, EventArgs e)
        {
            AddNewTravelForm addNewTravel = new AddNewTravelForm();
            this.Hide();
            addNewTravel.Show(); 
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FinishDateTimePicker.MinDate = StartDateTimePicker.Value;
        }

        public void ClearAllBoxes()
        {
            DestinationsTextBox.Text = "";
            StartDateTimePicker.Value = StartDateTimePicker.MinDate;
            FinishDateTimePicker.Value = FinishDateTimePicker.MinDate;
            
            Number_Of_SeatsComboBox.Text = "";
            PriceTextBox.Text = "";
        }

        private void TravelsListView_Click(object sender, EventArgs e)
        {
            string id = TravelsListView.SelectedItems[0].SubItems[0].Text;
            string destinations = TravelsListView.SelectedItems[0].SubItems[1].Text;
            string startDate = TravelsListView.SelectedItems[0].SubItems[2].Text;
            string finishDate = TravelsListView.SelectedItems[0].SubItems[3].Text;
            string guide = TravelsListView.SelectedItems[0].SubItems[4].Text;
            string numberOfSeats = TravelsListView.SelectedItems[0].SubItems[5].Text;
            string price = TravelsListView.SelectedItems[0].SubItems[6].Text;

            IdLabel.Text = id; 
            DestinationsTextBox.Text = destinations;
            StartDateTimePicker.Text = startDate;
            FinishDateTimePicker.Text = finishDate;
            Number_Of_SeatsComboBox.SelectedItem = numberOfSeats;
            GuideComboBox.SelectedItem = guide;
            PriceTextBox.Text = price;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Travel travel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text, 
                    FinishDateTimePicker.Text, Number_Of_SeatsComboBox.Text, (Guide)GuideComboBox.SelectedItem,
                    PriceTextBox.Text);

                TravelRepository.UpdateTravel(travel, IdLabel.Text);

                TravelsListView.Items.Clear();

                MessageBox.Show("Successful updated", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTravels();

                ClearAllBoxes();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TravelsListView.Items.Clear();
            LoadTravels();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to delete this travel?", "Delete travel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                Travel travel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text,
                    FinishDateTimePicker.Text, Number_Of_SeatsComboBox.Text, (Guide)GuideComboBox.SelectedItem,
                    PriceTextBox.Text);

                TravelRepository.DeleteTravel(travel, IdLabel.Text);

                TravelsListView.Items.Clear();

                LoadTravels();

                ClearAllBoxes();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

 }
