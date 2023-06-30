using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(input);
            }

            int startIndex = 0;

            while (true)
            {
                bool isComplete = true;
                int totalLiters = 0;

                foreach (var pump in pumps)
                {
                    int liters = pump[0];
                    int distance = pump[1];

                    totalLiters += liters;

                    if (totalLiters - distance < 0)
                    {
                        startIndex++;

                        int[] currentPump = pumps.Dequeue();
                        pumps.Enqueue(currentPump);

                        isComplete = false;
                        break;
                    }

                    totalLiters -= distance;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
