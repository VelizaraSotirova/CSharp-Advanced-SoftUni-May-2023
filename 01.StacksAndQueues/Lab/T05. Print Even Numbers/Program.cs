using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(input);
            string result = string.Empty;

            while (numbers.Any())
            {
                int currNumber = numbers.Dequeue();
                if (currNumber % 2 == 0)
                {
                    result += $"{currNumber}, ";
                }
            }

            Console.Write(result.TrimEnd(' ', ','));
        }
    }
}
