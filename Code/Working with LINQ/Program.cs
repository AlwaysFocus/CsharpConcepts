using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {VIN = "A1", Make = "Toyota", Model = "Tundra", StickerPrice = 12000, Year = 2021},
                new Car() {VIN = "A2", Make = "Honda", Model = "Civic", StickerPrice = 8000, Year = 2020},
                new Car() {VIN = "A3", Make = "BMW", Model = "745li", StickerPrice = 75000, Year = 2019},
                new Car() {VIN = "A4", Make = "Toyota", Model = "4Runner", StickerPrice = 14000, Year = 2018},
                new Car() {VIN = "A5", Make = "Alfa Romeo", Model = "GIULIA TI SPORT", StickerPrice = 70000, Year = 2022},
            };

            //// LINQ Query
            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           && car.Year == 2019
            //           select car;

            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;


            //foreach (Car car in orderedCars)
            //{
            //    Console.WriteLine("Make: {0} Model: {1} Year: {2} Price: {3} VIN: {4}",
            //        car.Make, car.Model, car.Year, car.StickerPrice, car.VIN);
            //}

            //// LINQ Method

            var toyotas = myCars.Where(p => p.Make == "Toyota" && p.Year == 2021);

            var orderedVehicles = myCars.OrderByDescending(p => p.Year);

            //var firstCarWhere = myCars.First(p => p.Make == "BMW");

            //var orderedVehiclesFirst = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "Toyota");


            //Console.WriteLine(firstCarWhere.VIN);

            //Console.WriteLine(orderedVehiclesFirst.Model);

            //foreach (Car car in orderedVehicles)
            //{
            //    Console.WriteLine("Make: {0} Model: {1} Year: {2} Price: {3} VIN: {4}",
            //        car.Make, car.Model, car.Year, car.StickerPrice, car.VIN);
            //}

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            //myCars.ForEach(p => p.StickerPrice -= 3000);

            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));

            //foreach (Car car in toyotas)
            //{
            //    Console.WriteLine("Make: {0}\nModel: {1}\nYear: {2}\nPrice: {3}\nVIN: {4}",
            //        car.Make, car.Model, car.Year, car.StickerPrice, car.VIN);
            //}


            Console.WriteLine(myCars.GetType());
            Console.WriteLine(orderedVehicles.GetType());
            Console.WriteLine(toyotas.GetType());

            // Using Projection, take only certain values from the
            // target collection and project them into a new collection type
            var newCars = from car in myCars
                      where car.Make == "BMW"
                      && car.Year == 2019
                      select new { car.Make, car.Model };


            Console.WriteLine(newCars.GetType());

            Console.ReadLine();

        }
    }

    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public decimal StickerPrice { get; set; }

    }
}
