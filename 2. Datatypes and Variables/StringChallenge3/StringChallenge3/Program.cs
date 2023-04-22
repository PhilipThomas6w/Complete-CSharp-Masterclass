using System;

namespace StringChallenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask the user for their name.
            Console.WriteLine("What is your name?");
            var firstName = Console.ReadLine();
            // 2. Ask the user for their surname.
            Console.WriteLine("What is your surname?");
            var lastName = Console.ReadLine();
            var fullName = firstName + " " + lastName;
            //3. Print the user's full name.
            Console.WriteLine(fullName);
            
        }
    }
}
