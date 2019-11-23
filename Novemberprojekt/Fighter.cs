using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fighter
    {

        //Lägg möjligtvis in strength.


        //Hur mycket liv spelaren har och vad spelaren heter.
        public int hp;
        public string namn = "";
        //Generatorn som generar skadan som spelaren gör.
        static Random generator = new Random();

        //De tre olika vapnen som man har.
        public Weapon leftHand;
        public Weapon rightHand;
        public Weapon ranged;
       
        //Metoden som räknar ut hur mycket skada du tar och ändrar ditt hp allteftersom.
        public void Hurt(int amount)
        {
            hp = hp - amount;
            
        }
        //Metoden som kollar om u är vid och returnerar false eller true.
        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else
                return false;
        }
        //Metoden som hämtar ditt nuvarande HP så att man kan kolla om du är död eller inte via if sats i Program.cs
        public int GetHealth()
        {
            return hp;
        }
        //Metoden som healer dig när du dricker en potion.
        public void Healing(int numberOfPotions)
        {
            int theHealing = generator.Next(5, 26);
            if(numberOfPotions == 0)
            {
                
            }
            else
            {
                hp = hp + theHealing;
                
            }
        }
    }
}
