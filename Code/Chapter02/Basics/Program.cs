using System;
using System.Linq;
using System.Reflection;
// #error version

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some unused variables using types in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            // loop through each assembly that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // load the assembly so that we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // declare variable to count the number of methods
                int methodCount = 0;
                // loop through each type in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the number of methods
                    methodCount += t.GetMethods().Count();
                }
                // output the number of types and their methods
                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name);
            }
        }
    }
}
