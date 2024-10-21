using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Menu
    {
        public string MainMenu()
        {
            Console.Clear();

            // Main title of the game
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("WELCOME TO THE AMAZING JOURNEY OF RPG WILDNESS");
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();

            // Backstory 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Backstory:");
            Console.WriteLine("----------");
            Console.ResetColor();
            Console.WriteLine("You just got yourself a new dungeon RPG game. You decided to play it and where you meet enemies and puzzles.");
            Console.WriteLine("But suddenly the game wont close and you are trapped. You need to find a way out of this simulation");

            // Menu questions
            Console.WriteLine();
            Console.Write("Please select 1 of the following options");
            Console.WriteLine();
            Console.WriteLine("1: Start Game");
            Console.WriteLine("2: Credits");
            Console.WriteLine("3: Quit");
            Console.WriteLine();
            Console.Write("Write here: ");
            string userInput = Console.ReadLine().ToLower();
            Console.Clear();

            // switch case based of the userinput
            string result = "";
            while (result == "")
            {
                switch (userInput)
                {
                    case "1":
                        {

                            result = "StartGame";
                            // Starts the game up

                            break;
                        }
                    case "2":
                        {
                            result = "Credit";
                            // Shows the credit for made the game

                            break;
                        }
                    case "3":
                        {
                            result = "Quit";
                            // Quits the program
                            break;
                        }
                    default:
                        {
                            // Incase the user makes a miss input
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ups! \nWrong input, please select again");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.Write("Press any key to continue: ");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }
                }
            }
            return result;
        }

        public string PathSelectionMenu(Room playerRoom, int playerX, int playerY, Floor floor)
        {
            string result = "";
            while (result == "")
            {
                // Path selection - Left, Right, Forward, Backward
                Console.WriteLine();
                Console.WriteLine("You are here " + playerRoom.RoomId);
                Console.WriteLine();
                Console.Write("Select your path");
                Console.WriteLine();
                Console.WriteLine("1: Move Left");
                Console.WriteLine("2: Move Right");
                Console.WriteLine("3: Move Forward");
                Console.WriteLine("4: Move Backward");
                Console.WriteLine();
                Console.Write("Write here: ");
                string userInput = Console.ReadLine();
                Console.Clear();


                int maxX = floor.Rooms.GetLength(0);
                int maxY = floor.Rooms.GetLength(1);

                // switch case based of the userinput
                switch (userInput)
                {

                    case "1":
                        {
                            // Left
                            if (playerX > 0 && floor.Rooms[playerX - 1, playerY] != null)
                            {
                                result = "MoveLeft";
                            }
                            else
                            {
                                // Incase the user makes a miss input
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ups! \nWrong input, Room location does not exist");
                                Console.WriteLine("There is no room to your left");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.Write("Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        }
                    case "2":
                        {
                            // Right
                            if (playerX < maxX && floor.Rooms[playerX + 1, playerY] != null)
                            {
                                result = "MoveRight";
                            }
                            else
                            {
                                // Incase the user makes a miss input
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ups! \nWrong input, Room location does not exist");
                                Console.WriteLine("There is no room to your right");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.Write("Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        }
                    case "3":
                        {
                            // Forward
                            if (playerY > 0 && floor.Rooms[playerX, playerY - 1] != null)
                            {
                                result = "MoveForward";
                            }
                            else
                            {
                                // Incase the user makes a miss input
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ups! \nWrong input, Room location does not exist");
                                Console.WriteLine("There is no room infront of you");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.Write("Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        }
                    case "4":
                        {
                            // Backward
                            if (playerX < maxY && floor.Rooms[playerX, playerY + 1] != null)
                            {
                                result = "MoveBackward";
                            }
                            else
                            {
                                // Incase the user makes a miss input
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ups! \nWrong input, Room location does not exist");
                                Console.WriteLine("There is no room behind you");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.Write("Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            break;
                            
                        }
                    default:
                        {
                            // Incase the user makes a miss input
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ups! \nWrong input, please select again");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.Write("Press any key to continue: ");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }


                }

            }
            return result;
        }
    }
}
