using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEllo World!");

            Console.WriteLine("What is your name, User?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Hello, {name}. Today is {date:d}, {date:t}.");

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
