using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//instantiating
            employee.fname = "Mary";// first name 
            employee.lname = "Jane";//last name
            employee.SayName();// will get line from Employee.cs
           
            IQuittable quit = new Employee();//instantiating
            quit.Quit();

            Console.ReadLine();//so it doesnt end abruptly
        }
    }
}
