using System;
using System.Linq;

namespace T06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); 
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(cmdInfo[1]);
                int col = int.Parse(cmdInfo[2]);
                int value = int.Parse(cmdInfo[3]);

                bool isValid = true;
                if (row < 0 || jaggedArray.Length <= row)
                {
                    isValid = false;
                }
                else 
                {
                    if (col < 0 || jaggedArray[row].Length <= col)
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    if (cmdInfo[0] == "add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine().ToLower();
            }

            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
