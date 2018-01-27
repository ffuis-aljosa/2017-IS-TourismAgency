using TourismAgency.Models;
using System.Data.SqlServerCe;
using System;

namespace TourismAgency.Db
{
    class UserRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        /*public static string Status(Users user)
        {
            string sql = @"SELECT role FROM users WHERE username = @username AND password = @password";
           
        }*/

        public static bool login(Users user)
        {
            string sql = @"SELECT * FROM users WHERE username = @username AND password = @password";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", user.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", user.Password);
            command.Parameters.Add(password);

            command.Prepare();

            SqlCeDataReader reader = command.ExecuteReader();

            //Console.WriteLine(Status(user));
            //Console.WriteLine(user.Password); 
            
            if (reader.Read())
                return true;

            return false;
        }

        public static void createUser(Users user)
        {
            string sql = "INSERT INTO users(username, password) VALUES"
                + "(@username, @password)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", user.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", user.Password);
            command.Parameters.Add(password);

            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
