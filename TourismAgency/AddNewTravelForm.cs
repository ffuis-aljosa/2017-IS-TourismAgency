using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db;
using System.Data.SqlServerCe;
using System.Collections.Generic;

namespace TourismAgency
{
    public partial class AddNewTravelForm : Form
    {
        public AddNewTravelForm()
        {
            InitializeComponent();
            StartDateTimePicker.MinDate = DateTime.Now;
            FinishDateTimePicker.MinDate = DateTime.Now;
            TravelRepository.LoadTravels(TravelsListView);
            GuideRepository.FetchGuides(GuideComboBox);
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
    }

 }
