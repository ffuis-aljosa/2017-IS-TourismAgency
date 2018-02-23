using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TourismAgency.Db;
using TourismAgency.Models;

namespace TourismAgency
{
    public partial class AddNewTravelForm : Form
    {
        public Travel NewTravel { get; set; }

        public AddNewTravelForm()
        {
            InitializeComponent();
            StartDateTimePicker.MinDate = DateTime.Now;
            LoadGuides();
        }

        private void CreateTravelButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewTravel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text,
                    FinishDateTimePicker.Text, NumberOfSeatsComboBox.Text,
                    (Guide)GuideComboBox.SelectedItem, PriceTextBox.Text);

                TravelRepository.CreateTravel(NewTravel);

                DialogResult = DialogResult.OK;

                DestinationsTextBox.Text = "";
                StartDateTimePicker.Value = StartDateTimePicker.MinDate;
                FinishDateTimePicker.Value = FinishDateTimePicker.MinDate;
                GuideComboBox.ResetText();
                NumberOfSeatsComboBox.Text = "";
                PriceTextBox.Text = "";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InfoTravelsForm info = new InfoTravelsForm();
            this.Close();
            info.Show(); 
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FinishDateTimePicker.MinDate = StartDateTimePicker.Value;
        }

        private void LoadGuides()
        {
            List<Guide> guides = GuideRepository.FetchAllGuides();

            foreach (Guide guide in guides)
                GuideComboBox.Items.Add(guide);
        }
    }
}
