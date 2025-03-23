using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input number of rows for A matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Input number of columns for A matrix: ");
            int columns = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[,] matrixA = new int[rows, columns];
            int[,] matrixB = new int[rows, columns];

            Console.WriteLine("Matrix A");
            for (int row = 0; row < matrixA.GetLength(0); row++)
            {

                for (int column = 0; column < matrixA.GetLength(1); column++)
                {

                    matrixA[row, column] = rand.Next(101);

                    Console.Write($"{matrixA[row, column],3} ");

                }

                Console.WriteLine();

            }

            Console.WriteLine("\nMatrix B");
            for (int row = 0; row < matrixB.GetLength(0); row++)
            {

                for (int column = 0; column < matrixB.GetLength(1); column++)
                {

                    matrixB[row, column] = rand.Next(101);

                    Console.Write($"{matrixB[row, column],3} ");

                }

                Console.WriteLine();

            }

            Console.WriteLine("\nMatrix A and B sum");
            for (int row = 0; row < matrixB.GetLength(0); row++)
            {

                for (int column = 0; column < matrixB.GetLength(1); column++)
                {

                    matrixB[row, column] += matrixA[row, column];

                    Console.Write($"{matrixB[row, column],3} ");

                }

                Console.WriteLine();

            }

        }
    }
}
