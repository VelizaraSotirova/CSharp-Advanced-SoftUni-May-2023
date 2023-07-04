using System;
using System.Linq;

namespace T03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> toUpper = w => Char.IsUpper(w[0]);

            string[] upperCaseWords = text
                .Where(toUpper)
                .ToArray();

            foreach (var word in upperCaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
