using System;

namespace StringChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a string variable but don't assign a value
            string myString = "";
            // Print to the console "Please enter your name and press enter".   
            Console.WriteLine("Please enter your name and press enter");
            // Assign the user input to the string variable
            myString = Console.ReadLine();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", myString.ToUpper(), myString.ToLower(), myString.Length, myString.Substring(0, 1));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
        }
    }
}
