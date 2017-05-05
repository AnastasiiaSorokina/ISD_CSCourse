using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public int XCoord;
        public int YCoord;
        public double Price;
        public double Speed;
        public int YearOfProduction;

        protected int ReadInt()
        {
            bool input = true;
            int Result = 0;
            while (input)
            {
                string str = Console.ReadLine();
                try
                {
                    Result = int.Parse(str);
                    input = false;
                }
                catch
                {
                    Console.WriteLine("Error. Try again:");
                }
            }
            return Result;
        }
        protected double ReadDouble()
        {
            bool input = true;
            double Result = 0;
            while (input)
            {
                string str = Console.ReadLine();
                try
                {
                    Result = double.Parse(str);
                    input = false;
                }
                catch
                {
                    Console.WriteLine("Error. Try again:");
                }
            }
            return Result;
        }
        public Vehicle()
        {
            Console.WriteLine("Enter an X-coord:");
            this.XCoord = ReadInt();
            Console.WriteLine("Enter an Y-coord:");
            this.YCoord = ReadInt();
            Console.WriteLine("Enter a price:");
            this.Price = ReadDouble();
            Console.WriteLine("Enter a speed:");
            this.Speed = ReadDouble();
            Console.WriteLine("Enter a year of production:");
            this.YearOfProduction = ReadInt();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("XCoord: {0}", XCoord);
            Console.WriteLine("YCoord: {0}", YCoord);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Year of production: {0}", YearOfProduction);
        }
    }
}
