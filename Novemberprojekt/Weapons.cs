using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Weapon
    {
        public int maxDamage;
        public int minDamage;
        public string name;
        Random minToMax = new Random();


        //bonusDamage Or critDamage Or critChance

        //The attack 
        public int Attack()
        {
            
            int damage = minToMax.Next(minDamage, maxDamage);
            return damage;
        }



    }
}
