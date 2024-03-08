using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Sand Town.");
            Console.WriteLine("Who Would you like to play as?");
            Console.WriteLine("Sinbad | Hercules | Kethra | Iris");
            string playerName = Console.ReadLine();



            Location.sandTown.Resolve(new List<Player>() { Player.derek });                                            
            
            Location.dinasourGraveyard.SetNearbyLocations(east: Location.oasis);

            //this would add a health potion to my inventory 
            Player.inventory.Add(HealthPotionItem.potion1);

            // this would remove a health potion from my inventory 
            Player.inventory.Remove(HealthPotionItem.potion1);

            //this would print the name of the first item in my inventory 
            Console.WriteLine(Player.inventory[0].name);

            // this would remove the first item in my inventory 
            Player.inventory.Clear();

            Player.inventory.RemoveAt(0);
        }
    }
}
