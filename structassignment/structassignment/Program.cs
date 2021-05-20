using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStructProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numbers = new Number();
            numbers.Amount = 22.91m;
            Console.WriteLine(numbers.Amount);
            Console.ReadLine();
        }
    }
}
