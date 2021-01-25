using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.Make = "Toyota";
            //car1.Model = "RAV4";
            //car1.VIN = "B2";

            //Car car2 = new Car
            //{
            //    Make = "Toyota",
            //    Model = "Tundra",
            //    VIN = "A1"
            //};

            //Book b1 = new Book
            //{
            //    Author = "Eli Whalen",
            //    Title = "Quantum Security",
            //    ISBN = "1827403B39320459"
            //};


            //// Working with collections

            //// ArrayLists are dynamically sized, but are outdated
            //// supports features like sorting, item removal, etc
            //// There is no easy way to limit the type of data in an ArrayList
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(car1);
            //myArrayList.Add(car2);
            //// This works because ArrayLists are not strongly Typed
            //// which means there is no filtering on type
            //myArrayList.Add(b1);
            //// Item can be removed like this
            //// myArrayList.Remove(b1);

            //// This will throw an exception because the Book type does not have
            //// the same properties. Also, Book cannot be converted to type Car
            ////foreach (Car car in myArrayList)
            ////{
            ////    Console.WriteLine(car.Make);
            ////}


            //// List<T> - this one of the new types of generic collections which
            //// are strongly typed (you decide what type of data the collection
            //// holds.
            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            //// This will not work
            //// myList.Add(b1);
            //foreach (Car car in myList)
            //{
            //    Console.WriteLine(car.Model);
            //}


            //// Dictionaries Key: Value pairs
            //// Dictionary<TKey, TValue>
            //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            //myDictionary.Add(car1.VIN, car1);
            //myDictionary.Add(car2.VIN, car2);

            //// Find a specific value in the dictionary
            //Console.WriteLine(myDictionary["A1"].Make);


            // string[] names = { "Eli", "My" };

            // Object initializer syntax
            //Car car2 = new Car
            //{
            //    Make = "Toyota",
            //    Model = "Tundra",
            //    VIN = "A1"
            //};

            // Collection initializer
            List<Car> myList = new List<Car>()
            {
                // Object initializers
                new Car { Make = "Toyota", Model = "Tundra", VIN="A1" },
                new Car { Make = "Toyota", Model = "86", VIN = "V4"}
            };

            Console.ReadLine();


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }


    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
