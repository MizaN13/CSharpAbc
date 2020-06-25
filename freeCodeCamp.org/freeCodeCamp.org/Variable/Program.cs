using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Mizan";
            int characterAge = 24;
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was" + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            characterAge = 35;
            Console.WriteLine("But did not like being " + characterAge);
            Console.ReadLine();
        }
    }
}
