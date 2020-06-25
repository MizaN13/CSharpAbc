using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            SayHi(name, age);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.Write("Enter your name: ");
            string pName = Console.ReadLine();
            name = pName;
            Console.Write("Enter Age: ");
            int pAge = Convert.ToInt32(Console.ReadLine());
            age = pAge;
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
        }
    }
}
