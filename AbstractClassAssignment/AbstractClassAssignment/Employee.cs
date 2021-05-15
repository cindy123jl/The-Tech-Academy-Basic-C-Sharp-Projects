using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
        public class Employee : Person //class Employee inheriting from Person
        {
            public override void SayName()//new implementation from the inherited class
            {
                Console.WriteLine(fname + " " + lname);//will be returned 
            }
            
            
        }
    
}
