using System;
using System.Collections.Generic;

namespace T05._Cities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string town = input[2];

                if (!countries.ContainsKey(continent))
                {
                    countries.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!countries[continent].ContainsKey(country))
                {
                    countries[continent].Add(country, new List<string>());
                }
                countries[continent][country].Add(town);
            }

            foreach (var (continent, country) in countries)
            {
                Console.WriteLine($"{continent}: ");
                foreach (var (countryInContinent, town) in country)
                {
                    Console.WriteLine($"    {countryInContinent} -> {string.Join(", ",town)}");
                }
            }
        }
    }
}
