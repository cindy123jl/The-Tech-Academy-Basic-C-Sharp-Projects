using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission3
{
   

    class Math//our class Math
    {
        public void MyMethod(int num1, int num2)//name of method is MyMethod void means method doesn't need to return value
        {
            Console.WriteLine("num1 with the value of 20 times the value of 5 equals: " + (num1 * 5));//this is ran num1 from Program.cs gets assigned here and is multiplied to 5
            Console.WriteLine("The value for num2: {0}", num2);//num2 is displayed to the screen
            Console.ReadLine();//avoids abrupt end
        }

       
    }
}
