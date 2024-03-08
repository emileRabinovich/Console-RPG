using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Shop : LocationFeature
    {
        public string shopName;
        public List<Item> items;

        public Shop(string shopName, List<Item> items) : base(false)
        {

            this.shopName = shopName;
            this.items = items;
        }

        public override void Resolve(List<Player> players)
        {
            Console.WriteLine($"Welcome to {shopName}! Buy something please I havent eaten in two weeks.");

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("BUY | SELL | TALK | LEAVE");
                string userchoice = Console.ReadLine();
                if (userchoice == "BUY")
                {
                    Console.WriteLine("Pick an item to buy:");
                    Item item = ChooseItem(this.items);
                    Player.CoinCount -= item.shopPrice;
                    Player.inventory.Add(item);

                    Console.WriteLine($"You got {item.name}!");
                }
                else if (userchoice == "SELL")
                {
                    Console.WriteLine("Pick an item to sell:");
                    Item item = ChooseItem(Player.inventory);
                    Player.CoinCount += item.sellPrice;
                    Player.inventory.Remove(item);

                    Console.WriteLine($"You gave away your {item.name}!");
                    Console.Beep(200, 1000);
                }
                else if (userchoice == "TALK")
                {
                    Console.WriteLine("Go away");
                }
                else if (userchoice == "LEAVE")
                {
                    break;
                }
            }

            Console.WriteLine("Good riddance");

        }

        public Item ChooseItem(List<Item> choices)
        {


            // Print out all the names of the people we can choose from. 
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1} {choices[i].name} ({choices[i].shopPrice})");
            }

            // TODO: Let user pick a choice.
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
        }
    }
}
