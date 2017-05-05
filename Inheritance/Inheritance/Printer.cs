using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Printer
    {
        public ConsoleColor Color;

        public Printer()
        {
            this.Color = ConsoleColor.Red;
        }
        public void Print(string value)
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}