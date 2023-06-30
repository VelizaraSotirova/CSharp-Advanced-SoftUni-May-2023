using System;
using System.Collections.Generic;

namespace T06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();
                uniqueNames.Add(names);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
