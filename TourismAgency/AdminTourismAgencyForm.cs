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

        private void AddNewAdminButton_Click(object sender, EventArgs e)
        {
            AddNewAdminForm addNewAdmin = new AddNewAdminForm();
            addNewAdmin.ShowDialog();
        }

        private void AddNewTravelButton_Click(object sender, EventArgs e)
        {
            AddNewTravelForm addNewTravel = new AddNewTravelForm();
            addNewTravel.ShowDialog(); 
        }
    }
}
