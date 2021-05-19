using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees theEmployee = new Employees();//instantiating 
            Employees theEmployee2 = new Employees();//instantiating

            theEmployee.fname = "Guido"; // our first emp first name
            theEmployee.lname = "Mista"; // our first emp last name 
            theEmployee.Id = "875379"; // their id

            
            theEmployee2.fname = "Giorno";// 2nd emp "theEmployee2" first name
            theEmployee2.lname = "Giovanna";// last name
            theEmployee2.Id = "987654";//id as a string

            Console.WriteLine("Does employee 1 and 2 have the same id: " + (theEmployee.Id == theEmployee2.Id));//comparing emp1 and emp2 id and will print out the result from Employee.cs

            Console.ReadLine();
        }
    }
}
