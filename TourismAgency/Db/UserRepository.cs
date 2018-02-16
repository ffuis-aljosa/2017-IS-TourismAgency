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

        public static void CreateAdmin(Users admin)
        {
            string sql = "INSERT INTO users(username, password, role, first_name, last_name) VALUES"
                + "(@username, @password, @role, @first_name, @last_name)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", admin.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", admin.Password);
            command.Parameters.Add(password);

            SqlCeParameter role = new SqlCeParameter("@role", admin.Role);
            command.Parameters.Add(role);

            SqlCeParameter first_name = new SqlCeParameter("@first_name", admin.First_name);
            command.Parameters.Add(first_name);

            SqlCeParameter last_name = new SqlCeParameter("@last_name", admin.Last_name);
            command.Parameters.Add(last_name);

            command.Prepare();

            command.ExecuteNonQuery();
        }

        public static void CreateUser(Users user)
        {
            string sql = "INSERT INTO users(username, password, role, first_name, last_name, date_of_birth, e_mail, passport_number, country, city, adress, phone_number) VALUES"
                + "(@username, @password, @role, @first_name, @last_name, @date_of_birth, @e_mail, @passport_number, @country, @city, @adress, @phone_number)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter username = new SqlCeParameter("@username", user.Username);
            command.Parameters.Add(username);

            SqlCeParameter password = new SqlCeParameter("@password", user.Password);
            command.Parameters.Add(password);

            SqlCeParameter role = new SqlCeParameter("@role", user.Role);
            command.Parameters.Add(role);

            SqlCeParameter first_name = new SqlCeParameter("@first_name", user.First_name);
            command.Parameters.Add(first_name);

            SqlCeParameter last_name = new SqlCeParameter("@last_name", user.Last_name);
            command.Parameters.Add(last_name);

            SqlCeParameter date_of_birth = new SqlCeParameter("@date_of_birth", user.Date_of_birth);
            command.Parameters.Add(date_of_birth);

            SqlCeParameter e_mail = new SqlCeParameter("@e_mail", user.E_mail);
            command.Parameters.Add(e_mail);

            SqlCeParameter passport_number = new SqlCeParameter("@passport_number", user.Passport_number);
            command.Parameters.Add(passport_number);

            SqlCeParameter country = new SqlCeParameter("@country", user.Country);
            command.Parameters.Add(country);

            SqlCeParameter city = new SqlCeParameter("@city", user.City);
            command.Parameters.Add(city);

            SqlCeParameter adress = new SqlCeParameter("@adress", user.Adress);
            command.Parameters.Add(adress);

            SqlCeParameter phone_number = new SqlCeParameter("@phone_number", user.Phone_number);
            command.Parameters.Add(phone_number);

            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
