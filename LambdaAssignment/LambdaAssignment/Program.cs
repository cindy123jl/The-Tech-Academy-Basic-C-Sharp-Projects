using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Employees = new List<string>();

            Employees.Add("Guido Mista");
            Employees.Add("Giorno Giovanna");
            Employees.Add("Dio Brando");
            Employees.Add("Bruno Bucalletti");
            Employees.Add("Narancia Ghirga");
            Employees.Add("Leone Abbacchio");
            Employees.Add("Fugo Panaccotta");
            Employees.Add("Joe Kim");
            Employees.Add("Diavolo Doppio");
            Employees.Add("Joe Mar");

          
            foreach (string employees in Employees)
            {
                Console.WriteLine(employees.Contains("Joe"));
                Console.ReadLine();
            }


        }
    }
}
