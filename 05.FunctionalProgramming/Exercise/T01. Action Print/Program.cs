using System;

namespace T01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = (string[] strings) => 
                Console.WriteLine(string.Join(Environment.NewLine, strings));

            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            print(strings);
        }
    }
}
