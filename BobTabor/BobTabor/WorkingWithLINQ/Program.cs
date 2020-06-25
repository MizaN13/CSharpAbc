using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ = Language Intregraded Query 
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2020},
                new Car() { VIN = "B2", Make = "Toyota", Model = "4Runnet=r", StickerPrice = 65000, Year = 2021},
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", StickerPrice = 75000, Year = 2022},
                new Car() { VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 85000, Year = 2023},
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 95000, Year = 2024}
            };

            /*
            // LINQ Query
            var bmw = from car in myCars
                      where car.Make == "BMW"
                      select car;

            var bmw2 = from car in myCars
                      where car.Make == "BMW"
                      && car.Year == 2020
                      select car;
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            */

            // LINQ Method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2020);

            //var orderedCars = myCars.OrderByDescending(o => o.Year);

            /*
            var firstBMW = myCars.First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);

            var firstOrderedBMW = myCars.OrderByDescending(o => o.Year).First(f => f.Make == "BMW");
            Console.WriteLine(firstOrderedBMW.VIN);
            */
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2019));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());
            
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2020);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                      where car.Make == "BMW"
                      && car.Year ==2020
                      select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model);
            }
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int StickerPrice { get; set; }
    }
}
