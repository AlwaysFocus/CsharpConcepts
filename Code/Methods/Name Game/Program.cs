using System;

namespace NameGame
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] userInfo = GetUserInfo();           

            DisplayResult(
                ReverseString(userInfo[0]),
                ReverseString(userInfo[1]),
                ReverseString(userInfo[2]));

            Console.ReadLine();
        }


        // Method to reverse a string
        private static string ReverseString(string stringToReverse)
        {
            char[] convertedString = stringToReverse.ToCharArray();
            Array.Reverse(convertedString);
            // This is how you convert a char[] into a string:
            string reversedString = new string(convertedString + " ");
            
            // String.Concat() takes a Collection of Chars and concatenates it into a string
            return String.Concat(convertedString);
        }

        // Returns a string array of user information [0] = first name, [1] = last name. [2] = home city
        private static string[] GetUserInfo()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Enter your home city: ");
            string homeCity = Console.ReadLine();

            string[] userInfo = new string[3];

            userInfo[0] = firstName;
            userInfo[1] = lastName;
            userInfo[2] = homeCity;

            return userInfo;
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedHomeCity)
        {
            // Without string formatting
            Console.WriteLine(reversedHomeCity + " " + reversedLastName + " " + reversedFirstName);
            // Using string formatting
            Console.Write(String.Format("{0} {1} {2}", reversedHomeCity, reversedLastName, reversedFirstName));
        }

        // Creating overloading functions
        private static void DisplayResult(string reversedFirstName, string reversedLastName)
        {
            // Without string formatting
            Console.WriteLine(reversedLastName + " " + reversedFirstName);
            // Using string formatting
            Console.Write(String.Format("{0} {1}", reversedLastName, reversedFirstName));
        }
    }
}
