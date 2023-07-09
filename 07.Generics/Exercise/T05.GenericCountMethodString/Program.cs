using System;

namespace GenericCountMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                box.Add(item);
            }

            string itemToCompare = Console.ReadLine();
            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}
