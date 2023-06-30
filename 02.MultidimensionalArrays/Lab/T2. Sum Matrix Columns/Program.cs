using System;
using System.Linq;

namespace T2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[, ] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int colSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    colSum += matrix[row, col];
                }

                Console.WriteLine(colSum);
            }
        }
    }
}
