using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public string name;
        public string description;

        public Location north, east, south, west;

        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;

            if (!(north is null))
                north.south = this;

            if (!(east is null))
                east.west = this;

            if (!(south is null))
                south.north = this;

            if (!(west is null))
                west.east = this;
        }

        public void Resolve()
        {
            Console.WriteLine("You find yourself in " + this.name + ".");
            Console.WriteLine(this.description);

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
            Location nextLocation = null;

            // What happens if the user input isn't north, south, east, or west?

            if (direction.Contains("north"))
                nextLocation = this.north;
            if (direction.Contains("east"))
                nextLocation = this.east;
            if (direction.Contains("south"))
                nextLocation = this.south;
            if (direction.Contains("west"))
                nextLocation = this.west;
            if (direction.Contains("wrong"))
                Console.WriteLine("You must write either north, east, south, or west.");

            nextLocation.Resolve();
        }
    }
}