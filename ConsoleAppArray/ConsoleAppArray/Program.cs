using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a an array called select with 4 indexes
            string[] select = new string[4];
            select[0] = "dog";//indexes start with 0
            select[1] = "cat";
            select[2] = "bird";
            select[3] = "hamster";
  
            Console.WriteLine("Please choose an index: ");//asking user to type in a number
            string number = Console.ReadLine();//reading the users input
            int n = Convert.ToInt32(number);//casting our string into an int

            if(n == 0) //if n the users input is equal to the number 0
            {
                Console.WriteLine(select[0]);//we print our index 0 which is the string dog
                
            }

            if(n == 1)//if n is equal to the number 1 
            {
                Console.WriteLine(select[1]);//print out index 1
                
            }
            if(n == 2) //if n is equal to number 2
            {
                Console.WriteLine(select[2]);//print out index 2
                
            }
            if(n == 3)
            {
                Console.WriteLine(select[3]);
                
            }
            if(n > 3) //if user inputs anything larger than the number 3 
            {
                Console.WriteLine("index does not exist");//we do not have an index at any location greater than 3
                
            }

            int[] selectNumber = new int[4];//creating an array called selectNumber
            selectNumber[0] = 22;//at index 0 we have the value of 22
            selectNumber[1] = 2;//at index 1 we have the value of 2
            selectNumber[2] = 21;
            selectNumber[3] = 89;

            Console.WriteLine("Please choose an index: ");//asking the user to choose an index number
            string selection = Console.ReadLine();//reading the users input
            int s = Convert.ToInt32(selection);//casting the string into an integer

            if (s == 0)//if s what the user put in is equal to 0 print out index 0 
            {
                Console.WriteLine(selectNumber[0]);
                
            }

            if (s == 1) //if s is equal to 1 print out index 1
            {
                Console.WriteLine(selectNumber[1]);
               
            }
            if (s == 2)//if s is equal to 2 print out index 2
            {
                Console.WriteLine(selectNumber[2]);
                
            }
            if (s == 3)//if s is equal to 3 print out index 3
            {
                Console.WriteLine(selectNumber[3]);
                
            }
            if (s > 3) //if anything greater than 3 is typed out than print index does't exist
            {
                Console.WriteLine("index does not exist");
                
            }

            List<string> stringList = new List<string>();//creating a list 
            stringList.Add("Tanjiro");//assigning our string indexes values 
            stringList.Add("Ichigo");
            stringList.Add("Koichi");
            stringList.Add("Bruno");

            Console.WriteLine("Please enter an index number: ");//asking the user to input an index number
            string selection2 = Console.ReadLine();//reading the users input
            int select2 = Convert.ToInt32(selection2);//casting the string into an integer

            if (select2 == 0)//if what the user put in is equal to 0 print out index 0 
            {
                Console.WriteLine(stringList[0]);//Tanjiro
                
            }
            if (select2 == 1)//if equal to 1
            {
                Console.WriteLine(stringList[1]);//Ichigo
                
            }
            if(select2 == 2)//if equal to 2
            {
                Console.WriteLine(stringList[2]);//Koichi
                
            }
            if(select2 == 3)//if equal to 3
            {
                Console.WriteLine(stringList[3]);//Bruno
                
            }
            if(select2 > 3)//anything greater than 3
            {
                Console.WriteLine("index does not exist");//does not exist
                
            }
        }
    }
}
