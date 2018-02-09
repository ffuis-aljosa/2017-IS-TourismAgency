using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Models
{
    class Travel
    {

        private int id;
        private string destination;
        private DateTime start_date;
        private DateTime finish_date;
        private int number_of_seats;
        private int price;

        public Travel(int id, string destination , DateTime start_date , DateTime finish_date , int number_of_seats , int price)
        {
            this.id = id;
            Destination = destination;
            Start_date = start_date;
            Finish_date = finish_date;
            Number_of_seats = number_of_seats;
            Price = price;

        }
        public Travel( string destination, DateTime start_date, DateTime finish_date, int number_of_seats, string price)
        {
            
            Destination = destination;
            Start_date = start_date;
            Finish_date = finish_date;
            Number_of_seats = number_of_seats;

            int priceInt;

            bool parseSuccessful = int.TryParse(price, out priceInt);

            if (!parseSuccessful)
                throw new Exception("Incorrect price");
            Price = priceInt;
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
        public DateTime Start_date
        {
            get
            {
                return start_date;
            }
            set
            {
                if (start_date < DateTime.Now)
                    throw new Exception("Start date can't be lower than current time");
                start_date = value;

            }

        }
        public DateTime Finish_date
        {
            get
            {
                return finish_date;
            }
            set
            {
                if (finish_date < DateTime.Now)
                    throw new Exception("Finish date can't be lower than current time");
                else if (finish_date < start_date)
                    throw new Exception("Finish date can't be lower than start date");
                finish_date = value;

            }

        }
        public int Number_of_seats
        {
            get
            {
                return number_of_seats;
            }
            set
            {

                number_of_seats = value;

            }

        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price < 0)
                    throw new Exception("The price must be higher than zero");
                price = value;

            }

        }

    }

}
