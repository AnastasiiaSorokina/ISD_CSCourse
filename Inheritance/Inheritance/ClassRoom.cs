using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ClassRoom
    {
        public List<Pupil> Pupils;
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Pupils = new List<Pupil> { };
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(new Pupil());
            Pupils.Add(new Pupil());
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Pupils = new List<Pupil> { };
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(pupil3);
            Pupils.Add(new Pupil());
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Pupils = new List<Pupil> { };
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(pupil3);
            Pupils.Add(pupil4);
        }
    }
}
