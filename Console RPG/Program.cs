using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player derek = new Player("Derek", 1, 1, new Stats(attack: 1, defense: 1, magicAtk: 1,magicDef: 1));
            Enemy goblin1 = new Enemy("Grigoul", 25, 0, new Stats(attack: 1, defense: 1, magicAtk: 1,magicDef: 1), 2);
            Enemy goblin2 = new Enemy("ogsilth", 18, 10, new Stats(attack: 1, defense: 1, magicAtk: 1,magicDef: 1), 5);
            Enemy dragon1 = new Enemy("Sindriul", 1, 1, new Stats(attack: 1, defense: 1, magicAtk: 1,magicDef: 1), 10); //finish these Entities. Not Done 
            Enemy sheep1 = new Enemy("beh", 1, 1, new Stats(attack: 1, defense: 1, magicAtk: 1,magicDef: 1), 0);

            HealthPotionItem potion1 = new HealthPotionItem("Potion I", "It'll quench ya", 20, 10, 10);

            ShootingBigBoomStickItem Boom1 = new ShootingBigBoomStickItem("Boonka", "Handle carefully", 50, 30, 35, 60, 10);

            derek.UseItem(potion1, dragon1);

            derek.UseItem(Boom1, goblin1);
        }
    }
}
