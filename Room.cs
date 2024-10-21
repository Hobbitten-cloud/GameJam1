using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Room
    {
        public void RoomNames()
        {
            // Room names
            string[] roomName =
            [
                "Room 1:",
                "Room 2:",
                "Room 3:",
                "Room 4:",
                "Room 5:",
                "Room 6:"
            ];
            Console.WriteLine(roomName[0]);
        }

        public void RoomInfo()
        {
            // Room information
            string[] roomInfo =
            [
                "You are trapped. \nOn the left there is a room full of gold",
                    "Linda",
                    "Ida",
                    "Jonas",
                    "Bob",
                    "Nicklas"
            ];
            Console.WriteLine(roomInfo[0]);
        }
    }
}
