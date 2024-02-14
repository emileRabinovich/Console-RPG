using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{

    abstract class Entity
    {
        public string name;

        public int currentHP, maxHP;
        public int currentMana, MaxMana;

        public Stats stats;

        public Entity(string name, int hp, int mana, Stats stats)
        {
            this.name = name;
            this.currentHP = hp;
            this.maxHP = hp;
            this.currentMana = mana;
            this.MaxMana = mana;
            this.stats = stats;
        }

        public abstract Entity ChooseTarget(List<Entity> choices);
        public abstract void Attack(Entity target);
    }
}
