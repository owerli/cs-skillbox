using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine($"{number} is even number!");
            else Console.WriteLine($"{number} is odd number!");

            Console.ReadKey();

        }
    }
}
