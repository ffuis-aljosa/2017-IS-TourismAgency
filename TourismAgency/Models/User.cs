using System;
using System.Security.Cryptography;
using System.Text;

namespace TourismAgency.Models
{
    class User
    {
        private int id;
        private string username;
        private string password;
        
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(int id, string username, string password)
        {
            this.id = id; 
            Username = username;
            Password = password;
        }


        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Username can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Username can't be longer than a 32 characters!");

                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 6)
                    throw new Exception("Password must have at least 6 characters!");

                using (SHA256 sha = new SHA256Managed())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(value);
                    byte[] hashedPassword = sha.ComputeHash(passwordBytes);

                    password = Convert.ToBase64String(hashedPassword);
                }
            }
        }
    }
}
