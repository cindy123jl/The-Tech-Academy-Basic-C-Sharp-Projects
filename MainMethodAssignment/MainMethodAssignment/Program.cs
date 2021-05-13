using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class OperationClass //class called OperationClass
    {
        static void Main(string[] args)
        {
            Operations OperationsObj = new Operations();
            Console.WriteLine("Please enter a number: ");//asking the user to enter a number
            int num1 = int.Parse(Console.ReadLine());// reading the users input and storing it in num1

            int total = OperationsObj.Methods(num1);//calling total from our Methods in Operations.cs
            Console.WriteLine(total);// displaying total to the user


            Console.WriteLine("Please enter a decimal number: ");// asking the user to enter a decimal number
            double num2 = double.Parse(Console.ReadLine());// reading the input and storing it in num2

            double total2 = OperationsObj.Methods(num2); //calling total2 from our double Methods
            
            Console.WriteLine(total2);//displaying total to the user
            

            Console.WriteLine("Please enter another number: ");//asking the user to enter a number
            string num3 = (Console.ReadLine());//reading the users input as a string
           

            string Total3 = OperationsObj.Methods(num3);//string total3

           
            Console.WriteLine(Total3);//displaying total3 to the user



            
        }
    }
}
