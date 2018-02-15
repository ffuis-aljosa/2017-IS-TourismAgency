using System;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TourismAgency.Models
{
    class Users
    {
        private string username;
        private string password;
        private string role;
        private string first_name;
        private string last_name;
        private DateTime date_of_birth;
        private string e_mail;
        private string passport_number;
        private string country;
        private string city;
        private string adress;
        private int phone_number;


        public Users (string username, string password)
        {
            Username = username;
            Password = password; 
        }

        public Users(string username, string password, string first_name, string last_name, DateTime date_of_birth, string email, string passport_number, string country, string city, string adress, int phone_number)
        {
            Username = username;
            Password = password;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            E_mail = email;
            Passport_number = passport_number;
            Country = country;
            City = city;
            Adress = adress;
            Phone_number = phone_number; 
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

        public string First_name
        {
            get
            {
                return first_name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("First name can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("First name can't be longer than a 100 characters!");

                first_name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Last name can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Last name can't be longer than a 100 characters!");

                last_name = value;
            }
        }

        public DateTime Date_of_birth
        {
            get
            {
                return date_of_birth;
            }
            set
            {
                DateTime zeroTime = new DateTime(1, 1, 1);

                DateTime a = value;
                DateTime b = DateTime.Today; 

                TimeSpan span = b - a;
                // Because we start at year 1 for the Gregorian
                // calendar, we must subtract a year here.
                int years = (zeroTime + span).Year - 1;

                if (years < 18)
                    throw new Exception("You must be an adult!");

                date_of_birth = value;
            }
        }

        public string E_mail
        {
            get
            {
                return e_mail;
            }
            set
            {
                bool email;

                if (new EmailAddressAttribute().IsValid(value))
                    email = true;
                else
                    email = false; 

                if (string.IsNullOrEmpty(value))
                throw new Exception("E-mail can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("E-mail can't be longer than a 30 characters!");

                if (email == false)
                    throw new Exception("E-mail is not valid"); 


                e_mail = value;
            }
        }

        public string Passport_number
        {
            get
            {
                return passport_number;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Passport can't be a blank space!");

                if (value.Length != 8)
                    throw new Exception("Passport is not valid! ");

                passport_number = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Country can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Country can't be longer than a 100 characters!");

                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("City can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("City can't be longer than a 100 characters!");

                city = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Adress can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Adress can't be longer than a 100 characters!");

                adress = value;
            }
        }

        public int Phone_number
        {
            get
            {
                return phone_number;
            }
            set
            {
                phone_number = value;
            }
        }


    }
}
