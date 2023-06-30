using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothesByColors = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] clothesInWardrobeSortedByColor = Console.ReadLine()
                    .Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
                string color = clothesInWardrobeSortedByColor[0];

                if (!clothesByColors.ContainsKey(color))
                {
                    clothesByColors.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < clothesInWardrobeSortedByColor.Length; j++)
                {
                    string currCloth = clothesInWardrobeSortedByColor[j];
                    if (!clothesByColors[color].ContainsKey(currCloth))
                    {
                        clothesByColors[color].Add(currCloth, 0);
                    }
                    clothesByColors[color][currCloth]++;
                }
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = input[0];
            string clothToFind = input[1];

            foreach (var colorClothes in clothesByColors)
            {
                Console.WriteLine($"{colorClothes.Key} clothes:");
                foreach (var (wear, count) in colorClothes.Value)
                {
                    if (colorClothes.Key == colorToFind && wear == clothToFind)
                    {
                        Console.WriteLine($"* {wear} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {wear} - {count}");
                    }
                }
            }
        }
    }
}
