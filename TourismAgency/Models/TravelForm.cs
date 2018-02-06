using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
