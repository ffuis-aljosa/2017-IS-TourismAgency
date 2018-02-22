using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismAgency.Models
{
    public class Guide
    {
        private int id;
        private string first_name;
        private string last_name;

        public Guide(string first_name, string last_name)
        {
            First_name = first_name;
            Last_name = last_name;
        }

        public Guide(int id, string first_name, string last_name)
        {
            this.id = id; 
            First_name = first_name;
            Last_name = last_name;
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

        public override string ToString()
        {
            return first_name + " " + last_name;
        }
}
}
