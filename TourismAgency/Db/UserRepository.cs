using TourismAgency.Models;
using System.Data.SqlServerCe;
using System;

namespace TourismAgency.Db
{
    class UserRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        /*public static void Status(Users user)
        {
            string sql = @"SELECT role FROM users WHERE username = @username AND password = @password";
            
            SqlCeCommand cmd = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = cmd.ExecuteReader();//to read data from table
            while (reader.Read())
            {
                Console.WriteLine(reader.ToString());
            }
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
            
            //Console.WriteLine(user.Password);
            //Status(user); 
            
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
