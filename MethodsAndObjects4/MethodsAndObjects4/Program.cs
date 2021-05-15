using System;

namespace MethodsAndObjects4
{
    class Program //class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//instansiating the class
            employee.fname = "John";//assigning a string value to the employee class from fname
            employee.lname = "Smith";//assigning a string value
            employee.SayName();//calling our SayName() which will output the console.writeline in Person.cs
            Console.ReadLine();//so program doesnt end abrupt
        }
    }
}
