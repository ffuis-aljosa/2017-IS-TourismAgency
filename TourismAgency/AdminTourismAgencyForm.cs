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
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show(); 
        }

        private void UsersInfoButton_Click(object sender, EventArgs e)
        {
            UsersInfoForm usersInfoForm = new UsersInfoForm();
            this.Hide();
            usersInfoForm.Show(); 
        }

        private void TravelsInfoButton_Click(object sender, EventArgs e)
        {
            TravelsInfoForm travelsInfo = new TravelsInfoForm();
            this.Hide();
            travelsInfo.Show(); 
        }
    }
}
