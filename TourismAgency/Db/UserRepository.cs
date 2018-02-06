using TourismAgency.Models;
using System.Data.SqlServerCe;
using System;

namespace TourismAgency.Db
{
    class UserRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static Users login(Users user)
        {
            string sql = @"SELECT * FROM users WHERE username = @username AND password = @password";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

             SqlCeParameter username = new SqlCeParameter("@username", user.Username);
             command.Parameters.Add(username);

             SqlCeParameter password = new SqlCeParameter("@password", user.Password);
             command.Parameters.Add(password);

             SqlCeParameter role = new SqlCeParameter("@role", user.Role);
             command.Parameters.Add(role); 
             
            command.Prepare();

            //Console.WriteLine(user.Password);

            SqlCeDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                user.Role = reader["role"].ToString();
                return user; 
            }
            
            return null;
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
