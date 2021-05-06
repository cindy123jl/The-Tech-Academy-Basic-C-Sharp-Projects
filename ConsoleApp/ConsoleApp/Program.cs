using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //assigning i a value of 0
            int i = 0;
            while (i < 5) //while i is less than 5 run program
            {
                Console.WriteLine(i);//printing out what i is while running the program it should print 0-4
                i++;//increment by 1
            }


            //asking the user what their favourite color is
            Console.WriteLine("Guess my favourite color: ");
            string color = Console.ReadLine(); //read users input 
            bool GuessedColor = color == "blue"; //data type bool called GuessedColor is assigned a value of color where it equals blue

           

            do
            {
                switch (color)//we are passing color to the cases below
                {
                    case "pink"://if user answers pink it will prompt a message and ask users to guess again
                        Console.WriteLine("I like pink but it's not my favourite color!");
                        Console.WriteLine("Guess another color: ");
                        color = Console.ReadLine();//takes in the users input
                        break;
                    case "red"://if users answers red it prompts a message and asks them to try again
                        Console.WriteLine("Red is not my favourite color!");
                        Console.WriteLine("Guess another color: ");
                        color = Console.ReadLine();
                        break;
                    case "green"://if answer is green
                        Console.WriteLine("Green is an okay color but not my favourite!");
                        Console.WriteLine("Guess another color: ");
                        color = Console.ReadLine();
                        break;
                    case "blue":// if blue is answered which is what we assigned color it will print a message
                        Console.WriteLine("Good Job!!! Blue is my favourite color! To be more specific I like the shade olympic");
                        GuessedColor = true;//guessed color is true
                        break;
                    default:
                        Console.WriteLine("Not my favourite color, nice try! ");//if anything else is put in as the answer 
                        Console.WriteLine("Guess another color: ");//asks to guess again
                        color = Console.ReadLine();
                        break;


                }
            }

                while (!GuessedColor) ; //program continues as long as Guessed color isn't correctly guessed

                Console.ReadLine();

            }
        }
    }

