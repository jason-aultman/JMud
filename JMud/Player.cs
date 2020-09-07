using System;

namespace JMud
{
    public abstract class Player
    {
        public int Health { get; set; }
        public int BaseArmor { get; set; }
        public string PlayerName { get; set; }
        public ArmorClass ArmorClass;
        public PlayerClass PlayerClass;

        public Player()
        {
            GetPlayerName();
        }

        private string GetPlayerName()
        {
            Console.WriteLine("What shall you be called?");
            return Console.ReadLine();
        }

       
       
       
    }
}