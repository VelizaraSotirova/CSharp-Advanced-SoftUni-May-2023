using System;
using System.Linq;

namespace T04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = integers[0];
            int cols = integers[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (IsValid(rows, cols, tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().ToLower();
            }
        }

        static bool IsValid(int rows, int cols, string[] tokens)
        {
            bool isValid = 
                tokens[0] == "swap" &&
                tokens.Length == 5 &&
                int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows &&
                int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols &&
                int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows &&
                int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;

            return isValid;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
