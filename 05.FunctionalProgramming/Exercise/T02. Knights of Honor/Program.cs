using System;

namespace T02.KnightOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNamesWithAddedTitle = (string[] names) =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNamesWithAddedTitle(names);
        }
    }
}
