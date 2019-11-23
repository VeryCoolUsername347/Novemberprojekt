using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Weapon
    {
        //Högsta och minsta skadan som vapnet kan göra.
        public int maxDamage;
        public int minDamage;
        //Hur hög chans vapnet har att göra mer skada och hur mycket mer skada den kommer göra.
        public int critChance;
        public int bonusCritDamage;
        //Vad vapnet heter.
        public string name;
        //Generatorn som slumpar ett nummer mellan den minsta damagen som vapnet kan göra och det högsta.
        Random generator = new Random();


        public bool DoesItCrit()
        {
            if (generator.Next(1, 101) >= critChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        //Attacken som vapnet gör.
        public virtual int Attack()
        {
            
            int damage = generator.Next(minDamage, maxDamage);
            if (DoesItCrit())
            {
                return damage + bonusCritDamage;
            }
            else
            {
                return damage;

            }
        }



    }
}
