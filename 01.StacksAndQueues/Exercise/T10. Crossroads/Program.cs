using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secondsOfGreenLight = int.Parse(Console.ReadLine());
            int secondsOfFreeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                    continue;
                }

                int currGreenLight = secondsOfGreenLight;

                while (currGreenLight > 0 && cars.Any())
                {
                    string currentCar = cars.Dequeue();

                    if (currGreenLight - currentCar.Length >= 0)
                    {
                        currGreenLight -= currentCar.Length;
                        passedCars++;
                        continue;
                    }
                    if (currGreenLight + secondsOfFreeWindow - currentCar.Length >= 0)
                    {
                        passedCars++;
                        continue;
                    }

                    int hitChar = currGreenLight + secondsOfFreeWindow;

                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currentCar} was hit at {currentCar[hitChar]}.");
                    return;
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
