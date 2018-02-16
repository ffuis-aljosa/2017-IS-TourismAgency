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


        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }

        private void AddNewTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTravelForm newtravel = new AddNewTravelForm();
            newtravel.Show();
            this.Hide();
        }

        private void AddNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAdminForm addNewAdmin = new AddNewAdminForm();
            addNewAdmin.Show();
            this.Hide(); 
        }
    }
}
