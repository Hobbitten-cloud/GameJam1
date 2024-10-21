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

        public int PlayerX { get; set; }
        public int PlayerY { get; set; }

        public Room PlayerRoom{ get; set; }

        public Controller (Menu menu, Floor floorObjective, Player playerOjective)
        {
            Menu = menu;
            FloorObjective = floorObjective;
            PlayerOjective = playerOjective;

            PlayerX = 0;
            PlayerY = 0;

            PlayerRoom = floorObjective.Rooms[PlayerX, PlayerY];

        }

        public void MoveRight()
        {
            PlayerX++;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
        }

        public void MoveLeft()
        {
            PlayerX--;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
        }

        public void MoveForward()
        {
            PlayerY--;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
        }

        public void MoveBackward()
        {
            PlayerY++;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
        }

    }
}
