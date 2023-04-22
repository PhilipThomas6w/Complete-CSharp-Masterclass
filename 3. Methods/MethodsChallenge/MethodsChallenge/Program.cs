using System;

namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method declaration
            void PrintNTimes(string message, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(message);
                }
            }

            // Method call
            PrintNTimes("Hello world!", 5);
        }

    }

}
