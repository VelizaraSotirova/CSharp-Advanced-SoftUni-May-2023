using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> customStack = new CustomStack<int>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string cmd = input[0];

                if (cmd == "Push")
                {
                    int[] itemsToPush = input
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in itemsToPush)
                    {
                        customStack.Push(item);
                    }
                }
                else if (cmd == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
