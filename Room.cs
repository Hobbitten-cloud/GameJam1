using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Room
    {
        public Trial Trial { get; }

        public string RoomId { get; }

        public Room (Trial trial, string roomId)
        {
            Trial = trial;
            RoomId = roomId;
        } 
    }
}
