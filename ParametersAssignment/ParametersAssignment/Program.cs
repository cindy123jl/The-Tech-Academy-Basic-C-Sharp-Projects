using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employees<string> things1 = new Employees<string>();
            things1.Things = new List<string>() { "Cars", "trucks", "animals" };
            Employees<int> things2 = new Employees<int>();
            things2.Things = new List<int>() { 2, 4, 6, };
            foreach (string items1 in things1.Things)
            {
                Console.WriteLine(items1);
            }

            foreach (int items2 in things2.Things)
            {
                Console.WriteLine(items2);
            }
            Console.ReadLine();

        }
       
    }
}