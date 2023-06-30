using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songs.Any())
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandGiven = commands[0];
                switch (commandGiven)
                {
                    case "Add":
                        string songName = String.Join(" ", commands.Skip(1));
                        if (songs.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(songName);
                        }
                        break;
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine($"{String.Join(", ", songs)}");
                        break;
                }
            }

            if (songs.Count <= 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
