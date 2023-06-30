using System;
using System.Linq;

namespace T01._Sum_Matrix_Elements
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
            int matrixElementsSum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                    matrixElementsSum += array[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(matrixElementsSum);
        }
    }
}
