using System;

namespace BuildingACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32("45"); // inpput must be number
            //Console.WriteLine(num + 6);
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }
    }
}
