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

        }
    }
}
