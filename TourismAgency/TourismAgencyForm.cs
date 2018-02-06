using System;
using System.Windows.Forms;
using TourismAgency.Models; 

namespace TourismAgency
{
    public partial class TourismAgencyForm : Form
    {
        public TourismAgencyForm()
        {
            InitializeComponent();
        }

        private void TourismAgencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            CreateUserForm createUser = new CreateUserForm();
            createUser.Show();
            this.Hide();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }

        private void TravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TravelForm travelform = new TravelForm();
            travelform.Show();
            this.Hide();
        }
    }
}
