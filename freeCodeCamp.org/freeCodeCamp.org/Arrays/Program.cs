using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = { "Piyal", "Rifat", "Mahmud", "Tofazzal", "Nabila" };
            
            Console.WriteLine( luckyNumbers[0] );
            Console.WriteLine(luckyNumbers[2]);
            luckyNumbers[1] = 900;
            Console.WriteLine( luckyNumbers[1] );

            Console.WriteLine("Printing all elemenets from luckyNumbers array");
            for(int i=0; i<luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.WriteLine("Printing all elemenets from friends array");
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

            Console.Write("Enter the length of array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] unDefineLengthArray = new int[len];

            for(int i = 0; i < len; i++)
            {
                Console.Write($"Enter array element[{i}]: ");
                int element = Convert.ToInt32(Console.ReadLine());
                unDefineLengthArray[i] = element;
            }

            Console.WriteLine("Printing all elemenets from unDefineLengthArray array");
            for (int i = 0; i < unDefineLengthArray.Length; i++)
            {
                Console.WriteLine(unDefineLengthArray[i]);
            }

            Console.ReadLine();
        }
    }
}
