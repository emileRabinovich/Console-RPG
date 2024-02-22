using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {

        public static Enemy goblin1 = new Enemy("Grigoul", 25, 0, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1), 2);
        public static Enemy goblin2 = new Enemy("ogsilth", 18, 10, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1), 5);
        public static Enemy dragon1 = new Enemy("Sindriul", 1, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1), 10); //finish these Entities. Not Done 
        public static Enemy sheep1 = new Enemy("beh", 1, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1), 0);
        public static Enemy kaleb = new Enemy("kaleb", 30, -20, new Stats(), -20);
        public static Enemy will = new Enemy("will", -50, 30, new Stats(), 10);
        public static Enemy jackson = new Enemy("jackson", 2, 3, new Stats(), 30);

        //calling base constructor, then doing enemy specific stuff! the only enemy specific thing so far is the coinsDroppedOnDeath variable.
        public int coinsDroppedOnDeath;
        public Enemy(string name, int hp, int mana, Stats stats, int coinsDroppedOnDeath) : base(name, hp, mana, stats)
        {
            this.coinsDroppedOnDeath = coinsDroppedOnDeath;
        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            //using a random object lets us specify a seed to make consistent runs. 
            Random random = new Random();
            return choices[random.Next(choices.Count)];
        }

        public override void Attack(Entity target)
        {
            // calcu
            Console.WriteLine(this.name + "attacked " + target.name + "!");
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
