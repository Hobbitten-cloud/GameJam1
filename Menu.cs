using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
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


                            break;
                        }
                }
            }
            return result;
        }

        public bool Question(Room playerRoom, int playerX, int playerY, Floor floor)
        {
            bool result = false;
            while (result == false)
            {
                Console.Clear();

                Quiz quiz = floor.Rooms[playerX, playerY].Trial.Quiz;
                if (quiz == null)
                {
                    Console.WriteLine("No quiz available in this room.");
                    // Handle accordingly, e.g., return or set a default result
                    return true;
                }

                Console.WriteLine(quiz.Spørgmål);

                // Create a list of available options
                List<string> answers = new List<string>
        {
            quiz.Svar_1,
            quiz.Svar_2,
            quiz.Svar_3
        };

                // Show all options
                for (int i = 0; i < answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {answers[i]}");
                }

                // Get user input
                string userInput = "";
                int selection = 0;
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine();
                    Console.Write("Write here: ");
                    userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out selection) && selection > 0 && selection <= answers.Count)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oops! Wrong input, please select a valid option.");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(quiz.Spørgmål);
                        for (int i = 0; i < answers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {answers[i]}");
                        }
                    }
                }

                // Switch based on the valid input selection
                string selectedAnswer = answers[selection - 1];
                
                if (quiz.Rigtigsvar == selection)
                {
                    result = true;
                }else
                {
                    result = false;
                }
                
                 
            }
            
            return result;
        }

        public string PathSelectionMenu(Room playerRoom, int playerX, int playerY, Floor floor)
        {
            string result = "";
            while (result == "")
            {
                Console.Clear();
                

                // Create a list of available options
                List<string> awnsers = new List<string>();

                // Add quiz options if a trial exists in the current room
                if (floor.Rooms[playerX, playerY].Trial.Quiz != null)
                {

                    // Display the question
                    Console.WriteLine(floor.Rooms[playerX, playerY].Trial.Quiz.Spørgmål);
                    // Add quiz options
                    awnsers.Add(floor.Rooms[playerX, playerY].Trial.Quiz.Svar_1);
                    awnsers.Add(floor.Rooms[playerX, playerY].Trial.Quiz.Svar_2);
                    awnsers.Add(floor.Rooms[playerX, playerY].Trial.Quiz.Svar_3);

                    

                    // Show all options including movement and quiz answers
                    for (int i = 0; i < awnsers.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {awnsers[i]}");
                    }
                }

                int maxX = floor.Rooms.GetLength(0);  // Get the width of the room array
                int maxY = floor.Rooms.GetLength(1);  // Get the height of the room array

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
                if (playerX < maxX - 1 && floor.Rooms[playerX + 1, playerY] != null)
                {
                    options.Add("Move Right");
                }
                if (playerY > 0 && floor.Rooms[playerX, playerY - 1] != null)
                {
                    options.Add("Move Up");
                }
                if (playerY < maxY - 1 && floor.Rooms[playerX, playerY + 1] != null)
                {
                    options.Add("Move Down");
                }



                // Show the available movement options
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {options[i]}");
                }



                // Render the minimap
                Console.WriteLine();
                Console.WriteLine("Minimap:");
                for (int y = 0; y < maxY; y++)
                {
                    for (int x = 0; x < maxX; x++)
                    {
                        // Check if there's a room at the current position
                        if (floor.Rooms[x, y] != null)
                        {
                            // Highlight the player's current position on the map
                            if (x == playerX && y == playerY)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[P]");
                                Console.ResetColor();
                            }
                            else
                            {
                                // Display room character
                                Console.Write("[ ]"); // Replace this with floor.Rooms[x, y].Ca if needed
                            }
                        }
                        else
                        {
                            // Render empty space where there's no room
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }

                // Get user input
                string userInput = "";
                int selection = 0; // Initialize to avoid unassigned variable error
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine();
                    Console.Write("Write here: ");
                    userInput = Console.ReadLine();

                    // Try parsing the user input directly
                    if (int.TryParse(userInput, out selection) && selection > 0 && selection <= options.Count)
                    {
                        validInput = true; // Input is valid, exit the loop
                    }
                    else
                    {
                        // Invalid input handling
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Ups! \nWrong input, please select a valid option.");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }

                // Switch based on the valid input selection
                switch (options[selection - 1])
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
                        result = options[selection - 1]; // Handles quiz options
                        break;
                }
            }

            return result;
        }




    }
}
