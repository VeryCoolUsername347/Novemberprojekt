﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Dagger : Weapon
    {
        public Dagger()
        {
            minDamage = 1;
            maxDamage = 11;
            critChance = 25;
            bonusCritDamage = 15;
            name = "Dagger";

        }

    }
}
