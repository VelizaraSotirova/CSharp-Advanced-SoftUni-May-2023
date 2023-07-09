using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numbersTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string> nameAdress = new CustomTuple<string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2]);
            CustomTuple<string, int> nameBeer = new CustomTuple<string, int>(drinkTokens[0], int.Parse(drinkTokens[1]));
            CustomTuple<int, double> numbers = new CustomTuple<int, double>(int.Parse(numbersTokens[0]), double.Parse(numbersTokens[1]));

            Console.WriteLine(nameAdress.ToString());
            Console.WriteLine(nameBeer.ToString());
            Console.WriteLine(numbers.ToString());
        }
    }
}
