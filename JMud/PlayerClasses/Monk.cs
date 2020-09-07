using System;
using System.Collections.Generic;

namespace JMud
{
    public class Monk : Player, IAttackable
    {
        public int BaseAttackValue { get; set; }
        public int WeaponModifiers { get; set; }
        public int BaseSpellAttackValue { get; set; }
        public int SpellDamageModifiers { get; set; }
        public List<DamageSpell> DamageSpells = new List<DamageSpell>();

        public Monk()
        {
            BaseAttackValue = GetAttackMaxValue();
            WeaponModifiers = 0;
            BaseSpellAttackValue = ReturnSpellDamage();
            MakeDamageSpellList();

        }

        public void CastDamageSpell(int spellNumber)
        {
            var spell = DamageSpells[spellNumber];
            Console.WriteLine($"{PlayerName} casts {spell.Name}...");
            Console.WriteLine($"It does {spell.DamageDone()} damage!");
        }

        public int GetAttackMaxValue()
        {
            return 10;
        }

        public int GetAttackRandom()
        {
            return 0; //TODO Finish this code!
        }

        public int ReturnSpellDamage()
        {
            return 10;
        }

        public int GetWeaponModifiers()
        {
            return 0;
        }

        public int GetSpellDamageModifiers()
        {
            return 0;
        }

        public void MakeDamageSpellList()
        {
            DamageSpells.Add(new DamageSpell("Fireblast", "A firey ball is hurled from your palm", 10));
            
        }
}
}