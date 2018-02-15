using System;
using System.Windows.Forms;

namespace TourismAgency
{
    public partial class AddNewTravelForm : Form
    {
        public AddNewTravelForm()
        {
            InitializeComponent();
            StartDateTimePicker.MinDate = DateTime.Now;
            FinishDateTimePicker.MinDate = DateTime.Now; 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TourismAgencyForm adminForm = new TourismAgencyForm();
            adminForm.Show();

        }
    }
}
