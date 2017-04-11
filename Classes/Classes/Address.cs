using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value > 0)
                    index = value;
                else
                    throw new ArgumentOutOfRangeException();
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
                if (value != "" && value != null)
                    country = value;
                else
                    throw new ArgumentNullException();
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
                if (value != "" && value != null)
                    city = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (value != "" && value != null)
                    street = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (value > 0)
                    house = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                if (value > 0)
                    apartment = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Address()
        {
            index = 1;
            country = "noname";
            city = "noname";
            street = "noname";
            house = 1;
            apartment = 1;
        }
        static string InputString()
        {
            bool input = true;
            string a = "";

            while (input)
            {
                a = Console.ReadLine();
                if (a != "" && a != null)
                {
                    input = false;
                }
                else
                {
                    Console.WriteLine("Input error!");
                }
            }

            return a;
        }
        static int InputInt()
        {
            bool input = true;
            int a = 0;

            while (input)
            {
                string str = Console.ReadLine();

                try
                {
                    a = int.Parse(str);
                    input = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error!");
                }
            }

            return a;
        }
        public void FillAll()
        {
            Console.WriteLine("Enter an index:");
            Index = InputInt();
            Console.WriteLine("Enter a country:");
            Country = InputString();
            Console.WriteLine("Enter a city:");
            City = InputString();
            Console.WriteLine("Enter a street:");
            Street = InputString();
            Console.WriteLine("Enter a house number:");
            House = InputInt();
            Console.WriteLine("Enter an apartment number:");
            Apartment = InputInt();
        }
        public void PrintAll()
        {
            Console.WriteLine("Index: {0}", index);
            Console.WriteLine("Country: {0}", country);
            Console.WriteLine("City: {0}", city);
            Console.WriteLine("Street: {0}", street);
            Console.WriteLine("House: {0}", house);
            Console.WriteLine("Apartment: {0}", apartment);
        }
    }
}
