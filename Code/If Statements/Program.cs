using System;

namespace GameShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Eli's Game Show...");
            Console.WriteLine("Choose door 1, 2, or 3...");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("You won a $500 gift card!");

            }
            else if (userChoice == "2")
            {
                Console.WriteLine("You won a trip to North Korea!");
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("You won a new car!");
            }
            else
            {
                Console.WriteLine("You typed an invalid response... You have been disqualified!");
            }
            Console.ReadLine();
        }
    }
}
