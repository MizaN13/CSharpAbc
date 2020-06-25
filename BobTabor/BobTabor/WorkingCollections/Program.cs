using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";

            Book book1 = new Book();
            book1.Title = "Microsoft .NET XML Web Services";
            book1.Author = "Robert Tabor";
            book1.ISBN = "0-000-00000-0";
            */

            //ArrayLists are dynamically sized,
            // Cool features sortin, remove items

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach(Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"].Make);
            Console.WriteLine(myDictionary["A2"].Make);
            */

            //string[] names = { "Bob", "Steve", "Brian", "Chuck"};

            /*
            // Object Initializer
            // No need for a Constructor
            Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3"};
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };
            */

            // Collection Initializar
            List<Car> myList = new List<Car>() {
                new Car { Make = "Oldmobile", Model = "Cutlas Supreme", VIN = "E5"},
                new Car { Make = "Nissan", Model = "Altima", VIN = "E6" }
            };

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }


            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
