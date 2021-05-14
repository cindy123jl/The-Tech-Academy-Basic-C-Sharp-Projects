using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math MathObj = new Math(); //instantiating 
            Console.WriteLine("Please enter a number: ");//asking the user to enter a number
            int num1 = int.Parse(Console.ReadLine());// reading the users input as an integer

            Console.WriteLine("Enter a second number(optional): ");//asking the user for a second number which is optional
            string num2 = Console.ReadLine();//reading the number inputted as a string

            if (string.IsNullOrEmpty(num2))// if out string num2 is left empty we run this if statement
            {
                num2 = "0"; //if null or empty then num2 is 0 
            }

            int total = MathObj.MethodOne(num1, int.Parse(num2));//calling our method

            Console.WriteLine("The total is : " + total);//displaying our output
        }
    }
}
