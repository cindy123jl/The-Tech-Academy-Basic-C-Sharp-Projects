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
            int num2 = 2; //assigning num2 a value of 2 
            Console.WriteLine("Please enter a number: ");//asking user to input a number
            int num1 = int.Parse(Console.ReadLine()); // reading the user input

            
            // int total, calling our methods 
            int total = MathObj.MethodOne(num1, num2);
            // printing out the input of the user (num1) + num2 which is always equal to 2 and then the total
            Console.WriteLine(num1 + " + " + num2 + " = " + total);
            // int total2, calling out methods
            int total2 = MathObj.MethodTwo(num1, num2);
            //printing out the math for the user
            Console.WriteLine(num1 + " * " + num2 + " = " + total2);
            // our last mehod calling it from Math.cs
            int total3 = MathObj.MethodThree(num1, num2);

            Console.WriteLine(num1 + " / " + num2 + " = " + total3);
            //read line so program doesnt end abruptly
            Console.ReadLine();


        }
    }
}
