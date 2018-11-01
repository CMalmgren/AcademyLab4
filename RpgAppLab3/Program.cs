using System;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("What do you need?");

            string command = Console.ReadLine();

            if (command == "roll D20") Console.WriteLine("not implemented :(");
            if (command == "names")
            {
                string[] allNames = new[] { "Briana", "Ben", "David", "Dana", "Felicia", "Felix" };
                int randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
