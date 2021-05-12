using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Math //class called math which is called in program.cs
    {
     
            public int MethodOne(int num1, int num2)// our method one  calling in num1 
            {
                int total = num1 + num2; //our total in int adding in num1 (users input) and num2 our assigned value
                return total; // returns our total to program.cs
            }

            public int MethodTwo(int num1, int num2)// our second method calling in our num1 input
            {
                 int total2 = num1 * num2;// multiplying num1 and num2 and returning total2
                 return total2;

            }
            public int MethodThree(int num1, int num2)// third method
            {
                int total3 = num1 / num2; // num1 divided by num2  equals our total3
                return total3;//total 3 gets returned

            }
    
    }
}
