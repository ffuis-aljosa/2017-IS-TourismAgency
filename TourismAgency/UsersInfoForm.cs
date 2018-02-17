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
    public partial class UsersInfoForm : Form
    {
        public UsersInfoForm()
        {
            InitializeComponent();
        }

        private void UsersListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = UsersListView.Columns[e.ColumnIndex].Width;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourismAgencyForm = new AdminTourismAgencyForm();
            this.Hide();
            adminTourismAgencyForm.Show(); 
        }

        private void CreateNewAdminButton_Click(object sender, EventArgs e)
        {
            AddNewAdminForm addNewAdmin = new AddNewAdminForm();
            this.Hide();
            addNewAdmin.Show(); 
        }
    }
}
