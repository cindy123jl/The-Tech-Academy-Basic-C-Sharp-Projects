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
   public class Numbers
    {
        

        static void Main(string[] args)
        {
            double num2 = 2;
            Console.WriteLine("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Math User = new Math(num1, num2); 

        }
    }
}
