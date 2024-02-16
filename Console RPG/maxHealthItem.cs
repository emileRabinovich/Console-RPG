using System;

namespace Console_RPG
{
    class maxHealthItem : Item
    {
        public int upMaxHealth;

        public maxHealthItem(string name, string description, int shopPrice, int sellPrice, int upMaxHealth) : base(name, description, shopPrice, sellPrice)
        {
            this.upMaxHealth = upMaxHealth;
        }

        public override void Use(Entity user, Entity target)
        {
            target.currentHP += this.upMaxHealth;
            Console.WriteLine(target.name + "health increased by " + upMaxHealth);
        }
    }
      

}
