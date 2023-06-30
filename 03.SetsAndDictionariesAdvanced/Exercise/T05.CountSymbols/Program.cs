using System;
using System.Collections.Generic;

namespace T05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> occurencesCounts = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            foreach (char ch in text)
            {
                if (!occurencesCounts.ContainsKey(ch))
                {
                    occurencesCounts.Add(ch, 0);
                }
                occurencesCounts[ch]++;
            }

            foreach (var item in occurencesCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
