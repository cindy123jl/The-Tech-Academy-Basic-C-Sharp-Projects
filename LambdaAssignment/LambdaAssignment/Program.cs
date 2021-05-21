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
                new empInfo { Name = "Guido", lName = "Mista", ID = 1 },
                new empInfo { Name = "Jotaro", lName = "Kujo", ID = 2 },
                new empInfo { Name = "Joseph", lName = "Joestar", ID = 3 },
                new empInfo { Name = "Sasuke", lName = "Uchiha", ID = 4 },
                new empInfo { Name = "Joe", lName = "Kim", ID = 5 },
                new empInfo { Name = "Giorno", lName = "Giovanna", ID = 6 },
                new empInfo { Name = "Trisha", lName = "Una", ID = 7 },
                new empInfo { Name = "Joe", lName = "Luna", ID = 8 },
                new empInfo { Name = "Ninel", lName = "Hune", ID = 9 },
                new empInfo { Name = "Sakura", lName = "Haka", ID = 10 }

            };

            List<empInfo> theEmp = new List<empInfo>();//list
            
            // for each loop
            foreach (var empl in Employees)
            {
                if (empl.Name == "Joe") //if eml name is "Joe"
                {
                    theEmp.Add(empl);//add 

                }
                
            }
            foreach (var empl in theEmp) 
            {
                Console.WriteLine(empl.Name);//writes out Joe two times since its exist two times
            }




           // List<empInfo> newL = new List<empInfo>();

            List<empInfo> Employee2 = Employees.Where(y => y.Name == "Joe").ToList();//lambda expression looking for Joe

            foreach (var emp2 in Employee2)
            {
                Console.WriteLine(emp2.Name);
                
            }




            //List<empInfo> NewL = new List<empInfo>();
            //this will retrieve the employees with id greater than 5 
            List<empInfo> Employee = Employees.Where(x => x.ID > 5).ToList();
          
            foreach (var emp in Employee)
            {   //will display those with id greater than 5
                Console.WriteLine(emp.Name);
            }
          

            

            Console.ReadKey();


        }
    }
}
