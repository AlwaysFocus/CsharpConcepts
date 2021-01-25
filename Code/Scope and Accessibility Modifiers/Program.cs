using System;

namespace UnderstandingScopeAccessibility
{
    class Program
    {
        // This is accessible to any code blocks within the Program class
        private static string k = "";

        static void Main(string[] args)
        {

            

            // string j = "";

            for (int i = 0; i < 10; i++)
            {
                // j = i.ToString();
                Console.WriteLine(i);
                k = i.ToString();

                if (i == 9)
                {
                    string l = i.ToString();
                }
                // Can't do this
                // Console.WriteLine(l);

            }

            // This will fail because i is out of scope at this point
            // Console.WriteLine(i);

            // This would allow us to "access" the value of i by using a
            // variable defined in this code block
            //Console.WriteLine(j);

            // We can access k here since it is defined outside of this
            // code block but is still within the same code block
            Console.WriteLine("Accessing k: {0}", k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from helper method: {0}", k);
        }

        
        
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());

        }

        private string helperMethod()
        {
            return "Hello private method in a class called by a public method.";
        }
    }
}
