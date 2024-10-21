using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Menu
    {
        public void MainMenu()
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
            string userInput = Console.ReadLine();
            Console.Clear();

            // switch case based of the userinput
            switch (userInput)
            {
                case "1":
                    {
                        // Starts the game up

                        break;
                    }
                case "2":
                    {
                        // Shows the credit for made the game
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("a 2 day game jam project ");
                        Console.WriteLine("The game was created by the following people");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("Nicklas, Elias, Dennis, Ali, Emil, Benjamin");
                        Console.WriteLine();
                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        Console.Clear();
                        MainMenu();
                        break;
                    }
                case "3":
                    {
                        // Quits the program
                        return;
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
                        MainMenu();
                        break;
                    }
            }
        }
        public void PathSelectionMenu()
        {
            Console.Clear();

            // Menu questions
            Console.WriteLine();
            Console.Write("Please select 1 of the following options");
            Console.WriteLine();
            Console.WriteLine("1: Start Game");
            Console.WriteLine("2: Credits");
            Console.WriteLine("3: Quit");
            Console.WriteLine();
            Console.Write("Write here: ");
            string userInput = Console.ReadLine();
            Console.Clear();

            // switch case based of the userinput
            switch (userInput)
            {
                case "1":
                    {
                        // Starts the game up

                        break;
                    }
                case "2":
                    {
                        // Shows the credit for made the game
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("a 2 day game jam project ");
                        Console.WriteLine("The game was created by the following people");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("Nicklas, Elias, Dennis, Ali, Emil, Benjamin");
                        Console.WriteLine();
                        Console.Write("Press any key to continue: ");
                        Console.ReadKey();
                        Console.Clear();
                        MainMenu();
                        break;
                    }
                case "3":
                    {
                        // Quits the program
                        return;
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
                        MainMenu();
                        break;
                    }
            }
        }
    }
}
