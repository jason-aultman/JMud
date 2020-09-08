namespace JMud
{
    public class Armor : Item
    {
        public int Slot { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ArmorValue { get; set; }
        
        public Armor(int slot, string name, string description, int armorValue)
        {
            Slot = slot;
            Name = name;
            Description = description;
            ArmorValue = armorValue;

        }
        public static Item GetRandomItem()
        {
            return new Armor(0, "Leather Cap", "A basic leather cap", 5);
        }
    }
}