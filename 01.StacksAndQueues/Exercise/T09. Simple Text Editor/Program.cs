using System;
using System.Collections.Generic;

namespace T09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operationsCount = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> changes = new Stack<string>();

            for (int i = 0; i < operationsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int commandNumber = int.Parse(input[0]);

                switch (commandNumber)
                {
                    case 1:
                        changes.Push(text);
                        text += input[1];
                        break;
                    case 2:
                        changes.Push(text);
                        int countToEarise = int.Parse(input[1]);
                        text = text.Remove(text.Length - countToEarise);
                        break;
                    case 3:
                        int index = int.Parse(input[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case 4:
                        text = changes.Pop();
                        break;
                }
            }
        }
    }
}
