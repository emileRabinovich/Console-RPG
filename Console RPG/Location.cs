using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public static Location sandTown = new Location("Sand Town", "A hub for traders and travelers in the dry desert.");
        public static Location desertCastle = new Location("Desert Castle", "Be aware of the power that lays behind these walls.");  
        public static Location oasis = new Location("The Oasis", "Its glisening waters are the perfect resting spot for weary travelers.");
        public static Location dinasourGraveyard = new Location("Dinasour Graveyard", "There's an ominous feel about the place.", new Battle(new List<Enemy>() { Enemy.goblin1, Enemy.goblin2, Enemy.dragon1 }));

        public string name;
        public string description;
        public Battle battle;

        public Location north, east, south, west;

        public Location(string name, string description, Battle battle = null)
        {
            this.name = name;
            this.description = description;
            this.battle = battle;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            
            if (!(north is null))
            {
                this.north = north;
                north.south = this;
            }
                
            if (!(east is null))
            {
                this.east = east;
                east.west = this;
            }
                
            if (!(south is null))
            {
                this.south = south;
                south.north = this;
            }
                     
            if (!(west is null))
            {
                this.west = west;
                west.east = this;
            }
               
        }

        public void Resolve(List<Player> players)
        {
            Console.WriteLine("You find yourself in " + this.name + ".");
            Console.WriteLine(this.description);

            // Null checking to make sure there is a battle to resolve.
            battle?.Resolve(players);

            Location nextLocation = null;

            while (nextLocation is null)
            {
                if (!(north is null))
                {
                    Console.WriteLine("NORTH: " + this.north.name);
                }
                if (!(east is null))
                {
                    Console.WriteLine("EAST: " + this.east.name);
                }
                if (!(south is null))
                {
                    Console.WriteLine("SOUTH: " + this.south.name);
                }
                if (!(west is null))
                {
                    Console.WriteLine("WEST: " + this.west.name);
                }

                string direction = Console.ReadLine();
                



                if (direction.Contains("north"))
                {
                    nextLocation = this.north;

                }
                if (direction.Contains("east"))
                {
                    nextLocation = this.east;
             
                }
                if (direction.Contains("south"))
                {
                    nextLocation = this.south;
                
                }
                if (direction.Contains("west"))
                {
                    nextLocation = this.west;
             
                }
                else
                {
                    Console.WriteLine("You must write either north, east, south, or west.");
                }
            }
            

            nextLocation.Resolve(players);
        }
    }
}