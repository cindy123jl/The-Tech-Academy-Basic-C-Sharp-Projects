using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Operations // our class called Operations which can be called to our Program.cs
    {
        public int Methods(int num1) // one of our methods in int 
        {
            int total = num1 + 3; // num1 is is what the user put in for their number adding 3 to it and setting the total
            return total;         // to int and then returning the total so we can then read in our Program.cs
        }

        public double Methods(double num2)// methods that will take in a double
        {
            double total2 = num2 * 3; // the total2 will come out as a double but we will need to cast it into a int and
            double Total2 = Convert.ToInt32(total2);// we do that here
            return Total2;//then we return the total2 as a int 
        }

        public string Methods(string num3)
        {
            int Num3 = Convert.ToInt32(num3);
            string Total3 = Convert.ToInt32(total3);
            int Total3 = Num3 / 2;
           // int total3 = Convert.ToInt32(Total3);
            return Total3;
        }
    }
}
