using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input a sequency length: ");
            int sequencyLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Input numbers one in line: ");

            int minNumber = int.MaxValue;
            for (int numberIndex = 1; numberIndex <= sequencyLength; numberIndex++) {

                int number = int.Parse(Console.ReadLine());
                if (number < minNumber) minNumber = number;

            }

            Console.WriteLine($"The lowest number in the sequency is {minNumber}.");

            Console.ReadKey();

        }
    }
}
