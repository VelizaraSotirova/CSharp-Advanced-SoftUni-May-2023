﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace T06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }
                return result;
            };

            Func<List<int>, Predicate<int>, List<int>> exclude = (numbers, match) =>
            {
                List<int> result = new List<int>();
                foreach (var number in numbers)
                {
                    if (!match(number))
                    {
                        result.Add(number);
                    }
                }
                return result;
            };


            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            numbers = exclude(numbers, n => n % divider == 0);
            numbers = reverse(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
