using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    //inheritance. the thwo classes player and enemy are inheriting the variables in the Entity class.
    class Player : Entity
    {

        public static Player derek = new Player("Derek", 1, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1));

        //calling base constructor!
        public Player(string name, int hp, int mana, Stats stats) : base(name,hp,mana,stats) { }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            Console.WriteLine("Please pick an enemy to attack:");

            // Print out all the names of the people we can choose from. 
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1} {choices[i].name}");
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
        }

        public override void Attack(Entity target)
        {
            // Figure out how to do damage to the target. If you can't, then your bad.
            Console.WriteLine(this.name + "attacked " + target.name + "!");
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}
