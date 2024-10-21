using System.Security.Cryptography.X509Certificates;

namespace gamejam1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MainMenu();

        }

        public Controller Controller { get; }

        public Program (Controller controller)
        {  Controller = controller; }

    }
}
