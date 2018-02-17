using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Models
{
    class Guide
    {
        private int id;
        private string first_name;
        private string last_name;
        private DateTime date_of_birth;
        private int phone_number;
        private string passaport_number;

        public Guide(int id , string first_name , string last_name , DateTime date_of_birth , int phone_number , string passaport_number)
        {
            this.id = id;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            Phone_number = phone_number;
            Passaport_number = passaport_number;
        }
        public Guide( string first_name, string last_name, DateTime date_of_birth, string phone_number, string passaport_number)
        {
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;

            int phone_numberInt;

            bool parseSuccessful = int.TryParse(phone_number, out phone_numberInt);

            if (!parseSuccessful)
                throw new Exception("Incorrect phone number");
            Phone_number = phone_numberInt;


            Passaport_number = passaport_number;
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

                    throw new Exception("First name can't be empty");


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

                    throw new Exception("Last name can't be empty");


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
               /* if (date_of_birth < " 2000:12:31 ")
                    throw new Exception(" ");*/
                date_of_birth = value;
                
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
                if (phone_number.ToString().Length < 9 && phone_number.ToString().Length > 13)
                    throw new Exception("Incorrect phone number");
                phone_number = value;

            }

        }
        public string Passaport_number
        {
            get
            {
                return passaport_number;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The passaport number of the bus can not be empty");

                if (value.Length > 8)
                    throw new Exception("The passaport number can not be longer than 8 characters");

                passaport_number = value;
            }

        }

        public override string ToString()
        {
            return first_name + " " + last_name + " " + date_of_birth + " " + phone_number + " " + passaport_number;
        }
    }



}
