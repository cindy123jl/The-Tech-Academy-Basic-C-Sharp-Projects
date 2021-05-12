using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Math //class called math which is called in program.cs
    {
        private double num1;//double that can only be accessed by the class itself
        private double num2;// double has a value of num2 which is equal to 2 from main()
        private double total;// total so we can get the total from the two numbers
        private double total2;// total for second operations
        private double total3;// total for third operation
       
            public double MethodOne(double num1)// our method one  calling in num1 
            {
                double total = num1 + num2; //our total in double adding in num1 (users input) and num2 our assigned value
                return total; // returns our total to program.cs
            }

            public double MethodTwo(double num1)// our second method calling in our num1 input
            {
                 double total2 = num1 * num2;// multiplying num1 and num2 and returning total2
                 return total2;

            }
            public double MethodThree(double num1)// third method
            {
                double total3 = num1 / num2; // num1 divided by num2  equals our total3
                return total3;//total 3 gets returned

            }
    
    }
}
