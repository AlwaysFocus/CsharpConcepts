using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new DateTime Object with  a time of right now
            // DateTime myValue = DateTime.Now;

            // Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.ToShortTimeString());
            // Console.WriteLine(myValue.ToLongDateString());
            // Console.WriteLine(myValue.ToLongTimeString());


            // DateTime math
            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            // Console.WriteLine(myValue.AddHours(6).ToLongTimeString());
            // Console.WriteLine(myValue.AddHours(-5).ToLongDateString());

            // Grabbing part of a date/time
            // Console.WriteLine(myValue.Month);

            // Creating a DateTime in the past

            // DateTime myValue = new DateTime(1992, 12, 21);
            // Console.WriteLine(myValue.ToLongDateString());

            DateTime myValue = DateTime.Parse("12/21/1992");

            TimeSpan myAge = DateTime.Now.Subtract(myValue);

            Console.WriteLine(myAge.TotalDays);




            Console.ReadLine();
        }
    }
}
