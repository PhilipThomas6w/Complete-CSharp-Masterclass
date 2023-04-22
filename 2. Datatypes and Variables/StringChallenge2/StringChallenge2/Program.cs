using System;

namespace StringChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input a string
            Console.WriteLine("Enter a string here: ");
            var input = Console.ReadLine();
            // Ask the user what character they want to search for
            Console.WriteLine("Enter a character to search for: ");
            // Print the number of times the character appears in the string
            var character = Console.ReadLine();
            var count = 0;
            foreach (var c in input)
            {
                if (c.ToString() == character)
                {
                    count++;
                }
            }
            Console.WriteLine("The character appears {0} times in the string.", count);

            // Print the index of the every occurrence of the character
            var index = 0;
            foreach (var c in input)
            {
                if (c.ToString() == character)
                {
                    Console.WriteLine("The character appears at index {0}.", index);
                }
                index++;
            }
            
        }
    }
}


