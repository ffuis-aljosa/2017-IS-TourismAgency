using System;
using TourismAgency.Db;

namespace TourismAgency.Models
{
    class Client
    {
        private int id; 
        private string first_name;
        private string last_name;
        private string date_of_birth;
        private string e_mail;
        private string passport_number;
        private string citizenship;
        private string city;
        private string adress;
        private string phone_number;


        public Client(string first_name, string last_name, string date_of_birth, string e_mail, string passport_number, string citizenship, string city, string adress, string phone_number)
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
        }

        public Client(int id, string first_name, string last_name, string date_of_birth, string e_mail, string passport_number, string citizenship, string city, string adress, string phone_number)
        {
            this.id = id;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            E_mail = e_mail;
            Passport_number = passport_number;
            Citizenship = citizenship;
            City = city;
            Adress = adress;
            Phone_number = phone_number;
        }

        public int Id
        {
            get
            {
                return id; 
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
                    throw new Exception("First name can't be longer than a 32 characters!");

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
                    throw new Exception("Last name can't be longer than a 32 characters!");

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

                if (string.IsNullOrEmpty(value))
                    throw new Exception("E-mail can't be a blank space!");

                if (IsValidEmail(value) == false)
                    throw new Exception("E-mail is not valid");

                if (value.Length > 100)
                    throw new Exception("E-mail can't be longer than a 32 characters!");

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
                    throw new Exception("Citizenship can't be a blank space!");

                if (value.Length > 100)
                    throw new Exception("Citizenship can't be longer than a 32 characters!");

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
                    throw new Exception("City can't be longer than a 32 characters!");

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
                    throw new Exception("Adress can't be longer than a 32 characters!");

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
                if (value.Length < 12 || value.Length > 15)
                    throw new Exception("Phone number doesn't have a proper number of digits!");

                phone_number = value;
            }
        }
    }
}
