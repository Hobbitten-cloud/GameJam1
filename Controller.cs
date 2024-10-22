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
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "#";
            PlayerX++;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "O";
        }

        public void MoveLeft()
        {
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "#";
            PlayerX--;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "O";
        }

        public void MoveForward()
        {
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "#";
            PlayerY--;
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "O";
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
        }

        public void MoveBackward()
        {
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "#";
            PlayerY++;
            PlayerRoom = FloorObjective.Rooms[PlayerX, PlayerY];
            FloorObjective.Rooms[PlayerX, PlayerY].Ca = "O";
        }
    }
}
