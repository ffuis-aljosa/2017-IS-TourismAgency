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
    public partial class AddNewTravelForm : Form
    {
        public AddNewTravelForm()
        {
            InitializeComponent();
        }

        private void CreateTravelButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to create new travel?", "Create travel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                Travel travel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text,
                    FinishDateTimePicker.Text, NumberOfSeatsComboBox.Text,
                    (Guide)GuideComboBox.SelectedItem, PriceTextBox.Text);

                TravelRepository.CreateTravel(travel);

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
    }
}
