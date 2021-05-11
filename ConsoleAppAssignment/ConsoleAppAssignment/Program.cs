using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //creating a string with 5 indexes
            string[] drinks = { "Water", "Kombucha", "Sparkling Water", "Tea", "Smoothie" };
            Console.WriteLine("Enter a type of drink:");//print out
            string drinkName = Console.ReadLine();//readline
            Console.WriteLine("\n");//newline

            for (int x = 0; x < drinks.Length; x++)// for int x equal 0 to index length increment by 1
            {

                Console.WriteLine(drinks[x]);//print out list 

            }
            Console.WriteLine(drinkName + "\n");//print out list plus the entered drink name

            int[] NumberofDrinks = { 1 }; //number of drinks string index of 1
            Console.WriteLine("Enter the number of drinks: ");//output for user
            string number = Console.ReadLine();//read users input
            int num = Convert.ToInt32(number);//cast our string into an integer
            Console.WriteLine("\n");//newline

            for (int w = 0; w < NumberofDrinks.Length; w++)//for int w = 0 increment by 1
            {
                if (num >= 5)//if the input is greater or equal to 5
                {
                    Console.WriteLine("Sorry, we can only give out at most 4 drinks.");//message to user
                }
                if (num <= 4)//if input is less than or equal to 4
                {
                    Console.WriteLine("Thank you, " + number + " drinks");//print out message and their input
                }

            }

            //string regarding ice amount length of 4 
            List<string> iceAmount = new List<string>() { "none", "light", "medium", "heavy" };
            //message to user
            Console.WriteLine("\nEnter amount of ice: ");
            string choice = Console.ReadLine();//read input line

            Console.WriteLine("\n");//newline
            if (choice == "none" && choice == "light" && choice == "medium" && choice == "heavy")
            {//if choice equal the items in the string run one the following if statements
                if (choice == "none")//if choice = none
                {
                    Console.WriteLine("Amount of ice " + iceAmount[0]);//print out the message than the string

                }

                if (choice == "light")//choice = light
                {
                    Console.WriteLine("Amount of ice " + iceAmount[1] + " amount");//print out this

                }

                if (choice == "medium")//if choice == medium 
                {
                    Console.WriteLine("Amount of ice " + iceAmount[2] + " amount");//print this out

                }

                if (choice == "heavy")//if choice = heavy
                {
                    Console.WriteLine("Amount of ice " + iceAmount[3] + " amount");//print out this

                }

            }
            else//if none of the conditions are met from above print the following message 
            {
                Console.WriteLine("\nPlease enter ie. none, light, medium, heavy: ");
                string choice2 = Console.ReadLine();//read line
                if (choice2 == "none") // choice2 = none
                {
                    Console.WriteLine("Amount of ice " + iceAmount[0]);//print

                }

                if (choice2 == "light")//choice2 = light
                {
                    Console.WriteLine("Amount of ice " + iceAmount[1] + " amount");//print

                }

                if (choice2 == "medium")//choice2 = medium
                {
                    Console.WriteLine("Amount of ice " + iceAmount[2] + " amount");//print

                }

                if (choice2 == "heavy")//choice2 = heavy
                {
                    Console.WriteLine("Amount of ice " + iceAmount[3] + " amount");//print

                }
            }

            //a list datatype string with 4 indexes
            List<string> drinkSize = new List<string> { "tall", "tall", "grande", "venti" };

            Console.WriteLine("\nEnter size of drink ie. tall, grande, venti: ");//output
            string choice3 = Console.ReadLine();//input


            Console.WriteLine("\n");//newline

            if (choice3 == "tall" && choice3 == "grande" && choice3 == "venti")//if the input is any of these
            {
                //run this if loop if choice3 = tall
                if (choice3 == "tall")
                {
                    Console.WriteLine(drinkSize[0] + " Index[0]" + ("\n") + drinkSize[1] + " Index[1]");
                }
                if (choice3 == "grande")//choice3 = grande
                {
                    Console.WriteLine(drinkSize[2] + " Index[2]");//print outs the string index at index 2
                }
                if (choice3 == "venti")//choice3 = venti
                {
                    Console.WriteLine(drinkSize[3] + " Index[3]");//prints out index
                }
            }

            else//if none of the inputs are true for above run this else statement
            {
                if (choice3 != "tall" && choice3 != "grande" && choice3 != "venti")//!= does not equal
                {
                    Console.WriteLine("Your input is not in the list\n");//message to user

                }
            }

            //list string datatype called month 
            List<string> months = new List<string> { "Jan", "Feb", "Feb", "Mar", "April" };
            //used for a foreach method this evaluates
            IEnumerable<string> duplicates = months.GroupBy(x => x).SelectMany(g => g.Skip(1));
            //access the loop in order
            foreach (string month in months)
            {
                Console.WriteLine(month);
                if (duplicates.Contains(month))//if we have a duplicate this will show under the said duplicate
                {
                    Console.WriteLine("We have a duplicate, " + month + " is our duplicate.");
                }
                
        
            }
            Console.ReadLine();

        }

    }
}
      

    
