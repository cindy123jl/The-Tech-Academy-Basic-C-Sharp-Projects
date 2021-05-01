using System;
using System.Threading;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user for their age
            Console.WriteLine("What is your age? ");
            string personsAge = Console.ReadLine();//reading the users input as a string
            int age = Convert.ToInt32(personsAge);//casting the string into a int
            //asking the user if they have had a dui
            Console.WriteLine("Have you ever had a DUI(enter false or true)? ");
            string dui = Console.ReadLine();//reading the string input from user
            bool dui1 = Convert.ToBoolean(dui);//casting the string to a bool value
            //asking the user about number of tickets
            Console.WriteLine("How many speeding tickets do you have? ");
            string ticketsNum = Console.ReadLine();//reading the users input
            int tickets = Convert.ToInt32(ticketsNum);//casting teh string into a int
            //displaying Qualafied to the user and depending on their
            //answers they will either get true of false for this question
            Console.WriteLine("Qualafied? ");
            bool result = (age > 15 && dui1 == false && tickets <= 3);//this part compares the values
            //the user input to what allows them to qualify. All of the conditions
            //need to be met for them to qualafy. Are they older than 15 (age > 16)
            //dui must equal false (dui1 == false) and tickets can be equal or less than 3
            //(tickets <= 3)
            Console.WriteLine(result);//prints either true or false depending if the conditions have been met
            
        }
    }
}
