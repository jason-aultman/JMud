using System;
using System.Collections.Generic;

namespace JMud
{
    public abstract class Player
    {
        public int Health { get; set; }
        public int BaseArmor { get; set; }
        public List<Armor> PLayerArmor;
        public string PlayerName { get; set; }
        public ArmorClass ArmorClass;
        public PlayerClass PlayerClass;

        public Player()
        {
            this.PLayerArmor = new List<Armor>();
            GetPlayerName();
        }

        private string GetPlayerName()
        {
            Console.WriteLine("What shall you be called?");
            return Console.ReadLine();
        }

       
       
       
    }
}