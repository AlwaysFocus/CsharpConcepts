using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escape sequences
            // string myString = "My \"so-called\" life";

            // Newline character
            // string myString = "Hello\nthere!";

            // Use the backslash character
            //string myString = "Go to your C:\\ drive";

            // The @ symbol indicates that you want to use a string literal
            // eg. Using the \ character without escaping it
            //string myString = @"Go to your C:\ drive";

            // String formatting
            // string myString = String.Format("{0} {1}", "First", "Second");

            // Replacements - these can be accessed by adding a : after the
            // {#} -> (0: }
            //string myString = string.Format("{0:C}", 123.45);

            // string myString = string.Format("{0:N", 123456873);

            //string myString = string.Format("{0:P}", .123);

            // Creating a custom format
            // string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);
            // string myString = string.Format("Phone Number: {0:(###) ###-####}", 123456789012);


            // String manipulation
            // string myString = " That summer we took threes across the board  ";
            // myString = myString.Substring(6, 14);
            // myString = myString[6..];
            // myString.ToUpper();
            // myString = myString.Replace(" ", "--");
            // myString = myString.Remove(6, 14);

            /* Performing this operation this way is resource intensive as 
             * the .NET Framework creates a new temp variable to hold iterations
             * behind the scenes
            myString = String.Format("Length before: {0}\nLength after: {1}",
                myString.Length, myString.Trim().Length);
            */

            /*string myString = "";

            for (int i =0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            // Using a StringBuilder allows us to work with a single variable
            // and simply append new information to it.
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append( "--");
                myString.Append(i);
            }
            Console.WriteLine(myString);

            Console.ReadLine();
        }
    }
}
