using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] givenNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = input[0];
            int numbersToPop = input[1];
            int numberToLookFor = input[2];

            Stack<int> ints = new Stack<int>(givenNumbers);

            for (int i = 0; i < numbersToPop; i++)
            {
                ints.Pop();
            }

            if (ints.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (ints.Any())
                {
                    Console.WriteLine(ints.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
