using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("From Do While Loop.");
            int indexx = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (indexx <= 5);

            Console.ReadLine();
        }
    }
}
