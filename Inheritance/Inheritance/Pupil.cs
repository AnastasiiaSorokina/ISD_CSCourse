using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Pupil
    {
        virtual public void Study()
        {
            Console.WriteLine("Some Pupil -> Study");
        }
        virtual public void Read()
        {
            Console.WriteLine("Some Pupil -> Read");
        }
        virtual public void Write()
        {
            Console.WriteLine("Some Pupil -> Write");
        }
        virtual public void Relax()
        {
            Console.WriteLine("Some Pupil -> Relax");
        }
    }
}
