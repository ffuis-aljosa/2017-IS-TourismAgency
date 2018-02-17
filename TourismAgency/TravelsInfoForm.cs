using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            string sql = @"SELECT t.id, t.destination, t.start_date, t.finish_date, b.model, g.first_name,
                t.price FROM travels AS t JOIN buses AS b JOIN guides AS g ON b.id = t.bus_id AND g.id = t.guide_id";

            SqlCeCommand command = new SqlCeCommand(sql, connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["destination"].ToString());
                    item.SubItems.Add(reader["start_date"].ToString());
                    item.SubItems.Add(reader["finish_date"].ToString());
                    item.SubItems.Add(reader["bus"].ToString());
                    item.SubItems.Add(reader["guide"].ToString());
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
