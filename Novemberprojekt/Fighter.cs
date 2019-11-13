using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fighter
    {

        //Lägg möjligtvis in strength och eller crit.
        private int hp = 50;
        public string namn = "";
        static Random generator = new Random();

        public Weapon leftHand;
        public Weapon rightHand;
        public Weapon ranged;
       
        public void Hurt(int amount)
        {
            hp -= amount;
            
        }
        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else
                return false;
        }
        public int GetHealth()
        {
            return hp;
        }
    }
}
