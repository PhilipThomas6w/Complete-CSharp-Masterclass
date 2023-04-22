using System;

namespace NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            if (isRegistered)
            {
                Console.WriteLine("Enter your username: ");
                userName = Console.ReadLine();
                if (isAdmin)
                {
                    Console.WriteLine("Hello Admin");
                }
                else
                {
                    Console.WriteLine("Hello " + userName);
                }
            }
            else
            {
                Console.WriteLine("You are not registered");
            }

            Console.Read();
            
            





        }
    }
}
