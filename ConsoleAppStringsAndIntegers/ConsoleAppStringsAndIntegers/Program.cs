using System;

namespace ConsoleAppStringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {   //int array 
                int[] numbers = { 2, 4, 1, 6, };
                Console.WriteLine("Enter a number: ");//message to user
                int num1 = Convert.ToInt32(Console.ReadLine());//int num1 read
                Console.WriteLine("\n");//new line
                for (int x = 0; x < numbers.Length; x++)// a for loop that runs all numbers by incrementing by 1 everytime it passes
                {
                    Console.WriteLine(numbers[x] / num1);//outputs the total divide the index number by the users input

                }
            }
            catch(FormatException ex)//if format is not correct
            {
                Console.WriteLine(ex.Message);//prints out a message to user
            }

            catch(DivideByZeroException ex)//can not divide by zero error
            {
                Console.WriteLine("Can not divide by zero");//message
            }

            catch(Exception ex)//any other error
            {
                Console.WriteLine(ex.Message);//message
            }
            finally
            {
               
                Console.ReadLine();//runs to this line
            }

            Console.WriteLine("Emerged from the try/catch block");

            Console.ReadLine();
        } 
    }
}
