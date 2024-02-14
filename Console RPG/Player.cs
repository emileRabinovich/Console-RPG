using System;
using System.Collections.Generic;

namespace Console_RPG
{
    //inheritance. the thwo classes player and enemy are inheriting the variables in the Entity class.
    class Player : Entity
    {
        //calling base constructor!
        public Player(string name, int hp, int mana, Stats stats) : base(name,hp,mana,stats) { }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            // you guys need to figure out how to let the player choose who to attack. 
            return choices[0];
        }

        public override void Attack(Entity target)
        {
            // calcu
            Console.WriteLine(this.name + "attacked " + target.name + "!");
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}
