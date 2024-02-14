using System;

namespace Console_RPG
{
    class HealthPotionItem : Item
    {
        public int healAmount;

        public HealthPotionItem(string name, string description, int shopPrice, int sellPrice, int healAmount) : base(name, description, shopPrice, sellPrice)
        {
            this.healAmount = healAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            target.currentHP += this.healAmount;
            Console.WriteLine(target.name + " healed by " + healAmount);
        }


    }
}
