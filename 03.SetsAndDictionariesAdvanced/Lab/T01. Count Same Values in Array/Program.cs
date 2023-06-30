using System.Collections.Generic;
using System;
using System.Linq;

namespace T01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            Dictionary<double, int> numbersOccurances = new Dictionary<double, int>();

            foreach(var number in list)
            {
                if (!numbersOccurances.ContainsKey(number))
                {
                    numbersOccurances.Add(number, 0);
                }
                numbersOccurances[number]++;
            }

            foreach(var number in numbersOccurances)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
