using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismAgency
{
    public partial class TravelsInfoForm : Form
    {
        public TravelsInfoForm()
        {
            InitializeComponent();
        }

        private void TravelsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = TravelsListView.Columns[e.ColumnIndex].Width;
        }

        private void AddNewTravelButton_Click(object sender, EventArgs e)
        {
            AddNewTravelForm addNewTravelForm = new AddNewTravelForm(); 
            this.Hide();
            addNewTravelForm.Show(); 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourism = new AdminTourismAgencyForm();
            this.Hide();
            adminTourism.Show(); 
        }
    }
}
