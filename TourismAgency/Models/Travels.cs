﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Models
{
    class Travels
    {

        private int id;
        private string destination;
        private string start_date;
        private string finish_date;
        private string number_of_seats;
        private string guide;
        private string price;

        public Travels(int id, string destination , string start_date , string finish_date , string number_of_seats ,string guide , string price)
        {
            this.id = id;
            Destination = destination;
            Start_date = start_date;
            Finish_date = finish_date;
            Number_of_seats = number_of_seats;
            Guide = guide;
            Price = price;

        }

        public Travels(string destination, string start_date, string finish_date, string number_of_seats , string guide, string price)
        {
            
            Destination = destination;
            Start_date = start_date;
            Finish_date = finish_date;
            Number_of_seats = number_of_seats;
            Guide = guide;
            Price = price; 
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Destination
        {
            
            get
            {
                return destination;
            }
            set
            {

                if (string.IsNullOrEmpty(value))

                    throw new Exception("Destination can't be empty");


                destination = value;

            }
        }

        public string Start_date
        {
            get
            {
                return start_date;
            }
            set
            {
                start_date = value;

            }

        }

        

        public string Finish_date
        {
            get
            {
                return finish_date;
            }
            set
            {
               // if ()
                 //   throw new Exception("Finish date can't be lower than start date!");
                finish_date = value;

            }

        }

        public string Number_of_seats
        {
            get
            {
                return number_of_seats;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Number of seats can't be empty!");

                number_of_seats = value;
            }
        }

        public string Guide
        {
            get
            {
                return guide;

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Guide can't be empty");

                guide = value;

            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Price can't be empty");

                if (Convert.ToInt16(price) < 0)
                    throw new Exception("The price must be higher than zero");


                price = value;

            }

        }


    }

}