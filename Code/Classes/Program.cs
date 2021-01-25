using System;

namespace UnderstandingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // Setting Properties of this instance of the Car class
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            // Getting Properties of this instance of the Car class
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            // decimal value = DetermineMarketValue(myCar);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

        }

        //private static decimal DetermineMarketValue(Car car)
        //{
        //    decimal carValue = 100.0M;

        //    // Someday I might look up this car online
        //    // using a web service to get accurate values
        //    return carValue;
        //}
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 5000;
            }
            return carValue;
        }
    }
}
