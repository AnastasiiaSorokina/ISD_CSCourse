using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Fighter
    {
            public int HP;
            public const int Damage = 10;
            public List<BodyPart> parts = new List<BodyPart> { };

            public Fighter()
            {
                this.HP = 100;
                foreach (string type in Enum.GetNames(typeof(BodyPartType)))
                {
                    parts.Add(new BodyPart(type));
                }
            }
            public void Hit(Fighter target, BodyPartType type)
            {
                if (!target.parts[(int)type].IsBlocked)
                {
                    target.HP -= Damage;
                }
            }
            public void Block(BodyPartType type)
            {
                foreach (BodyPart part in parts)
                {
                    if (part.IsBlocked == true)
                        part.IsBlocked = false;
                }

                parts[(int)type].IsBlocked = true;
            }
    }
}
