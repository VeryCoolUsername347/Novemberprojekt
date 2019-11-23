using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Bow : Weapon

    {
        public Bow()
        {
            minDamage = 7;
            maxDamage = 20;
            critChance = 5;
            bonusCritDamage = 15;
            name = "Bow";
        }
        public bool DoesItHit()
        {
            Random hitting = new Random();
            int itHits = hitting.Next(1, 101);
            if (itHits >= 50)
            {
                return true;
            }
            else
                return false;
        }
        public override int Attack()
        {
            if (DoesItHit())
            {
                return base.Attack();
            }
            else
                return 0;
        }


    }
}
