using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's create some variables
            int age = 42;
            string name = "Luke";
            string job = "Engineer";

            //1. String concatenation
            Console.WriteLine("Example 1: String Concatenation.");
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            //2. String interpolation
            Console.WriteLine("Example 2: String Interpolation.");
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");

            //3. String formatting
            Console.WriteLine("Example 3: String Formatting.");
            Console.WriteLine(string.Format("Hello, my name is {0}, I am {1} years old and I work as an {2}.", name, age, job));

            //4. Verbatim strings
            Console.WriteLine("Example 4: Verbatim Strings.");
            Console.WriteLine(@"Hello, my name is Luke.
            I am 42 years old.
            I work as an Engineer.");

            //5. String comparison
            Console.WriteLine("Example 5: String Comparison.");
            string name1 = "Luke";
            string name2 = "luke";
            Console.WriteLine(name1 == name2);

       





        }
    }
}
