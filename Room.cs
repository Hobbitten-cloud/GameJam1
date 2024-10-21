using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Room
    {
        public List<Trial> Trial { get; }
        public int Index { get; set; }
        public string RoomId { get; }
        public string Obstacle {  get; }

        public Room (List<Trial> trial, int index, string roomId, string obstacle)
        {
            Trial = trial;
            Index = index;
            RoomId = roomId;
            Obstacle = obstacle;
        } 
    }
}
