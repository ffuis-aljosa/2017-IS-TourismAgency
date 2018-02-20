using System;
using System.Data.SqlServerCe;
using TourismAgency.Models;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TourismAgency.Db
{
    class GuideRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static void CreateGuide(Guide guide)
        {
            string sql = "INSERT INTO guides(first_name, last_name) VALUES"
                + "(@first_name, @last_name )";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter first_name = new SqlCeParameter("@first_name", guide.First_name);
            command.Parameters.Add(first_name);

            SqlCeParameter last_name = new SqlCeParameter("@last_name", guide.Last_name);
            command.Parameters.Add(last_name);


            command.Prepare();

            command.ExecuteNonQuery();
        }

        public static void LoadGuides(ListView listview)
        {
            listview.Items.Clear();

            string sql = @"SELECT id, first_name, last_name 
                 FROM guides ORDER BY id";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["first_name"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());

                    listview.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void FetchGuides(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            string sql = @"SELECT first_name, last_name 
                 FROM guides";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.DisplayMember = "first_name + '' + last_name" ;
                    comboBox.ValueMember = "first_name + '' + last_name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
