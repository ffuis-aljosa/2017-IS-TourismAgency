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
    public partial class AddNewGuideForm : Form
    {
        public AddNewGuideForm()
        {
            InitializeComponent();
        }

        public void ClearTextBox(TextBox textBox)
        {
            textBox.Text = "";
        }

        private void CreateGuideButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to create new guide?", "Create guide", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Guide guide = new Guide(
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text);

                GuideRepository.CreateGuide(guide);

                DialogResult = DialogResult.OK;

                ClearTextBox(FirstNameTextBox);
                ClearTextBox(LastNameTextBox);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InfoGuidesForm info = new InfoGuidesForm();
            this.Close();
            info.Show(); 
        }
    }
}
