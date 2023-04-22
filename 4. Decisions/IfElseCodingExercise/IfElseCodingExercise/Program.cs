using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        // Implement method Check that will take an int as an argument and check if it is an odd number or even. Depending on the testing result, it should print a message on the new line "Odd" or "Even" respectively.
        public static void Check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        // Call the method Check from the Main method with the argument 5.
        static void Main(string[] args)
        {
            Check(5);
        }
    }
}
