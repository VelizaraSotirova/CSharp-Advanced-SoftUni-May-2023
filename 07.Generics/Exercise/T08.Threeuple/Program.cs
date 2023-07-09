using System;
using ThreeupleType;

namespace ThreupleType
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] bankTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string, string, string> nameAdressTown = new Threeuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2], String.Join(" ",personTokens[3..]));
            Threeuple<string, int, bool> drinks = new Threeuple<string, int,bool>(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");
            Threeuple<string, double, string> bank = new Threeuple<string, double, string>(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(nameAdressTown.ToString());
            Console.WriteLine(drinks.ToString());
            Console.WriteLine(bank.ToString());
        }
    }
}
