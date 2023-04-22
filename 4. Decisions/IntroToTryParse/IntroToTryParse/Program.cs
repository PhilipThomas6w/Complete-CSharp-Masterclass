using System;

namespace IntroToTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: "); // Prompt user for input
            string numberAsString = Console.ReadLine(); // Read user input and store it in a string variable.
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue); // The TryParse method takes a string and an out parameter. It returns true if the string can be parsed into the out parameter, and false if it cannot.
            if (success)
            {
                Console.WriteLine("The string variable {0} was successfully parsed to an integer variable {1}.", numberAsString, parsedValue);
            }
            else
            {
                Console.WriteLine("Could not parse the string.");
            }
            Console.Read();
            
        }
    }
}
