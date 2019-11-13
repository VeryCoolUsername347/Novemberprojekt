using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {

            bool namingSection = true;
            bool pickingAttack = false;
            bool fighting = true;
            string nameOne = "";
            string nameTwo = "";
            string weaponPick = "";
            Fighter a = new Fighter();
            Fighter b = new Fighter();
            int p1Health = a.GetHealth();
            int p2Health = b.GetHealth();
            int p1Damage = 0;
            int p2Damage = 0;
            int theWeaponThatIsPicked = 0;
            a.leftHand = new Sword();
            a.rightHand = new Dagger();
            a.ranged = new Bow();
            b.leftHand = new Sword();
            b.rightHand = new Dagger();
            b.ranged = new Bow();






            while (namingSection == true)
            {
                Console.WriteLine("The name can be any length, but it has to be characters");
                Console.WriteLine("Hello, please enter the name for your first fighter.");
                nameOne = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("The name can be any length, but it has to be characters");
                Console.WriteLine("Please enter the name for the second fighter.");
                nameTwo = Console.ReadLine();

                if (IsNumbers(nameOne) == false || IsNumbers(nameTwo) == false)
                {
                    namingSection = false;
                }
                else
                {
                    Console.WriteLine("Non-valid name input detected. Please try again.");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                }
            }

            Console.WriteLine(nameOne + " Is the first fighter!");
            Console.WriteLine(nameTwo + " Is the second fighter!");



            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            while (fighting)
            {

                

                while (pickingAttack == false)
                {
                    Console.Clear();
                    Console.WriteLine(nameOne + ", Choose your attack!");
                    Console.WriteLine("1. Right hand: Sword");
                    Console.WriteLine("2. Left hand: Dagger");
                    Console.WriteLine("3. Ranged weapon: Bow");

                    
                    weaponPick = Console.ReadLine();
                    int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    pickingAttack = int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    if (theWeaponThatIsPicked < 1 || theWeaponThatIsPicked > 3)
                    {
                        Console.WriteLine("Incorrect input!");
                        Console.ReadLine();
                        pickingAttack = false;
                    }
                    else
                    {
                        pickingAttack = true;

                    }

                }

                

                if (theWeaponThatIsPicked == 1)
                {
                    p1Damage = a.rightHand.Attack();
                    
                }
                else if (theWeaponThatIsPicked == 2)
                {
                    p1Damage = a.leftHand.Attack();
                    
                }
                else if (theWeaponThatIsPicked == 3)
                {
                    p1Damage = a.ranged.Attack();
                    
                }
                Console.WriteLine("You deal " + p1Damage + " damage!");
                b.Hurt(p1Damage);

                Console.ReadLine();
                pickingAttack = false;



                while (pickingAttack == false)
                {
                    Console.Clear();
                    Console.WriteLine(nameTwo + ", Choose your attack!");
                    Console.WriteLine("1. Right hand: Sword");
                    Console.WriteLine("2. Left hand: Dagger");
                    Console.WriteLine("3. Ranged weapon: Bow");


                    weaponPick = Console.ReadLine();
                    int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    pickingAttack = int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    if (theWeaponThatIsPicked < 1 || theWeaponThatIsPicked > 3)
                    {
                        Console.WriteLine("Incorrect input!");
                        Console.ReadLine();
                        pickingAttack = false;
                    }
                    else
                    {
                        pickingAttack = true;

                    }

                }

                if (theWeaponThatIsPicked == 1)
                {
                    p2Damage = a.rightHand.Attack();

                }
                else if (theWeaponThatIsPicked == 2)
                {
                    p2Damage = a.leftHand.Attack();

                }
                else if (theWeaponThatIsPicked == 3)
                {
                    p2Damage = a.ranged.Attack();

                }
                Console.WriteLine("You deal " + p2Damage + " damage!");
                a.Hurt(p2Damage);
                Console.ReadLine();
                













                if (b.IsAlive() == false)
                {
                    fighting = false;
                    Console.WriteLine("Congratulations! " + nameOne + " won!");
                    Console.ReadLine();
                }
                else if (a.IsAlive() == false)
                {
                    fighting = false;
                    Console.WriteLine("Congratulations! " + nameTwo + " won!");
                    Console.ReadLine();
                }
                else
                {
                    p2Health = b.GetHealth();
                    p1Health = a.GetHealth();

                    Console.WriteLine("Player one has " + p1Health + " hp left.");
                    Console.WriteLine("Player two has " + p2Health + " hp left.");
                    Console.ReadLine();
                    pickingAttack = false;
                }
                


               

            }





        }
        static bool IsNumber(string input)
        {
            int result;
            bool success = int.TryParse(input, out result);
            return success;

        }
        static bool IsNumbers(string input)
        {
            bool validName = input.All(char.IsDigit);
            return validName;
        }
    }
}
