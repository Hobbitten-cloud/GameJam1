using System.Security.Cryptography.X509Certificates;

namespace gamejam1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO LIST
            // 1: Tjek for om man kan gå i den retning man vil baseret på de rum vi har i koordinat systemet // COMPLETE
            // 2: Gøre brug af vores Spørgsmål / trivia // NOT COMPLETED
            // 3.1: Gøre brug af vores Loot system // NOT COMPLETED
            // 3.2: Gøre brug af vores enemy system // NOT COMPLETED
            // 4: Går at vi kan dø og restart spillet // NOT COMPLETED


            // Player
            Player bob = new Player("bob", 10, "sword", "", true, 10, 10, 5, 2, 1, 2);

            Room[,] rooms = new Room[3, 3];


            /*
                --------
                Mini map
                --------
                
                0,0 = start room
                1,0 = Room 1
                2,0 = Room 2
                1,1 = Room 3
                rest = null


                0,0 : 1,0 : 2,0
                0,1 : 1,1 : 2,1
                0,2 : 1,2 : 2,2

            */


            //Room 0 StartRoom
            rooms[0, 0] = new Room(new Trial("Abe?", "Hands", null, null, null), "Room 0,0:");

            //Room 1
            // Question
            Quiz question1 = new Quiz("How many hands does a human have?", "1", "2", "4", 2);
            // Enemy
            Enemy skeleton = new Enemy("Skeleton", 5, 1, "", true);
            // Loot
            Loot loot1 = new Loot("Excalibur", "", false, 1, 1, 3, 2, 5);
            rooms[1, 0] = new Room(new Trial("Abe?", "Hands", question1, skeleton, loot1), "Room 1,0:");

            //Room 2
            // Question
            Quiz question2 = new Quiz("What is a string?", "Food", "An animal", "A code part", 3);
            // Enemy
            Enemy Zombie = new Enemy("Zombie", 8, 2, "", true);
            // Loot
            Loot loot2 = new Loot("Helmet", "", false, 2, 3, 2, 1, 2);
            rooms[2, 0] = new Room(new Trial("Rotten Armory", "Heads", question2, Zombie, loot2), "Room 0,1:");

            //Room 3
            // Question
            Quiz question3 = new Quiz("What is a string?", "Food", "An animal", "A code part", 3);
            // Enemy
            Enemy Spider = new Enemy("Spider", 8, 2, "", true);
            // Loot
            Loot loot3 = new Loot("Spider Armor", "", false, 4, 5, 4, 2, 4);
            rooms[1, 1] = new Room(new Trial("Sticky Situtation", "Legs", question3, Spider, loot3), "Room 1,1:");


            Controller controller = new Controller(new Menu(), new Floor(0, rooms), bob);

            // Makes our main menu appear on the screen
            bool startGame = false;
            while (!startGame)
            {
                switch (controller.Menu.MainMenu())
                {
                    case "StartGame":
                        {
                            // Starts the game up
                            startGame = true;
                            break;
                        }
                    case "Credit":
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
                            break;
                        }
                    case "Quit":
                        {

                            // Quits the program
                            break;
                        }
                }
            }





            while (startGame)
            {
                // switch case based of the userinput
                switch (controller.Menu.PathSelectionMenu(controller.PlayerRoom,controller.PlayerX,controller.PlayerY,controller.FloorObjective))
                {
                    case "MoveLeft":
                        {
                            // Left
                            controller.MoveLeft();
                            break;
                        }
                    case "MoveRight":
                        {
                            // Right
                            controller.MoveRight();
                            break;
                        }
                    case "MoveForward":
                        {
                            // Forward
                            controller.MoveForward();
                            break;
                        }
                    case "MoveBackward":
                        {
                            // Backward
                            controller.MoveBackward();
                            break;
                        }

                }
            }


        }
    }
}
