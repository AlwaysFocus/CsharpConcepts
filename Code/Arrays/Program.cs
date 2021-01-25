using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5]; // create a new integer array with 5 indexes

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
            //// numbers[5] = 42; - this would throw an error becuase we defined our array as only having 5 indicies

            //// Access a value in the array
            //Console.WriteLine(numbers[3]); // This will print 16 to the console
            //// Determine the number of elements in the array using the Length Property
            //Console.WriteLine(numbers.Length);
            //Console.ReadLine();

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; // This tells the compiler to determine the size of the array at time of compilation

            string[] strings = new string[] { "Eli", "My", "Nox" }; // Creating an array of strings

            // Looping through an array and printing the "ith" elements value
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]); 
            }

            // An easier way to iterate through an array - the value of the index will be copied into the name variable for each value in the strings array
            foreach (string name in strings)
            {
                Console.WriteLine(name);    
            }

            // Reverse a string
            
            string pet = "Hey there, I'm Nox!";

            // Convert string to array of characters using the ToCharArray() helper method
            char[] charArray = pet.ToCharArray();
            Array.Reverse(charArray); // Reverse the char array

            foreach (char petChar in charArray)
            {
                Console.Write(petChar);
            }
        }
    }
}
