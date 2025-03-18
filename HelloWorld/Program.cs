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

            HelloWorld();

            System.Console.WriteLine("");

            HelloWorldUsingWrite();

            System.Console.ReadKey();

        }

        private static void HelloWorld()
        {

            System.Console.WriteLine(
                "Hello World!!!"
            );

        }

        private static void HelloWorldUsingWrite()
        {

            System.Console.Write(
                "Hello "    
            );
            System.Console.Write(
                "World"
            );
            System.Console.Write(
                "!!!"
            );

        }

    }
}
