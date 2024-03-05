using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Equipment : Item
    {
        public float durability;
        public bool isEquipped;

        protected Equipment(string name, string description, int shopPrice, int sellPrice, float durability, bool isEquipped) : base(name, description, shopPrice, sellPrice)
        {
            this.durability = durability;
            this.isEquipped = isEquipped;
        }
    }

    class Armor : Equipment
    {
        public int defense;

        public Armor(string name, string description, int shopPrice, int sellPrice, float durability, bool isEquipped, int defense) : base(name, description, shopPrice, sellPrice, durability, isEquipped)
        {
            this.defense = defense;
        }

        public override void Use(Entity user, Entity target)
        {
            // Flip whether or not its equipped
            this.isEquipped = !this.isEquipped;

            if (this.isEquipped)
            {
                // If the armor is not equiped, then equip it an increase the users stats 
                target.stats.defense += this.defense;
                Console.WriteLine($"You equipped the {this.name}. Your defense increased by {this.defense}");
            }
            else
            {
                // if its already equiped then unequip it and decrease the users stats 
                target.stats.defense -= this.defense;
                Console.WriteLine($"You unequipped the {this.name}. Your defense decreased by {this.defense}");
            }

        }
    }

    class Weapon : Equipment
    {
        public int damageMultiplier;

        public Weapon(string name, string description, int shopPrice, int sellPrice, float durability, bool isEquipped, int damageMultiplier) : base(name, description, shopPrice, sellPrice, durability, isEquipped)
        {
            this.damageMultiplier = damageMultiplier;
        }

        public override void Use(Entity user, Entity target)
        {
            // Flip whether or not its equipped
            this.isEquipped = !this.isEquipped;

            if (this.isEquipped)
            {
                // If the weapon is not equiped, then equip it an increase the users stats 
                target.stats.attack += this.damageMultiplier;

                Console.WriteLine($"You eqiupped the {this.name}. Your attack increased by {this.damageMultiplier}");
            }
            else
            {
                // if the weapon is already equiped then unequip it and decrease the users stats 
                target.stats.attack -= this.damageMultiplier;
                Console.WriteLine($"You unequipped the {this.name}. Your attack decrased by {this.damageMultiplier}");
            }
        }
    }

}
