using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub2
{
    class BodyPart
    {
        public string name;
        public bool IsBlocked;

        public BodyPart(string name)
        {
            this.name = name;
            this.IsBlocked = false;
        }
    }
}