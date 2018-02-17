using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TourismAgency.Db;
using TourismAgency.Models;
using System.Data.SqlServerCe;

namespace TourismAgency
{
    public partial class UsersInfoForm : Form
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public UsersInfoForm()
        {
            InitializeComponent();
            loadUsers();
        }

        private void UsersListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = UsersListView.Columns[e.ColumnIndex].Width;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AdminTourismAgencyForm adminTourismAgencyForm = new AdminTourismAgencyForm();
            this.Hide();
            adminTourismAgencyForm.Show(); 
        }

        private void CreateNewAdminButton_Click(object sender, EventArgs e)
        {
            AddNewAdminForm addNewAdmin = new AddNewAdminForm();
            this.Hide();
            addNewAdmin.Show(); 
        }

        private void loadUsers()
        {
            UsersListView.Items.Clear();

            string sql = @"SELECT id, username, role, first_name, last_name, date_of_birth, e_mail, 
                passport_number, citizenship, city, adress, phone_number FROM users ORDER BY id"; 

            SqlCeCommand command = new SqlCeCommand(sql, connection);

            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["username"].ToString());
                    item.SubItems.Add(reader["role"].ToString());
                    item.SubItems.Add(reader["first_name"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());
                    item.SubItems.Add(reader["date_of_birth"].ToString());
                    item.SubItems.Add(reader["e_mail"].ToString());
                    item.SubItems.Add(reader["passport_number"].ToString());
                    item.SubItems.Add(reader["citizenship"].ToString());
                    item.SubItems.Add(reader["city"].ToString());
                    item.SubItems.Add(reader["adress"].ToString());
                    item.SubItems.Add(reader["phone_number"].ToString());

                    UsersListView.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
