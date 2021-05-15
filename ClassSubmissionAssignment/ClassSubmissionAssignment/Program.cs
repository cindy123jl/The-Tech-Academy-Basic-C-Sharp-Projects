using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Operations mathObj = new Operations();//initializing
            int num1;
            mathObj.methodOne(out num1);//num1 is retrieved from methodOne 
            Console.ReadLine();
           
        }   
    }
}
