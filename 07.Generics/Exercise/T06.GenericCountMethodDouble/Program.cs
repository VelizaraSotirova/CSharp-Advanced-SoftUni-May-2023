using System;

namespace GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double item = double.Parse(Console.ReadLine());
                box.Add(item);
            }

            double itemToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}
