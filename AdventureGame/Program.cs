using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just trying some stuff and checking if it works as i think.

            Character player = new Character("Blewboar", 100, 50);
            Character enemy = new Character("Alkaizer", 500, 1);
            Console.WriteLine("Player object has:\nname: {0}\nHealth: {1}\nAttack: {2}", player.Name, player.Health, player.Attack);
            Console.WriteLine("Enemy object has:\nname: {0}\nHealth: {1}\nAttack: {2}", enemy.Name, enemy.Health, enemy.Attack);

            Console.WriteLine(enemy);
            Console.WriteLine(player);
            
            Console.ReadLine(); // Anti-close


        }
    }

    class Character // basic class for any entity in game, will add more properties later.
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public Character(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }
            

    }
}
