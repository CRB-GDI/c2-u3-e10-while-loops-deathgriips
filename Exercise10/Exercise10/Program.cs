using System.Runtime.CompilerServices;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("*******************");

            bool userInput = bool.Parse(Console.ReadLine());

            // Declare while loop

            while (userInput = 1 || 2 || 3)
            {
                Console.WriteLine("Loading...");
            }
        }
    }
}