using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                    command = Console.ReadLine();
                    continue;
                }

                int currCount = n;

                while (cars.Any() && currCount > 0)
                {
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                    currCount--;
                    passedCars++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
