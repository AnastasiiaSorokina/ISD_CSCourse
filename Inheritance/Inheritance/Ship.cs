using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Ship : Vehicle
    {
        public int NumberOfPassengers;
        public string HomePort;
        protected string ReadString()
        {
            bool input = true;
            string Result = "";
            while (input)
            {
                Result = Console.ReadLine();
                if (Result == "" || Result == null)
                {
                    Console.WriteLine("Error. Try again:");
                }
                else
                {
                    input = false;
                }
            }
            return Result;
        }
        public Ship()
        {
            Console.WriteLine("Enter a number of passengers:");
            this.NumberOfPassengers = ReadInt();
            Console.WriteLine("Enter a home port:");
            this.HomePort = ReadString();
        }
        public override void ShowInfo()
        {
            Console.WriteLine("\nTYPE: SHIP");
            base.ShowInfo();
            Console.WriteLine("Number of passengers: {0}", NumberOfPassengers);
            Console.WriteLine("Home port: {0}", HomePort);
        }
    }
}
