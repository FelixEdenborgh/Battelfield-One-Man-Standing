using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlerfield_One_Standing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();


            soldier warrior= new soldier();
            warrior.weapon = "Sword";
            warrior.health= 100;
            warrior.level= 3;
            warrior.damage= 5;
            warrior.name = "Sir Lancelot";
            warrior.chanse= rng.Next(1,10);


            soldier mage = new soldier();
            mage.weapon = "Magic Spells";
            mage.health= 100;
            mage.level= 3;
            mage.damage= 5;
            mage.name = "Gandalf";
            mage.chanse= rng.Next(1,10);

            
            soldier range = new soldier();
            range.weapon = "Bow";
            range.health= 100;
            range.level= 3;
            range.damage= 5;
            range.name = "Robin hood";
            range.chanse= rng.Next(1,10);

            bool end = false;

            while (end != true)
            {
                if (warrior.chanse > mage.chanse || warrior.chanse > range.chanse)
                {
                    if (warrior.chanse > mage.chanse)
                    {
                        Console.WriteLine($"The mighty Warrior {warrior.name} used his mighty {warrior.weapon} and damaged the mage {mage.name} with {warrior.damage}");
                        mage.health = mage.health - warrior.damage;
                    }
                    if (warrior.chanse > range.chanse)
                    {
                        Console.WriteLine($"The mighty Warrior {warrior.name} used his mighty {warrior.weapon} and damaged the range {range.name} with {warrior.damage}");
                        range.health = range.health - warrior.damage;
                    }
                    else if (warrior.chanse > mage.chanse && warrior.chanse > range.chanse)
                    {
                        Console.WriteLine($"The mighty Warrior {warrior.name} used his mighty {warrior.weapon} and did {warrior.damage} to both {mage.name} and {range.name} ");
                        mage.health = mage.health - warrior.damage;
                        range.health = range.health - warrior.damage;
                    }


                }
                if (mage.chanse > warrior.chanse || mage.chanse > range.chanse)
                {
                    if (mage.chanse > warrior.chanse)
                    {
                        Console.WriteLine($"The mighty Mage {mage.name} used his mighty {mage.weapon} and damaged the warrior {warrior.name} with {mage.damage}");
                        warrior.health = warrior.health - mage.damage;
                    }
                    if (mage.chanse > range.chanse)
                    {
                        Console.WriteLine($"The mighty Mage {mage.name} used his mighty {mage.weapon} and damaged the range {range.name} with {mage.damage}");
                        range.health = range.health - mage.damage;
                    }
                    else if (mage.chanse > warrior.chanse || mage.chanse > range.chanse)
                    {
                        Console.WriteLine($"The mighty Mage {mage.name} used his mighty {mage.weapon} and did {mage.damage} to both {warrior.name} and {range.name} ");
                        warrior.health = warrior.health - mage.damage;
                        range.health = range.health - mage.damage;
                    }
                }
                if (range.chanse > warrior.chanse || range.chanse > range.chanse)
                {
                    if (range.chanse > warrior.chanse)
                    {
                        Console.WriteLine($"The mighty Range {range.name} used his mighty {range.weapon} and damaged the warrior {warrior.name} with {range.damage}");
                        warrior.health = warrior.health - range.damage;
                    }
                    if (range.chanse > mage.chanse)
                    {
                        Console.WriteLine($"The mighty Range {range.name} used his mighty {range.weapon} and damaged the mage {mage.name} with {range.damage}");
                        mage.health = mage.health - range.damage;
                    }
                    else if (range.chanse > warrior.chanse || range.chanse > range.chanse)
                    {
                        Console.WriteLine($"The mighty Range {range.name} used his mighty {range.weapon} and did {range.damage} to both {warrior.name} and {mage.name} ");
                        warrior.health = warrior.health - range.damage;
                        mage.health = mage.health - range.damage;
                    }
                }
                else if(warrior.chanse == mage.chanse && warrior.chanse == range.chanse)
                {
                    Console.WriteLine("No one did any damage all 3 missed their attacks.");
                }

                if(warrior.health == 0 || mage.health == 0 || range.health == 0)
                {
                    Console.WriteLine($"Game ended!\nThe Warrior had {warrior.health} health points left \nThe Mage had {mage.health} health points left \nThe Ranger had {range.health} health points left ");
                    if (warrior.health > mage.health && warrior.health > range.health)
                    {
                        Console.WriteLine($"The Warror {warrior.name} WON!!!");
                    }
                    else if (mage.health > warrior.health && mage.health > range.health)
                    {
                        Console.WriteLine($"The Mage {mage.name} WON!!!");
                    }
                    else if(range.health > warrior.health && range.health > mage.health)
                    {
                        Console.WriteLine($"The Ranger {range.name} WON!!!");
                    }
                    else
                    {
                        Console.WriteLine("More then 1 Winner!");
                    }
                    end = true;
                }
                warrior.chanse = rng.Next(1, 10);
                mage.chanse = rng.Next(1, 10);
                range.chanse = rng.Next(1, 10);
            }
        }
    }
}
