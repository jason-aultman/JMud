using System;
using System.Drawing;

namespace JMud
{
    class Game
    {
        static void Main(string[] args)
        {
            Point worldSize = new Point();
            worldSize.X = 4;
            worldSize.Y = 4;
            var world = SetupGame(worldSize);
            var count = 1;
            var playerClass = GetPLayerClass();
            do
            {

                Console.WriteLine(FileHandler.GetRoomDataFromFile(@"C:\Users\jason\RiderProjects\JMud\JMud\RoomObjectDescriptions\0001.txt"));
                Console.WriteLine($"Room contains: {}");
                Monk player = new Monk();
                player.Health = 50;
                player.PlayerClass = playerClass;
                player.ArmorClass = ArmorClass.Leather;
                
                player.CastDamageSpell(0);
                player.CastDamageSpell(1);
                player.CastDamageSpell(2);
                



            } while (false);
            
            

        } //End of Main()
        static World SetupGame(Point worldSize)
        {
            var world = new World(worldSize.X,worldSize.Y);
            return world;
        }
        public static PlayerClass GetPLayerClass()
        {
            Console.WriteLine("What class will you be playing?");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Assassin");
            Console.WriteLine("3. Monk");
            Console.WriteLine("4. Fighter");
            Console.WriteLine("5. Paladin");
            var selection = Console.ReadLine();
            var SelectionAsInt = int.Parse(selection);
            switch (SelectionAsInt)
            {
                case 1:
                    return PlayerClass.Mage;
                    break;
                case 2:
                    return PlayerClass.Assassin;
                    break;
                case 3:
                    return PlayerClass.Monk;
                    break;
                case 4:
                    return PlayerClass.Fighter;
                    break;
                case 5 :
                    return PlayerClass.Paladin;
                    break;
                default: 
                    return GetPLayerClass();
                    break;
            }

        }

        
    }
}