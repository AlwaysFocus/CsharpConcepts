using System;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"/Users/eli/Programming/C#/C#FromBeginnerToAdvanced/HandlingExceptions/content.txt");
                Console.WriteLine(content);
            }
            
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: '{e.Message}'");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"The directory was not found: '{e.Message}'");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"You do not have access to the specified location: '{e.Message}'");
            }
            // Exception is the most general type of exception
            // There are more types that are more specific.

            catch (Exception ex)
            {
                Console.WriteLine("There was an issue: ");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                // Code to finalize
                // Setting Objects to Null
                // Closing database connections

                Console.WriteLine("Closing application now...");
            }



            Console.ReadLine();

        }
    }
}
