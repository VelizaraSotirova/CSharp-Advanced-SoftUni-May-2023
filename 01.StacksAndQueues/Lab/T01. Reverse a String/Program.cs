using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> text = new Stack<char>();
            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                text.Push(ch);
            }

            while (text.Any())
            {
                Console.Write(text.Pop());
            }
        }
    }
}
