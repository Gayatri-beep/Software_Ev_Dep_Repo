using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");
            Console.WriteLine("Thank you for interacting. Program made by Gayatri Sivasamboo S Jeyakumar, for Task 1.2.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
