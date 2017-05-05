using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BadPupil : Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Bad Pupil -> Study");
        }
        override public void Read()
        {
            Console.WriteLine("Bad Pupil -> Read");
        }
        override public void Write()
        {
            Console.WriteLine("Bad Pupil -> Write");
        }
        override public void Relax()
        {
            Console.WriteLine("Bad Pupil -> Relax");
        }
    }
}
