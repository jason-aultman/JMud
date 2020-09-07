namespace JMud
{
    public class Weapon : Item
    {
        public override Item GetRandomItem()
        {
            return new Weapon();
        }
    }
}