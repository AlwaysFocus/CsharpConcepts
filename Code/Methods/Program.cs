using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld("Hello, World! Via methods!");   
        }

        private static void HelloWorld(string message)
        {
            Console.WriteLine(message);
        }
    }
}
