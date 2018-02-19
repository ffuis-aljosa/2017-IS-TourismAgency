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

            string sql = @"SELECT t.id, t.destinations, t.start_date, t.finish_date, g.frst_name, g.last_name, t.number_of_seats,
                t.price FROM travels AS t JOIN guides AS g ON t.guide_id = g.id";

            SqlCeCommand command = new SqlCeCommand(sql, connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["t.destinations"].ToString());
                    item.SubItems.Add(reader["t.start_date"].ToString());
                    item.SubItems.Add(reader["t.finish_date"].ToString());
                    item.SubItems.Add(reader["g.first_name g.last_name"].ToString());
                    item.SubItems.Add(reader["t.number_of_seats"].ToString());
                    item.SubItems.Add(reader["t.price"].ToString());

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
