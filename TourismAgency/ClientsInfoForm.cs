using System;
using System.Windows.Forms;
using TourismAgency.Db;

namespace TourismAgency
{
    public partial class ClientsInfoForm : Form
    {
        public ClientsInfoForm()
        {
            InitializeComponent();
            UserRepository.LoadClients(ClientsListView);
        }

        private void UsersListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ClientsListView.Columns[e.ColumnIndex].Width;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourismAgencyForm = new AdminTourismAgencyForm();
            this.Hide();
            adminTourismAgencyForm.Show(); 
        }

        private void CreateNewAdminButton_Click(object sender, EventArgs e)
        {
            AddNewClientForm addNewClient = new AddNewClientForm();
            this.Hide();
            addNewClient.Show(); 
        }

        
    }
}
