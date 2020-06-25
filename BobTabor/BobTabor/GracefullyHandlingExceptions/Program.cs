using System;
using System.IO;

namespace GracefullyHandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"G:\CSharp\BobTabor\BobTabor\GracefullyHandlingExceptions\Exampl.txt");
                Console.WriteLine(content); 
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Exampl.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory G:\CSharp\BobTabor\BobTabor\GracefullyHandlingExceptions Exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now.........");
            }
            Console.ReadLine();
        }
    }
}
