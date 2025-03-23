using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());

            bool isDiv = false;
            int divider = 2;
            while (!isDiv && divider < number) {
            
                if (number % divider == 0) isDiv = true;
                divider++;

            }

            if (isDiv || number == -1 || number == 0 || number == 1) Console.WriteLine("It is not a prime number!");
            else Console.WriteLine("It is prime number!");

            Console.ReadKey();

        }

    }
}
