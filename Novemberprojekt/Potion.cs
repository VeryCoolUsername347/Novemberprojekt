using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Potion
    {
        public int amount = 3;

        public int Drink()
        {
            if (amount >= 1)
            {
                amount--;
                return 1;
            }
            else
            {
               
                return 0;
            }
           
        }

    }

}
