using System.Security.Cryptography.X509Certificates;

namespace gamejam1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player bob = new Player("bob", 5, "sword", "", true, 10, 10, 5, 2, 1, 2);

            List<Room> rooms = new List<Room>();

            rooms.Add(new Room(new Trial("Abe?","Leg",new Quiz(),new Enemy(),new Loot()),0,"Room 1:", "Hej?"));



            Controller controller = new Controller(new Menu(), new Floor(0, rooms), bob);


            controller.Menu.MainMenu();

        }

    }
}
