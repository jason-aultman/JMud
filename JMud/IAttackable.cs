namespace JMud
{
    public interface IAttackable
    {
        public int BaseAttackValue { get; set; }
        public int WeaponModifiers { get; set; }
        public int BaseSpellAttackValue { get; set; }
        public int SpellDamageModifiers { get; set; }
        
        public int GetAttackMaxValue();
        public int GetAttackRandom();
        public int ReturnSpellDamage();
        public int GetWeaponModifiers();
        public int GetSpellDamageModifiers();
    }
}