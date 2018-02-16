using System;
using System.Security.Cryptography;
using System.Text;

namespace TourismAgency.Models
{
    class Users
    {
        private string username;
        private string password;
        private string role;
        private string first_name;
        private string last_name;
        private string date_of_birth;
        private string e_mail;
        private string passport_number;
        private string citizenship;
        private string city;
        private string adress;
        private string phone_number;


        public Users (string username, string password)
        {
            Username = username;
            Password = password; 
        }

        public Users(string username, string password, string first_name, string last_name)
        {
            Username = username;
            Password = password;
            First_name = first_name;
            Last_name = last_name; 
        }


        public Users(string first_name, string last_name, string date_of_birth, string e_mail, string passport_number, string citizenship, string city, string adress, string phone_number, string username, string password)
        {
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            E_mail = e_mail;
            Passport_number = passport_number;
            Citizenship = citizenship;
            City = city;
            Adress = adress;
            Phone_number = phone_number;
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
        
        public string Date_of_birth
        {
            get
            {
                return date_of_birth;
            }
            set
            {
                date_of_birth = value;
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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
                if (IsValidEmail(value) == false)
                    throw new Exception("E-mail is not valid");

                if (string.IsNullOrEmpty(value))
                throw new Exception("E-mail can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("E-mail can't be longer than a 30 characters!");

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
                    throw new Exception("Passport number can't be a blank space!");

                if (value.Length != 8)
                    throw new Exception("Passport number is not valid!");

                passport_number = value;
            }
        }

        public string Citizenship
        {
            get
            {
                return citizenship;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Country can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Country can't be longer than a 100 characters!");

                citizenship = value;
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

        public string Phone_number
        {
            get
            {
                return phone_number;
            }
            set
            {
                if (value.StartsWith("06") == false || value.Length > 15)
                    throw new Exception("The phone number is not valid!"); 

                phone_number = value;
            }
        }


    }
}
