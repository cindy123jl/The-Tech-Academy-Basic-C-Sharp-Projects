using System;

namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wha† is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hiya, " + name + "!");
            Console.Read();
        }
    }
}
