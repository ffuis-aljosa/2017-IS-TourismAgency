using System;
using System.Windows.Forms;
using TourismAgency.Models; 

namespace TourismAgency
{
    public partial class AdminTourismAgencyForm : Form
    {
        public AdminTourismAgencyForm()
        {
            InitializeComponent(); 
        }

        private void TourismAgencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void LogoutToolStripButton_Click(object sender, EventArgs e)
        {
            ClientTourismAgencyForm clientForm = new ClientTourismAgencyForm();
            this.Hide();
            clientForm.Show(); 
        }

        private void ClientsInfoButton_Click(object sender, EventArgs e)
        {
            InfoClientsForm clientsInfoForm = new InfoClientsForm();
            this.Hide();
            clientsInfoForm.Show(); 
        }

        private void TravelsInfoButton_Click(object sender, EventArgs e)
        {
            InfoTravelsForm travelsInfo = new InfoTravelsForm();
            this.Hide();
            travelsInfo.Show(); 
        }

        private void GuidesInfoButton_Click(object sender, EventArgs e)
        {
            InfoGuidesForm guideForm = new InfoGuidesForm();
            this.Hide();
            guideForm.Show();
        }

        private void AddNewAdminToolStripButton_Click(object sender, EventArgs e)
        {
            AddNewAdminForm addNewAdmin = new AddNewAdminForm();
            addNewAdmin.ShowDialog();
        }

        
    }
}
