namespace JMud
{
    public class Armor : Item
    {
        public Armor()
        {
            
        }
        public override Item GetRandomItem()
        {
            return new Armor();
        }
    }
}