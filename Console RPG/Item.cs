using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {

        public static HealthPotionItem potion1 = new HealthPotionItem("Potion I", "It'll quench ya", 20, 10, 10);
        ShootingBigBoomStickItem Boom1 = new ShootingBigBoomStickItem("Boonka", "Handle carefully", 50, 30, 35, 60, 10);

        public string name;
        public string description;
        public int shopPrice;
        public int sellPrice;

        public Item(string name, string description, int shopPrice, int sellPrice)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.sellPrice = sellPrice;
        }

        public abstract void Use(Entity user, Entity target);
    }
}
