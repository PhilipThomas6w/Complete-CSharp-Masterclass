using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First, let's create a string to work with.
            string myString = "This is a string.";
            Console.WriteLine("Original string: " + myString);

            // Now, let's convert it to uppercase.
            string upperString = myString.ToUpper();
            Console.WriteLine("Uppercase string: " + upperString);

            // Now, let's convert it to lowercase.
            string lowerString = myString.ToLower();
            Console.WriteLine("Lowercase string: " + lowerString);

            // Now, let's replace a substring.
            string replaceString = myString.Replace("string", "sentence");
            Console.WriteLine("Replaced string: " + replaceString);

            // Now, let's remove a substring.
            string removeString = myString.Remove(10, 6);
            Console.WriteLine("Removed string: " + removeString);

            // Now, let's insert a substring.
            string insertString = myString.Insert(10, " short");
            Console.WriteLine("Inserted string: " + insertString);

            // Now, let's trim the string.
            string trimString = " This string has extra spaces. ";
            Console.WriteLine("Original string: " + trimString);
            string trimmedString = trimString.Trim();
            Console.WriteLine("Trimmed string: " + trimmedString);

            // Now, let's split the string.
            string splitString = "This string will be split.";
            Console.WriteLine("Original string: " + splitString);
            string[] splitArray = splitString.Split(' ');
            Console.WriteLine("Split string: ");
            foreach (string s in splitArray)
            {
                Console.WriteLine(s);
            }

            // Now, let's get a substring.
            string subString = myString.Substring(10);
            Console.WriteLine("Substring: " + subString);

            // Now, let's get a character.
            char myChar = myString[5];
            Console.WriteLine("Character: " + myChar);

            // Now, let's get the length.
            int myLength = myString.Length;
            Console.WriteLine("Length: " + myLength);

            // Now, let's get the index of a substring.
            int myIndex = myString.IndexOf("string");
            Console.WriteLine("Index: " + myIndex);

            // Now, let's get the last index of a substring.
            int myLastIndex = myString.LastIndexOf("string");
            Console.WriteLine("Last index: " + myLastIndex);
            
            

        }
    }
}
