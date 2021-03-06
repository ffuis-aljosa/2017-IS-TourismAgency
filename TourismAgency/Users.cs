﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace TourismAgency.Models
{
    class Users
    {
        private string username;
        private string password;
        private string role; 

        public Users (string username, string password)
        {
            Username = username;
            Password = password; 
        }

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Role can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Role can't be longer than a 100 characters!");

                role = value;
            }
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
                    throw new Exception("Username can't be longer than a 100 characters!");

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
