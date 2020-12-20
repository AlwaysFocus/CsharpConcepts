using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with variables
            object height = 1.88; // Storing a double in an object
            object name = "Eli"; // storing a string in an object
            Console.WriteLine($"{name} is {height} meters tall.");
            //int length1 = name.Length; // Gives compiler error because when the object variable type is used, it does not inherit the properties/method of the values type
            int length2 = ((string)name).Length; // Tells the compiler that this object is a string.
            Console.WriteLine($"{name} has {length2} characters.");

        }
    }
}
