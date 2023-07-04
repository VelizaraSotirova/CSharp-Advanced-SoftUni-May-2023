using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, List<int>> generateRange = (start, end) =>
            {
                List<int> result = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    result.Add(i);
                }
                return result;
            };

            Func<string, int, bool> evenOddMatch = (condition, number) =>
            {
                if (condition == "even")
                {
                    return number % 2 == 0;
                }
                else
                {
                    return number % 2 != 0;
                }
            };

            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            List<int> numbers = generateRange(range[0], range[1]);

            foreach (var num in numbers)
            {
                if (evenOddMatch(command, num))
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
