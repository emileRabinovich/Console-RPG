using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Enemy : Entity
    {
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
    }
}
