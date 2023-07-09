using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = ArrayCreator.Create(50, 3);
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
