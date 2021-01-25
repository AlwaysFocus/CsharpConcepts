using System;
using System.Timers;

namespace HandlingEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);


            // Creating an EventHandler that will trigger whenever the
            // Elapsed event is triggered in our timer.
            myTimer.Elapsed += MyTimer_Elapsed;

            // We can attach multiple event handlers to an event
            myTimer.Elapsed += MyTimer_Elapsed1;

            // Start our timer
            myTimer.Start();

            Console.WriteLine("Press enter to remove Yellow text");
            Console.ReadLine();

            // Remove one of the event handlers
            myTimer.Elapsed -= MyTimer_Elapsed1;
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // We can access values that are passed with the event object
            Console.WriteLine("Time elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // We can access values that are passed with the event object
            Console.WriteLine("Time elapsed: {0:HH:mm:ss.fff}", e.SignalTime);   
        }
    }
}
