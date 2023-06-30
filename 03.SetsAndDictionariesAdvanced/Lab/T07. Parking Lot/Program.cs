using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                string[] cmdInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = cmdInfo[0];
                string carNumber = cmdInfo[1];

                if (direction == "IN")
                {
                    set.Add(carNumber);
                }
                else
                {
                    set.Remove(carNumber);
                }
            }

            if (set.Any())
            {
                foreach (var car in set)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
