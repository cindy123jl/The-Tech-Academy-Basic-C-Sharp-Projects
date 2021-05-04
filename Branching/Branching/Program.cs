using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExpressWeight = 50;
            int ExpressDimensions = 50;
            

            Console.WriteLine("Welcome to the Package Express.\nPlease follow the instructions below. ");
            Console.WriteLine("Please enter package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please enter package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimensions = width + height + length;
            
            
            if (weight <= ExpressWeight && dimensions <= ExpressDimensions)
            {
                double total = (width * height * length * weight) / 100;
                Console.WriteLine("Your estimated total is $" + total);
            }

            
            else if(dimensions > ExpressDimensions && weight > ExpressWeight)
            {
                Console.WriteLine("Sorry, package is too heavy to be shipped via Package Express");
            }

        }
    }
}
