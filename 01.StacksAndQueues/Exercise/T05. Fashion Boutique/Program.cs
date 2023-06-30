using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int rackSize = int.Parse(Console.ReadLine());
            int currSize = 0;
            int racksCount = 1;

            while (clothes.Any())
            {
                currSize += clothes.Peek();

                if (currSize > rackSize)
                {
                    currSize = 0;
                    racksCount++;
                    continue;
                }

                clothes.Pop();
            }

            Console.WriteLine(racksCount);
        }
    }
}
