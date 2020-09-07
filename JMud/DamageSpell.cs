using System;

namespace JMud
{
    public class DamageSpell: Spell
    {
        public int MaxDamage { get; set; }
        public DamageSpell(string name, string description, int baseDamage) : base()
        {
            base.Name = name;
            base.Description = description;
            MaxDamage = baseDamage;
        }
        public int DamageDone()
        {
            return new Random().Next(0,MaxDamage);
        }
    }
}