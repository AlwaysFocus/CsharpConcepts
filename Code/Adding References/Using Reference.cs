using System;
using MyCodeLibrary;

namespace UsingReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Scrape myScrape = new Scrape();

            string reply = myScrape.ScrapeWebPage("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file");

            Console.WriteLine(reply);
        }
    }
}
