using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ExcelentPupil : Pupil
    {
        override public void Study()
        {
            Console.WriteLine("Excelent Pupil -> Study");
        }
        override public void Read()
        {
            Console.WriteLine("Excelent Pupil -> Read");
        }
        override public void Write()
        {
            Console.WriteLine("Excelent Pupil -> Write");
        }
        override public void Relax()
        {
            Console.WriteLine("Excelent Pupil -> Relax");
        }
    }
}
