using System;
using System.IO;
using System.Net;

namespace UnderstandingNamespaceAndDontNetClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string text = "We want to write this to our file.";
            
            File.WriteAllText(@"G:\CSharp\BobTabor\BobTabor\UnderstandingNamespaceAndDontNetClassLibrary\WriteText.txt", text);
            */

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            
            Console.WriteLine(reply);
            File.WriteAllText(@"G:\CSharp\BobTabor\BobTabor\UnderstandingNamespaceAndDontNetClassLibrary\WriteText.txt", reply);

            

            Console.ReadLine();
        }
    }
}
