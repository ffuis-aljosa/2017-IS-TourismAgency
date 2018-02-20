using TourismAgency.Models;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System;

namespace TourismAgency.Db
{
    class TravelRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static void CreateTravel(Travel travel)
        {
            string sql = @"INSERT INTO travels(destinations, start_date, finish_date, guide, number_of_seats, price) VALUES
                (@destinations, @start_date, @finish_date, @guide, @number_of_seats, @price)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter destination = new SqlCeParameter("@destinations", travel.Destination);
            command.Parameters.Add(destination);

            SqlCeParameter start_date = new SqlCeParameter("@start_date", travel.Start_date);
            command.Parameters.Add(start_date);

            SqlCeParameter finish_date = new SqlCeParameter("@finish_date", travel.Finish_date);
            command.Parameters.Add(finish_date);

            SqlCeParameter guide = new SqlCeParameter("@guide", travel.Guide);
            command.Parameters.Add(guide);

            SqlCeParameter number_of_seats = new SqlCeParameter("@number_of_seats", travel.Number_of_seats);
            command.Parameters.Add(number_of_seats);

            SqlCeParameter price = new SqlCeParameter("@price", travel.Price);
            command.Parameters.Add(price);

            command.Prepare();

            command.ExecuteNonQuery();
        }

        public static void LoadTravels (ListView listview)
        {
            listview.Items.Clear();

            string sql = @"SELECT t.id, t.destinations, t.start_date, t.finish_date, g.first_name + '' + g.last_name AS guide, t.number_of_seats,
                t.price FROM travels AS t JOIN guides AS g ON t.guide_id = g.id";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

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

                    listview.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
