using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
//The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application.

//In the Main() program, ask the user what number they want to do the math operations on.

//Call each method in turn, passing the user input to the method.Display the returned integer to the screen.



namespace CallingMethods
{
   public class Numbers //class called numbers
    {

        static void Main(string[] args)
        {

            Math MathObj = new Math();
            double num2 = 2; //assigning num2 a value of 2 
            Console.WriteLine("Please enter a number: ");//asking user to input a number
            double num1 = double.Parse(Console.ReadLine()); // reading the user input

            

            double total = MathObj.MethodOne(num1);

            Console.WriteLine(num1 + " + " + num2 + " = " + total);

            double total2 = MathObj.MethodTwo(num1);

            Console.WriteLine(num1 + " * " + num2 + " = " + total2);

            double total3 = MathObj.MethodThree(num1);

            Console.WriteLine(num1 + " / " + num2 + " = " + total3);

            Console.ReadLine();


        }
    }
}
