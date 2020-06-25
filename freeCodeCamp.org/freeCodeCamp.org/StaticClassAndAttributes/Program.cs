using System;

namespace StaticClassAndAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.artist);
            Console.WriteLine(holiday.getSongCount());

            Console.ReadLine();
        }
    }
}
