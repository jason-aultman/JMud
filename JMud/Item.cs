using System;

namespace JMud
{
    public abstract class Item
    {
        public string description = "This is an item";
        public virtual Item GetRandomItem()
        {
            var random = new Random();
            var choice = random.Next(1, 2);
            switch (choice)
            {
                case 1 :
                    return Armor.GetRandomItem();
                    break;
                case 2:
                    return new Weapon();
                    break;
                default:
                    return null;
                    break;
                
            }
        }
    }
}