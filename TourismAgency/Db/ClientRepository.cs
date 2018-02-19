﻿using TourismAgency.Models;
using System.Data.SqlServerCe;

namespace TourismAgency.Db
{
    class ClientRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static void CreateUser(Client client)
        {
            string sql = "INSERT INTO users(first_name, last_name, date_of_birth, e_mail, passport_number, citizenship, city, adress, phone_number) VALUES"
                + "(@first_name, @last_name, @date_of_birth, @e_mail, @passport_number, @citizenship, @city, @adress, @phone_number)";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeParameter first_name = new SqlCeParameter("@first_name", client.First_name);
            command.Parameters.Add(first_name);

            SqlCeParameter last_name = new SqlCeParameter("@last_name", client.Last_name);
            command.Parameters.Add(last_name);

            SqlCeParameter date_of_birth = new SqlCeParameter("@date_of_birth", client.Date_of_birth);
            command.Parameters.Add(date_of_birth);

            SqlCeParameter e_mail = new SqlCeParameter("@e_mail", client.E_mail);
            command.Parameters.Add(e_mail);

            SqlCeParameter passport_number = new SqlCeParameter("@passport_number", client.Passport_number);
            command.Parameters.Add(passport_number);

            SqlCeParameter citizenship = new SqlCeParameter("@citizenship", client.Citizenship);
            command.Parameters.Add(citizenship);

            SqlCeParameter city = new SqlCeParameter("@city", client.City);
            command.Parameters.Add(city);

            SqlCeParameter adress = new SqlCeParameter("@adress", client.Adress);
            command.Parameters.Add(adress);

            SqlCeParameter phone_number = new SqlCeParameter("@phone_number", client.Phone_number);
            command.Parameters.Add(phone_number);

            command.Prepare();

            command.ExecuteNonQuery();
        }

    }
}