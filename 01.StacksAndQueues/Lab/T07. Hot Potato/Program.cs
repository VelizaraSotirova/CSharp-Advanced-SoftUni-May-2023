using System;
using System.Collections.Generic;

namespace T07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputNames = Console.ReadLine()
                .Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> players = new Queue<string>(inputNames);     

            while (players.Count > 1)
            {
                for (int i = 1; i < n ; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}
