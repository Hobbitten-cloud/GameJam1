using System.Security.Cryptography.X509Certificates;

namespace gamejam1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO LIST
            // 1: Tjek for om man kan gå i den retning man vil baseret på de rum vi har i koordinat systemet // COMPLETE
            // 2: Add minimap
            // 3: Gøre brug af vores Spørgsmål / trivia // NOT COMPLETED
            // 4.1: Gøre brug af vores Loot system // NOT COMPLETED
            // 4.2: Gøre brug af vores enemy system // NOT COMPLETED
            // 5: Går at vi kan dø og restart spillet // NOT COMPLETED


            // Player
            Player bob = new Player("bob", 10, "sword", "", true, 10, 10, 5, 2, 1, 2);

            Room[,] rooms = new Room[3, 4];


            /*
                --------
                Mini map
                --------
                
                0,0 = Room 0.0 = START ROOM
                0.1 = Room 0.1 = Vampire enemy
                1,0 = Room 1.0 = Skeleton enemy
                0,2 = Room 0.2 = Goblin enemy
                1,1 = Room 1.1 = Spider enemy
                2,1 = Room 2.1 = Zombie enemy
                2,2 = Room 2.2 = Dragon enemy
                2,3 = Room 2.3 = FINAL ROOM

                rest = null

                0,0 : 1,0 : 2,0
                0,1 : 1,1 : 2,1
                0,2 : 1,2 : 2,2
                0,3 : 1,3 : 2,3

            */


            //Room 0,0 StartRoom
            rooms[0, 0] = new Room(new Trial("Abe?", "Hands", null, null, null), "Room 0,0:", "#");

            //Room 1
            // Question
            Quiz question1 = new Quiz("How many hands does a human have?", "1", "2", "4", 2);
            // Enemy
            Enemy skeleton = new Enemy("Skeleton", 5, 1, "", true);
            // Loot
            Loot loot1 = new Loot("Excalibur", "", false, 1, 1, 3, 2, 5);
            rooms[1, 0] = new Room(new Trial("Abe?", "Hands", question1, skeleton, loot1), "Room 1,0:", "#");

            //Room 2,1
            // Question
            Quiz question2 = new Quiz("What is a string?", "Food", "An animal", "A code part", 3);
            // Enemy
            Enemy Zombie = new Enemy("Zombie", 8, 2, "", true);
            // Loot
            Loot loot2 = new Loot("Helmet", "", false, 2, 3, 2, 1, 2);
            rooms[2, 1] = new Room(new Trial("Rotten Armory", "Heads", question2, Zombie, loot2), "Room 2,1:", "#");

            //Room 1,1
            // Question
            Quiz question3 = new Quiz("What is an integer?", "A monkey?", "A way to show text", "A way to show numbers", 3);
            // Enemy
            Enemy Spider = new Enemy("Spider", 8, 2, "", true);
            // Loot
            Loot loot3 = new Loot("Spider Armor", "", false, 4, 5, 4, 2, 4);
            rooms[1, 1] = new Room(new Trial("Sticky Situtation", "Legs", question3, Spider, loot3), "Room 1,1:", "#");

            //Room 0,1
            // Question
            Quiz question4 = new Quiz("What is a vampires weakness", "Silver", "Gold", "Bronze", 1);
            // Enemy
            Enemy Vampire = new Enemy("Vampire", 15, 1, "", true);
            // Loot
            Loot loot4 = new Loot("Old Key", "", true, 0, 0, 0, 0, 0);
            rooms[0, 1] = new Room(new Trial("A bloody tooth", "blood", question4, Vampire, loot4), "Room 0,1:", "#");

            //Room 0,2
            // Question
            Quiz question5 = new Quiz("Who is the god of the underworld in greek mythology", "Poseidon", "Hades", "Apollo", 2);
            // Enemy
            Enemy Goblin = new Enemy("Goblin", 9, 1, "", true);
            // Loot
            Loot loot5 = new Loot("Bag of coins", "", true, 0, 0, 0, 0, 0);
            rooms[0, 2] = new Room(new Trial("Too much loot!", "bagged", question5, Goblin, loot5), "Room 0,2:", "#");

            //Room 2,2
            // Question
            Quiz question6 = new Quiz("What does a dragon usually sleep on in fantasy games?", "Gold Coins", "A bunch of hay", "On the ground", 1);
            // Enemy
            Enemy Dragon = new Enemy("Dragon", 9, 1, "", true);
            // Loot
            Loot loot6 = new Loot("A dragon stone", "", true, 0, 0, 0, 0, 0);
            rooms[2, 2] = new Room(new Trial("Giant beast", "Beast slayer", question6, Dragon, loot6), "Room 2,2:", "#");

            //Room 2,3 - EXIT ROOM
            // Question
            Quiz question7 = new Quiz("Who is the youngest teacher?", "Orhan", "Jan", "Lars", 1);
            // Enemy
            Enemy Teacher = new Enemy("Teacher", 30, 30, "", true); 
            // Loot
            Loot loot7 = new Loot("A BIG BRAIN", "", true, 20, 20, 20, 20, 20);
            rooms[2, 3] = new Room(new Trial("A hard study lesson", "Books", question7, Dragon, loot7), "Room 2,3:", "#");


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
                            Console.Clear();

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
                if (controller.PlayerX == 2 && controller.PlayerY == 2)
                {
                    startGame = false;
                }
                while (!(controller.Menu.Question(controller.PlayerRoom, controller.PlayerX, controller.PlayerY, controller.FloorObjective)))
                {
                }
                // switch case based of the userinput
                switch (controller.Menu.PathSelectionMenu(controller.PlayerRoom, controller.PlayerX, controller.PlayerY, controller.FloorObjective))
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
                    case "MoveUp":
                        {
                            // Forward
                            controller.MoveForward();
                            break;
                        }
                    case "MoveDown":
                        {
                            // Backward
                            controller.MoveBackward();
                            break;
                        }

                }
                
            }
            controller.Menu.End();
        }
    }
}
