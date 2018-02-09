using System;
using System.Windows.Forms;

namespace TourismAgency
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
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
