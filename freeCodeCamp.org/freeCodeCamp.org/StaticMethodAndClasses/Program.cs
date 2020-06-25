using System;

namespace StaticMethodAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math is a static class and we can not create an instance of a static class
            //Math math = new Math();
            Console.WriteLine(Math.Sqrt(144));

            // We can not create instance of a static class
            //UsefulTools tools = new UsefulTools();
            UsefulTools.sayHi("Mizan");

            Console.ReadLine();
        }
    }
}
