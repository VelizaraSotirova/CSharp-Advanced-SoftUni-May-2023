using System;
using System.Linq;

namespace T06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] cols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = cols;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdInfo[0];
                int row = int.Parse(cmdInfo[1]);
                int col = int.Parse(cmdInfo[2]);
                int value = int.Parse(cmdInfo[3]);

                if (ValidCell(row, col, jaggedArray))
                {
                    if (cmd == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (cmd == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidCell(int row, int col, int[][] jaggedArray)
        {
            return
                row >= 0 &&
                row < jaggedArray.Length &&
                col >= 0 &&
                col < jaggedArray[row].Length;
        }
    }
}
