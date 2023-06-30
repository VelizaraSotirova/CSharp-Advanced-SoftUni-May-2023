using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command != "Paid")
                {
                    clients.Enqueue(command);
                    command = Console.ReadLine();
                    continue;
                }

                while (clients.Any())
                {
                    Console.WriteLine(clients.Dequeue());
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
