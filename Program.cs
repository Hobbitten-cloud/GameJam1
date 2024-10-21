using System.Security.Cryptography.X509Certificates;

namespace gamejam1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instanser 
            Player bob = new Player("bob", 5, "sword", "", true, 10, 10, 5, 2, 1, 2);

            // Questions
            Quiz question1 = new Quiz("How many hands does a human have?", "1", "2", "4", 2);

            // Enemies
            Enemy skeleton = new Enemy("Skeleton", 10, "1", "", true);
            List<Enemy> enemyList = [skeleton];

            // Loot
            Loot loot1 = new Loot("Excalibur", "", true, 1, 1, 3, 2, 5);
            List<Loot> lootList = [loot1];


            List <Room> rooms = new List<Room>();

            rooms.Add(new Room(new Trial("Abe?", "Leg", question1, enemyList, lootList), 0, "Room 1:", "Hej?"));


            Controller controller = new Controller(new Menu(), new Floor(0, rooms), bob);


            controller.Menu.MainMenu();

        }
    }
}
