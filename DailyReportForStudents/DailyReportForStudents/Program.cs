using System;

namespace DailyReportForStudents 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THE TECH ACADEMY"); //displays the text in quotation marks to user

            Console.WriteLine("Student Daily Report"); //Console.Writeline(" ") shows the user whats in between the quotations

            Console.WriteLine("What is your name?"); // asking user their name

            string name = Console.ReadLine(); // reads input from the use

            Console.WriteLine("\nWhat course are you on?");// added a new line to give space. asking user a question

            string course = Console.ReadLine(); // reads input from the user

            Console.WriteLine("\nWhat page number?"); 

            string pageNumber = Console.ReadLine(); // assinging the value to string and reading the input

            int pageNum = Convert.ToInt32(pageNumber); // coverting the string into an int
            

            Console.WriteLine("\nDo you need help with anything, Please type true or false: "); // output

            string help = Console.ReadLine(); //reads input from user and stores in help

            bool helpNeeded = Convert.ToBoolean(help); //coverts the string into boolean

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics"); //output

            string exp = Console.ReadLine(); //reads input


            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific"); //output
             
            string feedback = Console.ReadLine(); // reads input and stores input

            Console.WriteLine("\nHow many hours did you study today?"); //output

            string hours = Console.ReadLine(); //input

            int hoursStudied = Convert.ToInt32(hours); //converted to integer

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly have a great day!"); //output at end of program

        }
    }
}
