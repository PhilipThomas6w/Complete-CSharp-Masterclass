using System;

namespace TemperatureAdvisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius: ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("It's below freezing. You should wear a warm coat.");
            }
            else if (temperature < 10)
            {
                Console.WriteLine("It's cold. You should wear a jacket.");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("It's cool. You can wear a sweater.");
            }
            else if (temperature < 25)
            {
                Console.WriteLine("It's warm. You can wear a t-shirt.");
            }
            else
            {
                Console.WriteLine("It's hot. You can wear shorts.");
            }

            Console.Read();
            
        }
    }
}
