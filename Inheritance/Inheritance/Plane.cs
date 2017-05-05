using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Plane : Vehicle
    {
        public double Height;
        public int NumberOfPassengers;
        public Plane()
        {
            Console.WriteLine("Enter a height:");
            this.Height = ReadDouble();
            Console.WriteLine("Enter a number of passengers:");
            this.NumberOfPassengers = ReadInt();
        }
        public override void ShowInfo()
        {
            Console.WriteLine("\nTYPE: PLANE");
            base.ShowInfo();
            Console.WriteLine("Height: {0}", Height);
            Console.WriteLine("Number of passengers: {0}", NumberOfPassengers);
        }
    }
}
