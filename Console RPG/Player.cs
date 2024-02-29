﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    //inheritance. the thwo classes player and enemy are inheriting the variables in the Entity class.
    class Player : Entity
    {
        public static List<Item> inventory = new List<Item>()
        {
            HealthPotionItem.potion1
        };

        public static Player derek = new Player("Derek", 85, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1));
        public static Player player1 = new Player("Sindbad", 85, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1));
        public static Player player2 = new Player("Herculese", 90, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1));
        public static Player player3 = new Player("Kethra", 70, 1, new Stats(attack: 1, defense: 1, magicAtk: 1, magicDef: 1));

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

        public Item ChooseItem(List<Item> choices)
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
            // Figure out how to do damage to the target. If you can't, then you're bad.
            Console.WriteLine(this.name + "attacked " + target.name + "!");
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            // Prompt the user on what to do. 
            Console.WriteLine("what do you want to do?");
            Console.WriteLine("ATTACK | ITEM");
            string choice = Console.ReadLine();

            // If the user types ATTACK.
            if (choice == "ATTACK")
            {
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                Attack(target);
            }
            
            else if (choice == "ITEM")
            {
                Item item = ChooseItem(inventory);
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());

                Item.Use(this, target);
                inventory.Remove(item);
            }
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}