using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<HashSet<int>, int> min = numbers =>
            {
                int min = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            };

            HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            Console.WriteLine(min(numbers));
        }
    }
}
