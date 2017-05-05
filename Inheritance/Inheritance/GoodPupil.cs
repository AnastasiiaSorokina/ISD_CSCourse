using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GoodPupil : Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Good Pupil -> Study");
        }
        override public void Read()
        {
            Console.WriteLine("Good Pupil -> Read");
        }
        override public void Write()
        {
            Console.WriteLine("Good Pupil -> Write");
        }
        override public void Relax()
        {
            Console.WriteLine("Good Pupil -> Relax");
        }
    }
}
