using System;

namespace DatatypesAndVariablesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a variable for each of the primitive data types
            int myInt = 5;
            float myFloat = 5.5f;
            double myDouble = 5.5;
            long myLong = 555555555555555555;
            bool myBool = true;
            char myChar = 'a';
            string myString = "Hello World";

            Console.WriteLine("Here are some examples of primitive data types:\nInteger - {0}" +
                "\nFloat - {1}\nDouble - {2}\nLong - {3}\nBoolean - {4}\nCharacter - {5}\nString - {6}\n", myInt, myFloat, 
                myDouble, myLong, myBool, myChar, myString);

            string string1 = "I control text";
            string string2 = "5";
            // Convert string2 to an int and store it in an int variable
            int string2AsInt = Convert.ToInt32(string2);
            // concatenate string1 and string2AsInt and store the result in a variable
            string string3 = string1 + " " + string2AsInt;
            // print the result to the console
            Console.WriteLine(string3);
            











        }
    }
}
