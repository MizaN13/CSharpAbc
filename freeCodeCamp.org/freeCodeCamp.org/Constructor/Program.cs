using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 500);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 800);
            Book book3 = new Book();


            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
