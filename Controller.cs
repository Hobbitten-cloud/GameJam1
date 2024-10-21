using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Controller
    {
        public Menu Menu { get; } 
        public Floor FloorObjective {  get; }
        public Player PlayerOjective { get; }

        public Controller (Menu menu, Floor floorObjective, Player playerOjective)
        {
            Menu = menu;
            FloorObjective = floorObjective;
            PlayerOjective = playerOjective;
        }
    }
}
