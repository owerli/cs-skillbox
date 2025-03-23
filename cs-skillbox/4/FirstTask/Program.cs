using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input number of rows for matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Input number of columns for matrix: ");
            int columns = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[,] matrix = new int[rows, columns];
            int matrixValue = 0;

            for (int row = 0; row < matrix.GetLength(0); row++) {

                for (int column = 0; column < matrix.GetLength(1); column++) {

                    matrix[row, column] = rand.Next(101);
                    matrixValue += matrix[row, column];

                    Console.Write($"{matrix[row, column],3} ");

                }

                Console.WriteLine();

            }

            Console.WriteLine($"Sum of numbers in matrix is {matrixValue}");

        }

    }
    
}
