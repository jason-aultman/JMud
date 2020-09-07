using System;
using System.Collections.Generic;

namespace JMud
{
    public class Room
    {
        public Door Exit { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        private List<Item> Contents;
        
        public Room()
        {
            Exit = new Door();
            Exit.IsOpen = false; //TODO Add some random functionality to whether door is open or closed
            Exit.IsLocked = false; //TODO Add some functionality to whether door is locked or unlocked
            Contents=new List<Item>();
            Contents = GetRoomContents();

        }

        public List<Item> GetRoomContents()
        {
            var randomNumber = new Random();
            var randomNumb=randomNumber.Next(1, 4);
            for (int i = 1; i < 3; i++)
            {
                Contents.Add(new Armor());
            }

            return Contents;

        }
    }
}