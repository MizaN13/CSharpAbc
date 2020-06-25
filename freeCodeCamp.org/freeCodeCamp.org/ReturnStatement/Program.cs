using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(5));

            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
