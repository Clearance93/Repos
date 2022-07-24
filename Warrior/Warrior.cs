
using Warrior.Enum;
using Warrior.Equipment;
using System;


namespace Warrior
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 1000;
        private const int BAD_GUY_STARTING_HEALTH = 1000;

        private readonly Faction Faction;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive 
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            Faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoint;

            enemy.health -= damage;

            Attack(enemy, damage);

            //Console.ReadLine();
        }

        private void Attack(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. The {damage} damege was inflicted {enemy.name}, remaining health {enemy.name} is {enemy.health}");
            }
            
        }
        
    }
}
