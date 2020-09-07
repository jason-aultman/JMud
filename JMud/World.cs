using System;

namespace JMud
{
    
    public class World
    {
        public int RoomXDimensions { get; set; }
        public int RoomYDimensions { get; set; }
        public  Room[,] roomArray; 

        public World(int sizeX, int sizeY)
        {
            RoomXDimensions = sizeX;
            RoomYDimensions = sizeY;
            roomArray = new Room[RoomXDimensions,RoomYDimensions];
            FillRoomArray();
        }


        private void FillRoomArray()
        {
            for (int y = 0; y < RoomYDimensions; y++)
            {
                for (int x = 0; x < RoomXDimensions; x++)
                {
                    roomArray[x,y] = new Room();
                }
            }
        }
        
    }
}