using System;
using Warrior.Enum;
using System.Threading;

namespace Warrior
{
    class Program
    {

        static Random rng = new Random();

        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Clearance", Faction.GoodGuy);
            Warrior badguy = new Warrior("Thango", Faction.BadGuy);

            while (goodGuy.IsAlive && badguy.IsAlive)
            {
                if(rng.Next(0, 10) < 5)
                {
                    goodGuy.attack(badguy);
                }
                else
                {
                    badguy.attack(goodGuy);
                }
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }

    }
}
