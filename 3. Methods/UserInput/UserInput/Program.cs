using System;

namespace UserInput
{
    class Program
    {
        /*public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello " + firstname + " " + lastname);
            
        }*/

        // Write a method that asks for a first name and a last name as standard input parameters and prints a full name.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastname = Console.ReadLine();
            PrintFullName(firstname, lastname);
        }


        // Write a method that takes two integers as standard inputs as parameters and prints the sum of the two integers.

        public static void SumOfTwoIntegers()
        {
            Console.WriteLine("Enter the first integer: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the two integers is: " + (firstInt + secondInt));
        }

        // Call the method in the Main method.
        public static void Main(string[] args)
        {
            SumOfTwoIntegers();
        }
        

    }
}
