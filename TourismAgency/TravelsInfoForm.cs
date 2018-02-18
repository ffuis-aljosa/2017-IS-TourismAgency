using System;
using TourismAgency.Db;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace TourismAgency
{
    public partial class TravelsInfoForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public TravelsInfoForm()
        {
            InitializeComponent();
            loadTravels();
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

        private void loadTravels()
        {
            TravelsListView.Items.Clear();

            string sql = @"SELECT id, destinations, start_date, finish_date, guide, number_of_seats,
                price FROM travels";

            SqlCeCommand command = new SqlCeCommand(sql, connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["destinations"].ToString());
                    item.SubItems.Add(reader["start_date"].ToString());
                    item.SubItems.Add(reader["finish_date"].ToString());
                    item.SubItems.Add(reader["guide"].ToString());
                    item.SubItems.Add(reader["number_of_seats"].ToString());
                    item.SubItems.Add(reader["price"].ToString());

                    TravelsListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
