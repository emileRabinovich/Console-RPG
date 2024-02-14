﻿using System;

namespace Console_RPG
{
    class ShootingBigBoomStickItem : Item
    {
        public int damage;
        public int durability;
        public int ammo;

        public ShootingBigBoomStickItem(string name, string description, int shopPrice, int sellPrice, int damage, int durability, int ammo) : base(name, description, shopPrice, sellPrice)
        {
            this.damage = damage;
            this.durability = durability;
            this.ammo = ammo;
        }
       
        public override void Use(Entity user, Entity target)
        {
            if (this.ammo == 0)
                return;

            target.currentHP -= damage;
            --ammo;

            Console.WriteLine(target.name + " took " + damage + " damage.");

            if (target.currentHP <= 0)
                Console.WriteLine(target.name + " died");
        }
        
    }
}
