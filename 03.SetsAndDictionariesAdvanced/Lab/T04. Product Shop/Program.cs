using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] cmdInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = cmdInfo[0];
                string product = cmdInfo[1];
                double price = double.Parse(cmdInfo[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>()); 
                }
                if (!shops[shopName].ContainsKey(product))
                {
                    shops[shopName].Add(product, price);
                }

                shops[shopName][product] = price;

                command = Console.ReadLine();
            }

            shops = shops.OrderBy(name => name.Key)
                .ToDictionary(name => name.Key, name => name.Value);

            foreach (var (shop, products) in shops)
            {
                Console.WriteLine($"{shop}->");
                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }

            }
        }
    }
}
