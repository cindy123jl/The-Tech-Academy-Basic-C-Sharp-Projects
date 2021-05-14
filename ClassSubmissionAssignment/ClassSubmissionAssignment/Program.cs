using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hiya, Please enter a number: ");
            string num1 = Console.ReadLine();
            int Num1 = Convert.ToInt32(num1);
            
            int Num2; //Num2 is an integer datatype
            int total1;//total1 is an integer datatype

            Operations OpObj = new Operations();//instantiating the class

            OpObj.methodOne(out Num1, out Num2, out total1);
            Console.WriteLine("Number we will be dividing by " + Num2);
            Console.WriteLine("The total of" + Num1 + "/" + Num2+ "=" + total1);
        }
    }
}
