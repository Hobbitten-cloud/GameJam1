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
        public string Ca { get; set; }

        public Room (Trial trial, string roomId, string ca)
        {
            Trial = trial;
            RoomId = roomId;
            Ca = ca;
        }
    }
}
