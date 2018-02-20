using TourismAgency.Models;
using System.Data.SqlServerCe;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

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

        public static void LoadClients(ListView listview)
        {
            listview.Items.Clear();

            string sql = @"SELECT id, first_name, last_name, date_of_birth, e_mail, 
                passport_number, citizenship, city, adress, phone_number FROM clients ORDER BY id";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["first_name"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());
                    item.SubItems.Add(reader["date_of_birth"].ToString());
                    item.SubItems.Add(reader["e_mail"].ToString());
                    item.SubItems.Add(reader["passport_number"].ToString());
                    item.SubItems.Add(reader["citizenship"].ToString());
                    item.SubItems.Add(reader["city"].ToString());
                    item.SubItems.Add(reader["adress"].ToString());
                    item.SubItems.Add(reader["phone_number"].ToString());

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
