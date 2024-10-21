using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    internal class Floor
    {
        public int Number { get; }
        public List<Room> Rooms { get; }

        public Floor(int number, List<Room> rooms)
        {
            Number = number;
            Rooms = rooms;
        }
    }
}
