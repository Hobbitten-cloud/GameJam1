using System.Security.Cryptography.X509Certificates;

namespace gamejam1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instanser 
            Player bob = new Player("bob", 5, "sword", "", true, 10, 10, 5, 2, 1, 2);
            Quiz question1 = new Quiz("How many hands does a human have?", "1", "2", "4", 1);
            Enemy skeleton = new Enemy("Skeleton", 10, "1", "", true);

            List<Room> rooms = new List<Room>();

            rooms.Add(new Room(new Trial("Abe?", "Leg", question1, skeleton, new Loot()), 0, "Room 1:", "Hej?"));


            Controller controller = new Controller(new Menu(), new Floor(0, rooms), bob);


            controller.Menu.MainMenu();

        }

    }
}
