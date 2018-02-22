using TourismAgency.Models;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace TourismAgency.Db
{
    class TravelRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static void CreateTravel(Travel travel)
        {
            string sql = @"INSERT INTO travels(destinations, start_date, finish_date, guide, 
                number_of_seats, price) VALUES
                (@destinations, @start_date, @finish_date, @guide, @number_of_seats, @price)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter destination = new SqlCeParameter("@destinations", travel.Destinations);
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

        public static void UpdateTravel(Travel travel, TextBox idTextBox)
        {
            string sql = @"UPDATE travels SET destinations = @destinations, start_date = @start_date,
                finish_date = @finish_date, guide = @guide, number_of_seats = @number_of_seats, price = @price
                WHERE id =" + idTextBox.Text;

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter id = new SqlCeParameter("@id", travel.Id);
            command.Parameters.Add(id);

            SqlCeParameter destination = new SqlCeParameter("@destinations", travel.Destinations);
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

        public static void TravelsToListView(ListView listview, string search)
        {
            string sql;
            DateTime now = DateTime.Now; 

            if (search == "")
            {
                sql = @"SELECT t.id, t.destinations, t.start_date, t.finish_date, 
                    g.first_name + ' ' + g.last_name AS guide, t.number_of_seats,
                    t.price FROM travels AS t JOIN guides AS g ON t.guide_id = g.id WHERE t.start_date > '" + now + "' ORDER BY id";
            }
            else
            {
                sql = @"SELECT t.id, t.destinations, t.start_date, t.finish_date,
                    g.first_name + ' ' + g.last_name AS guide, t.number_of_seats,
                    t.price FROM travels AS t JOIN guides AS g ON t.guide_id = g.id 
                    WHERE  t.start_date > '" + now + "' " +
                    "t.destinations LIKE '%" + search + "%' " +
                    "OR t.start_date LIKE '%" + search + "%' " +
                    "OR t.finish_date LIKE '%" + search + "%' " +
                    "OR g.first_name LIKE '%" + search + "%' " +
                    "OR g.last_name LIKE '%" + search + "%' " +
                    "ORDER BY id;";
            }

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

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

    }
}
