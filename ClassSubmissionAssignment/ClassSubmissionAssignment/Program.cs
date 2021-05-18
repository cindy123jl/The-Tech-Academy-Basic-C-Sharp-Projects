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

            int ov = 96; // int ov is set tp 96 need ro give a value

            mathObj.methodOne(ov);// ov is retrieved from our overload method


            Console.ReadLine();
           
        }   
    }
}
