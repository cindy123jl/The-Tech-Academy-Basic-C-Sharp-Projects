using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Days TheDays = new Days(); //instatiating

                Console.WriteLine("Enter the current day of the week: ");//asking user to input day of the week

                string input = Console.ReadLine(); //the users input is a string 

                var TheDay = (Day)System.Enum.Parse(typeof(Day), input); //coverting string to enum value



                Day parsedEnumValue = (Day)System.Enum.Parse(typeof(Day), input);//parsed through

                Console.WriteLine(System.Enum.Parse(typeof(Day), input));//reads the input to user

               

                Console.WriteLine("Today is {0}.", parsedEnumValue, input);//readin to the user what they input

                

            }
            catch (FormatException e)//when the format id invalid this will be returned
            {

                Console.WriteLine("unable to convert." + e);

                return;

            }
            catch (Exception e)//if any errors occur
            {

                Console.WriteLine(e.Message);

            }
            finally//what happens id program is all good
            {

                Console.ReadLine();

            }

        }
    }
}
