using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime CurrentTime = DateTime.Now; //CurrentTime is named to call time and date

            Console.WriteLine(CurrentTime);//call the current time

            Console.WriteLine("Enter a number: ");//we ask user to enter a number

            int num = Convert.ToInt32(Console.ReadLine());//will read the users input and store into num

            Console.WriteLine("Current time and date is {0} and in {1} hours it will be  {2}", CurrentTime, num , CurrentTime.AddHours(num));
            //we will print the current time and the users number input and it will show the total of the users number + the current time
            Console.ReadLine();
        }
    }
}
