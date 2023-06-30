using System;
using System.Linq;
using System.Collections.Generic;

namespace T03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            Stack<string> expression = new Stack<string>(input.Reverse());

            int result = int.Parse(expression.Pop());

            while (expression.Any())
            {
                string sign = expression.Pop();
                int number = int.Parse(expression.Pop());

                if (sign == "+")
                {
                    result += number;
                }
                else if (sign == "-")
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
