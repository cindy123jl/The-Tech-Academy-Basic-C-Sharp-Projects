using System;

namespace MathComparison
{
    class Program
    {
        static void Main(string[] args)

        {   //This section is outputting two lines of text 
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            //here we are asking user for hourly rate and also casting input
            //into a double for more specific hours/min worked
            Console.WriteLine("Hourly Rate: ");
            string hrRate = Console.ReadLine();
            double hourlyRate = Convert.ToDouble(hrRate);

            //here we are asking for hours worked per week
            //casted into double 
            Console.WriteLine("Hours Worked per week: ");
            string hoursWorked = Console.ReadLine();
            double workedhrs = Convert.ToDouble(hoursWorked);

            //person 2 questions
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            string hrRate2 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(hrRate2);

            //casting into double and getting input 
            Console.WriteLine("Hours worked per week: ");
            string hoursWorked2 = Console.ReadLine();
            double workedhrs2 = Convert.ToDouble(hoursWorked2);

            //calculating the annual salary of person 1 by
            //multiplying rate, hours and the number of weeks in a year
            Console.WriteLine("Annual salary of Person 1: ");
            double total1 = hourlyRate * workedhrs * 52;
            Console.WriteLine(total1);
            Console.ReadLine();

            //calculating person 2 annual salary
            Console.WriteLine("Annual salary of Person 2: ");
            double total2 = hourlyRate2 * workedhrs2 * 52;
            Console.WriteLine(total2);
            Console.ReadLine();

            //we are comparing person 1 and person 2 salary to see
            //if person 1 makes more than person 2 outputs false or true
            //depending on what is true and outputing either false or true
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool total1vstotal2 = total1 > total2;
            Console.WriteLine(total1vstotal2);
            Console.ReadLine();


        }
    }
}
