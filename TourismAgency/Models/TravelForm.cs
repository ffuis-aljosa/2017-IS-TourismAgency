using System;
using System.Windows.Forms;

namespace TourismAgency.Models
{
    public partial class TravelForm : Form
    {
        public TravelForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TourismAgencyForm adminForm = new TourismAgencyForm();
            adminForm.Show();
        }
    }
}
