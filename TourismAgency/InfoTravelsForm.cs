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
            FinishDateTimePicker.MinDate = DateTime.Now;
            TravelRepository.LoadTravels(TravelsListView);
            loadGuides();
            TravelsListView.FullRowSelect = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminForm = new AdminTourismAgencyForm();
            this.Hide();
            adminForm.Show();
        }

        private void loadGuides()
        {
            List<Guide> guides = GuideRepository.FetchAllGuides();

            foreach (Guide guide in guides)
                GuideComboBox.Items.Add(guide);
        }

        private void CreateTravelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Travel travel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text, FinishDateTimePicker.Text, Number_Of_SeatsComboBox.Text, (Guide)GuideComboBox.SelectedItem, PriceTextBox.Text);

                TravelRepository.CreateTravel(travel);

                DestinationsTextBox.Text = "";
                GuideComboBox.ResetText();
                Number_Of_SeatsComboBox.Text = "";
                PriceTextBox.Text = "";

                MessageBox.Show("Travel is created succesfully!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TravelRepository.LoadTravels(TravelsListView);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FinishDateTimePicker.MinDate = StartDateTimePicker.Value;
        }

        private void TravelsListView_Click(object sender, EventArgs e)
        {
            string destinations = TravelsListView.SelectedItems[0].SubItems[0].Text;
            string startDate = TravelsListView.SelectedItems[0].SubItems[1].Text;
            string finishDate = TravelsListView.SelectedItems[0].SubItems[2].Text;
            string numberOfSeats = TravelsListView.SelectedItems[0].SubItems[3].Text;
            string guide = TravelsListView.SelectedItems[0].SubItems[4].Text;
            string price = TravelsListView.SelectedItems[0].SubItems[5].Text;

            DestinationsTextBox.Text = destinations;
            StartDateTimePicker.Text = startDate;
            FinishDateTimePicker.Text = finishDate;
            Number_Of_SeatsComboBox.Text = numberOfSeats;
            GuideComboBox.Text = guide;
            PriceTextBox.Text = price;
        }
    }

 }
