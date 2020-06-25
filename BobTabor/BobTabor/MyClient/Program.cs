using MyCodeLibrary;
using System;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrap myScrap = new Scrap();
            Console.WriteLine(myScrap.ScrapeWebpage("http://msdn.microsoft.com"));

            Console.ReadLine();
        }
    }
}
