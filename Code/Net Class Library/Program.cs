using System;
using System.IO;
using System.Net;

namespace NETClassLibraryExamples
{
    class Program
    {
        static void Main(string[] args)
        {           

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=net-5.0");

            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            File.WriteAllText(@"/Users/eli/Programming/C#/C#FromBeginnerToAdvanced/NetClassLibrary/writetext.txt", reply);

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
