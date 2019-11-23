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
            //Alla variablar och klasser som jag behöver här.
            bool namingSection = true;
            bool pickingAttack = false;
            bool fighting = true;
            string nameOne = "";
            string nameTwo = "";
            string weaponPick = "";
            Fighter a = new Warrior();
            Fighter b = new Assassin();
            Potion p1Potion = new Potion();
            Potion p2Potion = new Potion();
            a.leftHand = new Sword();
            a.rightHand = new Dagger();
            a.ranged = new Bow();
            b.leftHand = new Sword();
            b.rightHand = new Dagger();
            b.ranged = new Bow();
            int p1Damage = 0;
            int p2Damage = 0;
            int theWeaponThatIsPicked = 0;







            while (namingSection == true)
            {
                Console.WriteLine("The name can be any length, but it has to be characters");
                Console.WriteLine("Enter the name for player one, the warrior.");
                nameOne = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("The name can be any length, but it has to be characters");
                Console.WriteLine("Enter the name for player two, the assassin.");
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

            Console.WriteLine(nameOne + " is the warrior!");
            Console.WriteLine(nameTwo + " is the assassin!");



            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            while (fighting)
            {



                while (pickingAttack == false)
                {
                    Console.Clear();
                    Console.WriteLine(nameOne + ", Choose your action!");
                    Console.WriteLine("1. Right hand: Sword");
                    Console.WriteLine("2. Left hand: Dagger");
                    Console.WriteLine("3. Ranged weapon: Bow");
                    //Console.WriteLine("4. Drink potion. Amount: "+p1Potion.amount);
                    Console.WriteLine("5. Commit die.");
                    weaponPick = Console.ReadLine();

                    int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    pickingAttack = int.TryParse(weaponPick, out theWeaponThatIsPicked);

                    if (theWeaponThatIsPicked < 1 || theWeaponThatIsPicked > 5)
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
                else if (theWeaponThatIsPicked == 4)
                {
                    if (p1Potion.Drink() == 1)
                    {
                        p1Damage = -1;
                    }
                    else if (p1Potion.Drink() == 0)
                    {
                        Console.WriteLine("You fumble about and realize that you don't have any potions left!");
                    }

                }
                else if (theWeaponThatIsPicked == 5)
                {
                    Console.WriteLine("You died!");
                    System.Threading.Thread.Sleep(1000);
                    return;
                }




                if (p1Damage == 0)
                {
                    Console.WriteLine("You missed the shot!");
                }
                else if(p1Damage > 0)
                {
                    Console.WriteLine("You deal " + p1Damage + " damage!");
                    b.Hurt(p1Damage);
                    
                }
                else if (p1Damage == -1)
                {
                    a.Healing(p1Potion.Drink());
                    Console.WriteLine("You restored some health!");
                    Console.WriteLine("Hp: "+a.hp);
                    
                }
                Console.ReadLine();
                pickingAttack = false;


                if (b.IsAlive() == false)
                {
                    fighting = false;
                    Console.WriteLine("Congratulations! " + nameOne + " won!");
                    Console.ReadLine();
                    return;
                }
             



                while (pickingAttack == false)
                {
                    Console.Clear();
                    Console.WriteLine(nameTwo + ", Choose your attack!");
                    Console.WriteLine("1. Right hand: Sword");
                    Console.WriteLine("2. Left hand: Dagger");
                    Console.WriteLine("3. Ranged weapon: Bow");
                    //Console.WriteLine("4. Drink potion. Amount: " + p2Potion.amount);
                    Console.WriteLine("5. Commit die.");


                    weaponPick = Console.ReadLine();
                    int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    pickingAttack = int.TryParse(weaponPick, out theWeaponThatIsPicked);
                    if (theWeaponThatIsPicked < 1 || theWeaponThatIsPicked > 5)
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
                else if (theWeaponThatIsPicked == 4)
                {
                    if (p2Potion.Drink() == 1)
                    {
                        p2Damage = -1;
                    }
                    else if (p2Potion.Drink() == 0)
                    {
                        Console.WriteLine("You fumble about and realize that you don't have any potions left!");
                    }

                }
                else if (theWeaponThatIsPicked == 5)
                {
                    Console.WriteLine("You died!");
                    System.Threading.Thread.Sleep(1000);
                    return;
                }

                if (p2Damage == 0)
                {
                    Console.WriteLine("You missed the shot!");
                }
                else if(p2Damage > 0)
                {
                    Console.WriteLine("You deal " + p2Damage + " damage!");
                    a.Hurt(p2Damage);
                }
                else if (p1Damage == -1)
                {
                    b.Healing(p2Potion.Drink());
                    Console.WriteLine("You restored some health!");
                    Console.WriteLine("Hp: " + b.hp);

                }

                Console.ReadLine();
                if (a.IsAlive() == false)
                {
                    fighting = false;
                    Console.WriteLine("Congratulations! " + nameTwo + " won!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    
                    
                    Console.WriteLine(nameOne+" has " + a.hp + " hp left.");
                    Console.WriteLine(nameTwo+" has " + b.hp + " hp left.");
                    Console.ReadLine();
                    pickingAttack = false;
                }





            }





        }
        static bool IsNumbers(string input)
        {
            bool validName = input.All(char.IsDigit);
            return validName;
        }
    }
}
