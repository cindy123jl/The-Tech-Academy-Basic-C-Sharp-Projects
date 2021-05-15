using System;
namespace MethodsAndObjects4
{
    public class Person
    {
       public string fname { get; set; }// return the fname and set fname
       public string lname { get; set; }// return our string lname and set 

       public void SayName()//method
        {
            Console.WriteLine("Name: " + fname + " " + lname);//what we want to output
            Console.ReadLine();//so console doesn't end abruptly


        } 
    }
}
