using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToEnqueue = input[0];
            int numbersToDequeue = input[1];
            int numberToLookFor = input[2];

            int[] givenNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(givenNumbers);

            for (int i = 0; i < numbersToDequeue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
