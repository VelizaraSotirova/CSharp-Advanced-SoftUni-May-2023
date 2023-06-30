using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace T02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();
            foreach (var num in numbers)
            {
                stackOfNumbers.Push(num);
            }

            string command = Console.ReadLine()
                .ToLower();

            while (command != "end")
            {
                string[] commandInfo = command
                    .Split();

                if (commandInfo[0] == "add")
                {
                    int[] numbersFromCommand = commandInfo
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in numbersFromCommand)
                    {
                        stackOfNumbers.Push(item);
                    }
                }
                else if (commandInfo[0] == "remove")
                {
                    int n = int.Parse(commandInfo[1]);

                    if (stackOfNumbers.Count >= n)
                    {
                        while (n > 0)
                        {
                            stackOfNumbers.Pop();
                            n--;
                        }
                    }
                }

                command = Console.ReadLine()
                    .ToLower();
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}
