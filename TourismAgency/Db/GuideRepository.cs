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

        public static void LoadGuides(ListView listview, TextBox search)
        {
            listview.Items.Clear();

            string sql;

            if (search.Text == "")
            {
                sql = @"SELECT first_name, last_name FROM guides";
            }
            else
            {
                sql = @"SELECT first_name, last_name FROM guides 
                    WHERE first_name LIKE '%" + search.Text + "%' " +
                    "OR last_name LIKE '%" + search.Text + "%' ;";
            }

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["first_name"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());

                    listview.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static List<Guide> FetchAllGuides()
        {
            List<Guide> guides = new List<Guide>();

            string sql = @"SELECT first_name, last_name FROM guides";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string first_name = (string)reader["first_name"];
                string last_name = (string)reader["last_name"];


                Guide guide = new Guide(first_name, last_name);
                guides.Add(guide);
            }

            return guides;
        }
    }
}
