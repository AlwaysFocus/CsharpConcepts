using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // TIP: “Use int for whole numbers and double for real numbers that will not be compared to other values. Use decimal for money, 
            //       CAD drawings, general engineering, and wherever the accuracy of a real number is important.”


            // unsigned int means positive whole number including 0
            uint naturalNumber = 23;
            // int means negative or positive whole number
            int integerNumber = -23;
            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;
            // double means double-precisions floating point
            double anotherRealNumber = 2.3; // double literal


            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            // check that each of these variables holds the same value
            // both statements should output true
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");


            // exploring number sizes
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers from {int.MinValue:N0} to {int.MaxValue:N0}");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers from {double.MinValue:N0} to {double.MaxValue:N0}");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers from {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

            // Comparing double and decimal types
            // *Doubles should only be used when accuracy (eg comparing two numbers) is NOT important.*//
            // Tip - Never compare double values using == as it will lead to failures in comparison as demonstrated below
            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                // This is the case that will trigger because 0.1 does not exist as a floating point number.
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
            // Decimal types
            // the 'M' suffix is used on decimals to indicate a decimal literal value
            Console.WriteLine("Using decimals:");
            decimal c = 0.1M;
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }
            
        }
    }
}
