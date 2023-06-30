using System;
using System.Linq;

namespace T03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            int primarySum = 0;
            for (int i = 0; i < n; i++)
            {
                primarySum += matrix[i, i];
            }

            Console.WriteLine(primarySum);
        }
    }
}
