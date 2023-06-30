using System;
using System.Collections.Generic;

namespace T03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> uniqueChemicalElements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                uniqueChemicalElements.UnionWith(elements);               
            }

            Console.WriteLine(string.Join(" ", uniqueChemicalElements));
        }
    }
}
