using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car : Vehicle
    {
        public override void ShowInfo()
        {
            Console.WriteLine("\nTYPE: CAR");
            base.ShowInfo();
        }
    }
}
