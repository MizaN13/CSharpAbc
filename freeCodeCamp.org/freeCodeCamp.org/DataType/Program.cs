using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            char grade = 'B';
            int age = 30;
            int ageNegative = -30;
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine("I love " + phrase);
            Console.WriteLine("Giraffe's obtained GPA is " + gpa + " in Grade " + grade);
            if (isMale)
            {
                Console.WriteLine("Giraffe is Male");
            }
            else
            {
                Console.WriteLine("This in not Giraffe");
            }

            Console.WriteLine(phrase.Contains('G'));
            Console.WriteLine(phrase.Contains("Academy"));

            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf('f'));
            Console.WriteLine(phrase.IndexOf('z'));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 3));
            Console.ReadLine();
        }
    }
}
