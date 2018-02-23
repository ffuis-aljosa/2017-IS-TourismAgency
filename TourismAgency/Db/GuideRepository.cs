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

        public static void UpdateGuide(Guide guide)
        {
            string sql = @"UPDATE guides SET first_name = @first_name, last_name = @last_name
                WHERE id = @id ";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter id = new SqlCeParameter("@id", guide.Id);
            command.Parameters.Add(id);

            SqlCeParameter first_name = new SqlCeParameter("@first_name", guide.First_name);
            command.Parameters.Add(first_name);

            SqlCeParameter last_name = new SqlCeParameter("@last_name", guide.Last_name);
            command.Parameters.Add(last_name);

            command.Prepare();

            command.ExecuteNonQuery();
        }

        public static void DeleteGuide(Guide guide, int idNumber)
        {
            string sql = @"DELETE FROM guides WHERE id =" + idNumber;

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            command.ExecuteNonQuery();
        }

        public static void GuidesToListView(ListView listview, string search)
        {
            string sql;

            if (search == "")
            {
                sql = @"SELECT id, first_name, last_name FROM guides ORDER BY id";
            }
            else
            {
                sql = @"SELECT id, first_name, last_name FROM guides 
                    WHERE first_name LIKE '%" + search + "%' " +
                    "OR last_name LIKE '%" + search + "%'" +
                    "ORDER BY id;";
            }

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["id"].ToString());
                item.SubItems.Add(reader["first_name"].ToString());
                item.SubItems.Add(reader["last_name"].ToString());

                listview.Items.Add(item);
            }
        }

        public static List<Guide> FetchAllGuides()
        {
            List<Guide> guides = new List<Guide>();

            string sql = @"SELECT id, first_name, last_name FROM guides";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string first_name = (string)reader["first_name"];
                string last_name = (string)reader["last_name"];


                Guide guide = new Guide(id, first_name, last_name);
                guides.Add(guide);
            }

            return guides;
        }
    }
}
