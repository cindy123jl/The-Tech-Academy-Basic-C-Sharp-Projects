using System;
namespace MethodsAndObjects4
{
    public class Person
    {
       public string fname { get; set; }
       public string lname { get; set; }
       public void SayName()
        {
            Console.WriteLine("Name: " + fname + " " + lname);
            Console.ReadLine();


        } 
    }
}
