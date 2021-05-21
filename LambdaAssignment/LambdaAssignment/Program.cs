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
        {       ///List with each element of type empinfo
            List<empInfo> Employees = new List<empInfo>()
            {   //creating our list with values given to name and id
                new empInfo { Name = "Guido Mista", ID = 1 },
                new empInfo { Name = "Jotaro Kujo", ID = 2 },
                new empInfo { Name = "Joseph Joestar", ID = 3 },
                new empInfo { Name = "Sasuke Uchiha", ID = 4 },
                new empInfo { Name = "Joe Kim", ID = 5 },
                new empInfo { Name = "Giorno Giovanna", ID = 6 },
                new empInfo { Name = "Trisha Una", ID = 7 },
                new empInfo { Name = "Joe Hughs", ID = 8 },
                new empInfo { Name = "Ninel Rich", ID = 9 },
                new empInfo { Name = "Sakura Hataka", ID = 10 }

            };

            var Employee2 = Employees.FindAll(y => y.Name == "Joe");

            foreach (var emp2 in Employee2)
            {
                Console.WriteLine(emp2.Name);
            }
            

            //this will retrieve the employees with id greater than 5 
            var Employee = Employees.FindAll(x => x.ID > 5);
          
            foreach (var emp in Employee)
            {   //will display those with id greater than 5
                Console.WriteLine(emp.Name);
            }
            Console.ReadKey();

            


        }
    }
}
