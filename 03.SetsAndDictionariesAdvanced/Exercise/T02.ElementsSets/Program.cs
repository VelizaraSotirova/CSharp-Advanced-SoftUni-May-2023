using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ElementsSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lenghtOfTwoSeparateSets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLenght = lenghtOfTwoSeparateSets[0];
            int secondSetLenght = lenghtOfTwoSeparateSets[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLenght; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                firstSet.Add(numbers);
            }
            for (int i = 0; i < secondSetLenght; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                secondSet.Add(numbers);
            }

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
