using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Floor
    {
        public int Number { get; }
        public Room[,] Rooms { get; }

        public Floor(int number, Room[,] rooms)
        {
            Number = number;
            Rooms = rooms;
        }
    }
}
