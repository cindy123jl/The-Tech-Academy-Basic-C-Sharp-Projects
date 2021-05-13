using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class OperationClass
    {
        static void Main(string[] args)
        {
            Operations OperationsObj = new Operations();
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            int total = OperationsObj.Methods(num1);
            Console.WriteLine(total);


            Console.WriteLine("Please enter a decimal number: ");
            double num2 = double.Parse(Console.ReadLine());

            double total2 = OperationsObj.Methods(num2);
            
            Console.WriteLine(total2);
            Console.ReadLine();



            
        }
    }
}
