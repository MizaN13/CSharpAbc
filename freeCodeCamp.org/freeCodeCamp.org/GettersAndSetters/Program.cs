using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "John Whedon", "Cat");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }
    }
}
