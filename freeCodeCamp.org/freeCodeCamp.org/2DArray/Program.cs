using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            Console.WriteLine(numberGrid[0, 0]);
            Console.WriteLine(numberGrid[1, 1]);


            Console.ReadLine();
        }
    }
}
