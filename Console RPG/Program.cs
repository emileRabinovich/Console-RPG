using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Location.dinasourGraveyard.Resolve(new List<Player>() { Player.derek });                                            
            
            Location.dinasourGraveyard.SetNearbyLocations(east: Location.oasis);

            int numberOfWizards = 24;

            Console.WriteLine($"there are {numberOfWizards}");

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
