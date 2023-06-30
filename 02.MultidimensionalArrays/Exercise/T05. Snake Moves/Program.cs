using System;
using System.Linq;

namespace T05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string word = Console.ReadLine();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            int currWordIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                currWordIndex = SnakeMoves(word, cols, matrix, currWordIndex, row);
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static int SnakeMoves(string word, int cols, char[,] matrix, int currWordIndex, int row)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (currWordIndex == word.Length)
                    {
                        currWordIndex = 0;
                    }
                    matrix[row, col] = word[currWordIndex];
                    currWordIndex++;
                }
            }

            if (row % 2 != 0)
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    if (currWordIndex == word.Length)
                    {
                        currWordIndex = 0;
                    }
                    matrix[row, col] = word[currWordIndex];
                    currWordIndex++;
                }
            }

            return currWordIndex;
        }
    }
}
