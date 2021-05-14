using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Hiya, Please enter a number: ");//asking user for input
            string num1 = Console.ReadLine();//reading the user input
            int Num1 = Convert.ToInt32(num1);// casting the string into a integer
            
            int Num2 = 2; //Num2 is an integer datatype
            int total1;//total1 is an integer datatype


            Operations OpObj = new Operations();//instantiating the class
            

            OpObj.methodOne(Num1, Num2, out total1);//passing by reference to the methods argument
            Console.WriteLine("Number we will be dividing by " + Num2);//telling user the number we will be dividing by
            Console.WriteLine("The total of " + Num1 + "/" + Num2 + "=" + total1);//showing user the equation and the total
            Console.ReadLine();
        }
    }
}
