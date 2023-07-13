using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(items);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            //throw;
                        }
                        break;
                    case "PrintAll":
                        foreach (var item in listyIterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
