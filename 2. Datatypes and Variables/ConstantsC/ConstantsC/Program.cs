using System;

namespace ConstantsC
{
    internal class Program
    {

        // Constants are immutable values that are known at compile time and do not change during the lifecycle of a program.
        // Constants are declared using the const keyword.
        // Constants can be declared at the namespace, class, or method level.
        // Constants can be of any of the built-in types or user-defined types that are based on a built-in type.
        // Constants are implicitly static and read-only.
        // Constants must be initialized at the time of declaration or in a static constructor.
        // Constants can be initialized with a default value or with a value provided in a static constructor.

        // Constants as fields
        // Constants can be declared as --fields-- of a class or struct. 


        const double pi = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "26/03/1980";

        
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is {0}.", myBirthday);
        }
    }
}
