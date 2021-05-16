using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable //class Employee inheriting from Person and IQuittable
    {
        public override void SayName()//new implementation from the inherited class
        {
            Console.WriteLine(fname + " " + lname);//will be returned 
        }

        public void Quit() //implementing the quit method
        {
            Console.WriteLine("Quit");
        }

    }

}