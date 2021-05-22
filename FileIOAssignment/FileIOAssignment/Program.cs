using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter a number ?");
            string num = Console.ReadLine();
            File.ReadAllText("C:\\Users\\Owner\\Documents\\FilePath");
            using (StreamWriter File = new StreamWriter("C:\\Users\\Owner\\Documents\\FilePath", true))
            {
                File.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
