using System;
using System.Windows.Forms;
using TourismAgency.Models;
using TourismAgency.Db;
using System.Collections.Generic;

namespace TourismAgency
{
    public partial class InfoGuidesForm : Form
    {
        public InfoGuidesForm()
        {
            InitializeComponent();
            LoadGuides();
            GuidesListView.FullRowSelect = true;
        }

        public void ClearTextBox(TextBox textBox)
        {
            textBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            AdminTourismAgencyForm adminTourism = new AdminTourismAgencyForm();
            this.Hide();
            adminTourism.Show();
        }

        private void AddGuidesButton_Click(object sender, EventArgs e)
        {
            AddNewGuideForm add = new AddNewGuideForm();
            this.Hide();
            add.Show(); 
        }

        public void LoadGuides()
        {
            GuidesListView.Items.Clear();

            try
            {
                GuideRepository.GuidesToListView(GuidesListView, SearchTextBox.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuidesListView_Click(object sender, EventArgs e)
        {
            string id = GuidesListView.SelectedItems[0].SubItems[0].Text;
            string firstName = GuidesListView.SelectedItems[0].SubItems[1].Text;
            string lastName = GuidesListView.SelectedItems[0].SubItems[2].Text;

            IdLabel.Text = id; 
            FirstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Guide guide = new Guide(
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text);

                GuideRepository.UpdateGuide(guide,IdLabel.Text);

                GuidesListView.Items.Clear();

                MessageBox.Show("Successful updated", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadGuides();

                ClearTextBox(FirstNameTextBox);
                ClearTextBox(LastNameTextBox);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GuidesListView.Items.Clear();
            LoadGuides();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to delete this guide?", "Delete guide", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                Guide guide = new Guide(
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text);

                GuideRepository.DeleteGuide(guide, IdLabel.Text);

                GuidesListView.Items.Clear();

                LoadGuides();

                ClearTextBox(FirstNameTextBox);
                ClearTextBox(LastNameTextBox);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
