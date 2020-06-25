using System;

namespace UpdateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            char op;
            double num2;
            double result;

            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator: ");
            op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (op == '+')
            {
                result = num1 + num2;
                Console.WriteLine("Result is " + result);
            }
            else if(op == '-')
            {
                result = num1 - num2;
                Console.WriteLine("Result is " + result);
            }
            else if (op == '*')
            {
                result = num1 * num2;
                Console.WriteLine("Result is " + result);
            }
            else if (op == '/')
            {
                result = num1 / num2;
                Console.WriteLine("Result is " + result);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadLine();
        }
    }
}
