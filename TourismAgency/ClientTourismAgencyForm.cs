using System;
using System.Windows.Forms;
using TourismAgency.Db; 

namespace TourismAgency
{
    public partial class ClientTourismAgencyForm : Form
    {
        public ClientTourismAgencyForm()
        {
            InitializeComponent();
            LoadTravels();
        }

        private void ClientTourismAgencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
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

        private void ToolStripButton1_Click(object sender, System.EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show(); 
        }

        private void PhotoCollectionButton_Click(object sender, System.EventArgs e)
        {
            PhotoPanel1.Visible = true; 
        }

        private void TravelInfoButton_Click(object sender, System.EventArgs e)
        {
            PhotoPanel1.Visible = false;
            TravelListPanel.Visible = true; 
        }

        private void TravelInfoButton1_Click(object sender, System.EventArgs e)
        {
            PhotoPanel2.Visible = false;
            PhotoPanel1.Visible = false;
            TravelListPanel.Visible = true; 
        }

        private void TravellnfoButton2_Click(object sender, System.EventArgs e)
        {
            PhotoPanel3.Visible = false; 
            PhotoPanel2.Visible = false;
            PhotoPanel1.Visible = false;
            TravelListPanel.Visible = true;
        }

        private void TravellnfoButton3_Click(object sender, System.EventArgs e)
        {
            PhotoPanel4.Visible = false; 
            PhotoPanel3.Visible = false;
            PhotoPanel2.Visible = false;
            PhotoPanel1.Visible = false;
            TravelListPanel.Visible = true;
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            PhotoPanel2.Visible = true; 
        }

        private void PreviousButton1_Click(object sender, System.EventArgs e)
        {
            PhotoPanel2.Visible = false; 
            PhotoPanel1.Visible = true; 
        }

        private void NextButton1_Click(object sender, System.EventArgs e)
        {
            PhotoPanel3.Visible = true; 
        }

        private void PreviousButton2_Click(object sender, System.EventArgs e)
        {
            PhotoPanel3.Visible = false; 
            PhotoPanel2.Visible = true; 
        }

        private void NextButton2_Click(object sender, System.EventArgs e)
        {
            PhotoPanel4.Visible = true;
        }

        private void PreviousButton3_Click(object sender, System.EventArgs e)
        {
            PhotoPanel4.Visible = false; 
            PhotoPanel3.Visible = true;
        }


        private void NextButton3_Click(object sender, System.EventArgs e)
        {
            PhotoPanel1.Visible = true; 
        }

        private void PrevoiusButton_Click(object sender, System.EventArgs e)
        {
            PhotoPanel1.Visible = false; 
            PhotoPanel4.Visible = true; 
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TravelsListView.Items.Clear();
            LoadTravels();
        }
    }
}
