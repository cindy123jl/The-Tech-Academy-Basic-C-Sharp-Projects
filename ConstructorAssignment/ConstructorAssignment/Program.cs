using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            const string petName = "Lola";// string petName is assigned a value of Lola const cant be changed
            Console.WriteLine("{0} is 3", petName);//reading the name and age

            var info = new petInfo(); //creating a new instance for petInfo class

            info.petName = "Sophie"; //assigning sophie to the petInfo object
            info.age = 5;//assigning 5 as pet age to the petInfo instance
            Console.WriteLine(info.petName + " is " + info.age);//printing values to user
            Console.ReadLine();

        }
    }
}
