using TourismAgency.Models;
using System.Data.SqlServerCe;
using System.Collections.Generic;
using System;

namespace TourismAgency.Db
{
    class UserRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static User login(User user)
        {
            string sql = @"SELECT * FROM users WHERE username = @username AND password = @password";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

             SqlCeParameter username = new SqlCeParameter("@username", user.Username);
             command.Parameters.Add(username);

             SqlCeParameter password = new SqlCeParameter("@password", user.Password);
            command.Parameters.Add(password);
             
            command.Prepare();

            //Console.WriteLine(user.Password);

            SqlCeDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                return user; 
            }
            
            return null;
        }

        public static void CreateAdmin(User admin)
        {
            string sql = "INSERT INTO users(username, password) VALUES"
                + "(@username, @password)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", admin.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", admin.Password);
            command.Parameters.Add(password);

            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
