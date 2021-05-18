using System;
namespace ClassSubmissionAssignment
{
    public class Operations
    {   //our method 
        public void methodOne(out int num1)//void method out int num1 is used to pass argument to a method by reference 
        {
            num1 = 8; //num1 is assigned 8
            Console.WriteLine("Out num1 with the value is by 2: " + num1 / 2);//is shown to the screen and also makes the math operation
            Console.WriteLine("Enter a number: ");// asks user for input
            int num2 = Convert.ToInt32(Console.ReadLine());//users input is held in num2
            Console.WriteLine("Your input divided by 2: " + num2 / 2);//calculate and what is displayed
        }

        public void methodOne(int ov)//overloading method example 
        {
            ov = 200 / 10; // ov is 200/10
            Console.WriteLine("overloading example " + ov);//this will be what will be displayed to the screen one it is called by reference to program.cs
        }
        
        public void methodTwo(out int num3)//second void method
        {

            num3 = 2;// num3 has value of 2
        }

        static class Math// the static class called Math
        {
            public static void methodThree(out int num4)//another void method
            {
                num4 = 2; //num4 value 2
            }
        }

       

    }
}
