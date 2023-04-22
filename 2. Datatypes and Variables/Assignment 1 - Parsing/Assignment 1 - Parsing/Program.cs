using System;

namespace Assignment1Parsing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            // convert string into a float and print it
            float floatFromString = float.Parse(stringForFloat);
            // convert string into an int and print it
            int intFromString = int.Parse(stringForInt);

            // print the float and int
            Console.WriteLine($"Int = {intFromString}, Float = {floatFromString}");


        }
    }
}

