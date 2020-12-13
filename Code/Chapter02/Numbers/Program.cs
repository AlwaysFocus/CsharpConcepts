using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
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
            
        }
    }
}
