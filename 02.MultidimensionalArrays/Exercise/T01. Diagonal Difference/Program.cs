using System;
using System.Linq;

namespace T01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(numbers[col]);
                }
            }

            int primarySum = 0;
            int secondarySum = 0;
            for (int i = 0; i < rows; i++)
            {
                primarySum += matrix[i, i];
                secondarySum += matrix[n - i - 1, i];
            }

            int diagonalDifference = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(diagonalDifference);
        }
    }
}
