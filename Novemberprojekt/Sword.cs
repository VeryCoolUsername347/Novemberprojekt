using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Sword : Weapon
    {
        public Sword()
        {
            
            minDamage = 5;
            maxDamage = 16;
            critChance = 10;
            bonusCritDamage = 13;
            name = "Sword";
            
        }
        
    }
}
