﻿using System;
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
            LoadTravels();
            LoadGuides();
            TravelsListView.FullRowSelect = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminForm = new AdminTourismAgencyForm();
            this.Hide();
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

        private void CreateTravelButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to create new travel?", "Create travel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                Travel travel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text, 
                    FinishDateTimePicker.Text, Number_Of_SeatsComboBox.Text,
                    (Guide)GuideComboBox.SelectedItem, PriceTextBox.Text);

                TravelRepository.CreateTravel(travel);

                DialogResult = DialogResult.OK;
                TravelRepository.TravelsToListView(TravelsListView, SearchTextBox.Text);

                DestinationsTextBox.Text = "";
                StartDateTimePicker.Value = StartDateTimePicker.MinDate;
                FinishDateTimePicker.Value = FinishDateTimePicker.MinDate; 
                GuideComboBox.ResetText();
                Number_Of_SeatsComboBox.Text = "";
                PriceTextBox.Text = "";

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
            string id = TravelsListView.SelectedItems[0].SubItems[0].Text; 
            string destinations = TravelsListView.SelectedItems[0].SubItems[1].Text;
            string startDate = TravelsListView.SelectedItems[0].SubItems[2].Text;
            string finishDate = TravelsListView.SelectedItems[0].SubItems[3].Text;
            string numberOfSeats = TravelsListView.SelectedItems[0].SubItems[4].Text;
            string guide = TravelsListView.SelectedItems[0].SubItems[5].Text;
            string price = TravelsListView.SelectedItems[0].SubItems[6].Text;

            IdTextBox.Text = id; 
            DestinationsTextBox.Text = destinations;
            StartDateTimePicker.Text = startDate;
            FinishDateTimePicker.Text = finishDate;
            Number_Of_SeatsComboBox.Text = numberOfSeats;
            GuideComboBox.Text = guide;
            PriceTextBox.Text = price;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to change existing travel?", "Update travel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Travel travel = new Travel(DestinationsTextBox.Text, StartDateTimePicker.Text, 
                    FinishDateTimePicker.Text, Number_Of_SeatsComboBox.Text, (Guide)GuideComboBox.SelectedItem,
                    PriceTextBox.Text);

                TravelRepository.UpdateTravel(travel, IdTextBox);

                DialogResult = DialogResult.OK;
                TravelRepository.TravelsToListView(TravelsListView, SearchTextBox.Text);

                DestinationsTextBox.Text = "";
                StartDateTimePicker.Value = StartDateTimePicker.MinDate;
                FinishDateTimePicker.Value = FinishDateTimePicker.MinDate;
                GuideComboBox.ResetText();
                Number_Of_SeatsComboBox.Text = "";
                PriceTextBox.Text = "";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

 }
