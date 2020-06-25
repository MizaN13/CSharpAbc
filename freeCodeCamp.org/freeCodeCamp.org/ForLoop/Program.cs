using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int it = 1;
            while(it <= 5)
            {
                Console.WriteLine(it);
                it++;
            }
            Console.WriteLine("From FORLOOP");
            
            int[] luckyNumbers = { 4, 8, 16, 23, 48 };

            for (int i=0; i<luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
