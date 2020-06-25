using System;

namespace BuildingAMabLibGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a color: ");
            string color = Console.ReadLine();
            Console.Write("Enter a plural name: ");
            string pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name: ");
            string celebrityName = Console.ReadLine();

            Console.WriteLine("Roses are "  + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " +  celebrityName);

            Console.ReadLine();
        }
    }
}
