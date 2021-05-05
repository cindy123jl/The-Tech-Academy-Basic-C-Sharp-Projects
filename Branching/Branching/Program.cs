using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // assigning a variable the value of 50 
            int ExpressWeight = 50;
            // printing out a greeting and asking the user the weight of a package
            Console.WriteLine("Welcome to the Package Express.\nPlease follow the instructions below. ");
            Console.WriteLine("Please enter package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            // if weight is larger than expressweight of 50 we print out a message and program is terminated
            if (weight > ExpressWeight)
            {
                Console.WriteLine("Sorry, package is too heavy to be shipped via Package Express");
            }
            // if package is 50 or under it will aske the user for the dimensions
            else
            {
                Console.WriteLine("Please enter package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimensions = width + height + length;//here we calculate the dimensions from the users input

                if ((dimensions > 50)) //if the dimensions are greater than 50 we print a message and terminate the program
                {
                    Console.WriteLine("Sorry, package is too heavy to be shipped via Package Express");
                }
                else //else we multiply and deivide by 100 to give out the user the total to ship package
                {
                    int quote = (height * width * length * weight) / 100;
                    Console.WriteLine("Your estimated total is $" + quote);
                }
            }


        }
    }
}
