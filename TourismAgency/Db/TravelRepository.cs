using TourismAgency.Models;
using System.Data.SqlServerCe;

namespace TourismAgency.Db
{
    class TravelRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static void CreateTravel(Travels travel)
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

    }
}
