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
            GuideRepository.LoadGuides(GuidesListView, SearchTextBox);
            GuidesListView.FullRowSelect = true;
        }

        public void ClearTextBox(TextBox textBox)
        {
            textBox.Text = " ";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            AdminTourismAgencyForm adminTourism = new AdminTourismAgencyForm();
            this.Hide();
            adminTourism.Show();
        }

        private void AddGuidesButton_Click(object sender, EventArgs e)
        {
            try
            {

                Guide guide = new Guide(
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text);
                GuideRepository.CreateGuide(guide);

                DialogResult = DialogResult.OK;
                GuideRepository.LoadGuides(GuidesListView, SearchTextBox);

                ClearTextBox(FirstNameTextBox);
                ClearTextBox(LastNameTextBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuidesListView_Click(object sender, EventArgs e)
        {
            string id = GuidesListView.SelectedItems[0].SubItems[0].Text;
            string firstName = GuidesListView.SelectedItems[0].SubItems[1].Text;
            string lastName = GuidesListView.SelectedItems[0].SubItems[2].Text;

            IdTextBox.Text = id.ToString();
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

                GuideRepository.UpdateGuide(guide, IdTextBox);

                DialogResult = DialogResult.OK;
                GuideRepository.LoadGuides(GuidesListView, SearchTextBox);

                ClearTextBox(FirstNameTextBox);
                ClearTextBox(LastNameTextBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
