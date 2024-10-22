using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Menu
    {
        public string MainMenu()
        {
            string result = "";
            while (result == "")
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
            //Console.Clear();

            // switch case based of the userinput
            
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
                            //Console.Clear();

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
                int maxX = floor.Rooms.GetLength(0) - 1;  // Adjust max index for zero-based arrays
                int maxY = floor.Rooms.GetLength(1) - 1;

                // Display room info and options
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are here in Room: " + playerRoom.RoomId);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Select your path:");

                // Create a list of available options
                List<string> options = new List<string>();

                if (playerX > 0 && floor.Rooms[playerX - 1, playerY] != null)
                {
                    options.Add("Move Left");
                }
                if (playerX < maxX && floor.Rooms[playerX + 1, playerY] != null)
                {
                    options.Add("Move Right");
                }
                if (playerY > 0 && floor.Rooms[playerX, playerY - 1] != null)
                {
                    options.Add("Move Up");
                }
                if (playerY < maxY && floor.Rooms[playerX, playerY + 1] != null)
                {
                    options.Add("Move Down");
                }

                // Show the options to the player
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {options[i]}");
                }

                // Get user input
                string userInput = "";
                int selection = 0; // Initialized to avoid unassigned variable error
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine();
                    Console.Write("Write here: ");
                    userInput = Console.ReadLine();
                    //Console.Clear();

                    // Try parsing the user input directly
                    if (int.TryParse(userInput, out selection) && selection > 0 && selection <= options.Count)
                    {
                        validInput = true; // Input is valid, exit the loop
                    }
                    else
                    {
                        // Invalid input handling
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ups! \nWrong input, please select a valid option.");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        //Console.Clear();
                    }
                }

                // Switch based on the valid input selection
                switch (options[selection - 1])  // `-1` because `selection` is 1-based
                {
                    case "Move Left":
                        result = "MoveLeft";
                        break;
                    case "Move Right":
                        result = "MoveRight";
                        break;
                    case "Move Up":
                        result = "MoveUp";
                        break;
                    case "Move Down":
                        result = "MoveDown";
                        break;
                    default:
                        // Fallback in case something unexpected happens (this should not happen due to validation)
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ups! Something went wrong. Please try again.");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            return result;
        }


    }
}
