using System;

namespace MoreOnClasses
{
    // Learning about object lifetimes

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // Print the value of Make that was assigned
            // via the Class Constructor
            
            Console.WriteLine(myCar.Make);

            // Overloading Car constructor
            Car myNewCar = new Car("Lamborghini", "Hurracin", 2021, "Orange");

            // Calling static method from class
            // which does not require a new instance
            Car.CarStaticMethod();

            //myCar.Make = "Toyota";
            //myCar.Model = "RAV4";
            //myCar.Year = 2020;
            //myCar.Color = "Green";

            // Adding a second reference to the same instance
            Car myOtherCar;
            myOtherCar = myCar;
            //Console.WriteLine("{0} {1} {2} {3}",
            //    myOtherCar.Make,
            //    myOtherCar.Model,
            //    myOtherCar.Year,
            //    myOtherCar.Color);

            // Changing values of the shared instance of the Car class
            //myOtherCar.Model = "Highlander";
            //Console.WriteLine("{0} {1} {2} {3}",
            //    myOtherCar.Make,
            //    myOtherCar.Model,
            //    myOtherCar.Year,
            //    myOtherCar.Color);

            // Removing a reference to an object
            myOtherCar = null;
            // This will now throw a Null reference exception error
            //Console.WriteLine("{0} {1} {2} {3}",
            //    myOtherCar.Make,
            //    myOtherCar.Model,
            //    myOtherCar.Year,
            //    myOtherCar.Color);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Creating a constructor
        public Car()
        {
            // You could load these from a config file,
            // a database, etc.
            Make = "Lamborghini";
        }

        // Overloading Constructors to allow for multiple ways
        // to create an instance of this class
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Creating a static method that does not require instantiation
        public static void CarStaticMethod()
        {
            Console.WriteLine("Called static method on Car Class");
        }
    }
}
