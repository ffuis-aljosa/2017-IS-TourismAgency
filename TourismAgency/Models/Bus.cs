using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Models
{
    class Bus
    {
        private int id;
        private string name;
        private int number_of_seats;

        public Bus(int id , string name , int number_of_seats)
        {
            this.id = id;
            Name = name;
            Number_of_seats = number_of_seats;
        }
        public Bus(string name , string number_of_seats)
        {

            Name = name;

            int number_of_seatsInt;

            bool parseSuccessful = int.TryParse(number_of_seats, out number_of_seatsInt);

            if (!parseSuccessful)
                throw new Exception("Incorrect number of seats");
            Number_of_seats = number_of_seatsInt;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The name of the bus can not be empty");

                if (value.Length > 32)
                    throw new Exception("The name can not be longer than 32 characters");

                name = value;
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
        public override string ToString()
        {
            return name + " " + number_of_seats;
        }
    }
}
