using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Math//class called math which is called in program.cs
    {
        private double num1;//double that can only be accessed by the class itself
        private double num2;// double has a value of num2 which is equal to 2 from main()
        private double total;// total so we can get the total from the two numbers

        public Math(double one, double two) 
        {
            num1 = one; // our num1 is one
            num2 = two; // num2 is two 
            Calculations();//for our Calculations below
            
        }
        private void Calculations()
        {
            total = num1 + num2; //doing math operations here we are adding
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, total); //calling input and value and displaying them to the user
            total = num1 * num2;// here we are multiplying
            Console.WriteLine("Multiplying {0} and {1} equals {2}", num1, num2, total);
            total = num1 - num2;//subtraction
            Console.WriteLine("Subtracting {0} and {1} equals {2}", num1, num2, total);
            Console.ReadLine();//readline so program doesnt end abrubtly
        }
    }
}
