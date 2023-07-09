using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                items.Add(item);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SwapMethod(indexes[0], indexes[1], items);


            foreach (var item in items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }

            static void SwapMethod<T>(int firstIndex, int secondIndex, List<T> items)
            {
                T temp = items[firstIndex];
                items[firstIndex] = items[secondIndex];
                items[secondIndex] = temp;
            }
        }
    }
}
