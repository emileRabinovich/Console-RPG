using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle
    {
        public List<Enemy> enemies;
        public bool isResolved;

        public Battle(List<Enemy> enemies)
        {
            this.enemies = enemies;
            this.isResolved = false;
        }

        public void Resolve(List<Player> players)
        {
            // loop the turn system.
            while (true)
            {
                // loop through all the players 
                foreach (var player in players)
                {
                    if (player.currentHP > 0)
                    {
                        Console.WriteLine("It is " + player.name + "'s turn.");
                        player.DoTurn(players, enemies);
                    }
                }

                foreach (var enemy in enemies)
                {
                    if (enemy.currentHP > 0)
                    {
                        Console.WriteLine("It is " + enemy.name + "'s turn.");
                        enemy.DoTurn(players, enemies);
                    }
                }


                // If the players lose...
                if (players.TrueForAll(player => player.currentHP <= 0))
                {
                    Console.WriteLine("You died. You're almost as bad as Jack Mezaros.");
                    break;
                }


                // If the players win...
                if (players.TrueForAll(player => player.currentHP <= 0))
                {
                    Console.WriteLine("You win. Thats definately something Jack Mezaros couldn't do.");
                    break;
                    // Add calculations for adding money to your purse.  
                }
            }

            // Add code here for things to happen regardless of who wins.
            Console.WriteLine("Battle over.");
        }
    }
}
