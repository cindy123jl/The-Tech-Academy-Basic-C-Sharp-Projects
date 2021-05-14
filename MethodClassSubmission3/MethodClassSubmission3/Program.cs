using System;

namespace MethodClassSubmission3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;// num1 is assigned datatype of num1
            int num2;// num2 is assigned datatype

            Math MathObj = new Math(); //instantiating

            MathObj.MyMethod(out num1, out num2); // num1 is 5 and num2 is 3 from the values we gave them in our MyMethod 
            Console.WriteLine(num2);//display num2 which is the number3


        }
    }
}
