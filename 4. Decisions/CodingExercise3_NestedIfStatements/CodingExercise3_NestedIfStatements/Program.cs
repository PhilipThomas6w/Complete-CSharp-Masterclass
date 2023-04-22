using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
                if (number % 2 == 0)
                {
                Console.WriteLine("Even number.");
                }
                else
                {
                Console.WriteLine("Odd number.");
                }
        }
        // Call the method here
        static void Main(string[] args)
        {
            NestedCheck(3);
            NestedCheck(7);
            NestedCheck(2);
            NestedCheck(1);
            NestedCheck(21);
            NestedCheck(49);
        }


    }
}
