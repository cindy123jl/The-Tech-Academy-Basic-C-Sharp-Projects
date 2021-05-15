using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//instantiating
            employee.fname = "Mary";// first name 
            employee.lname = "Jane";//last name
            employee.SayName();// will get line from Employee.cs
            Console.ReadLine();//so program doesn't end abruptly

            
        }
    }
}
