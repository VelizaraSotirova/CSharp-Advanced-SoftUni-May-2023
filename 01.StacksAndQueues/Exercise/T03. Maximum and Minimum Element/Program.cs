using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> query = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] queryNum = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int queryNumInfo = queryNum[0];
                //1 x – Push the element x into the stack.
                //2 – Delete the element present at the top of the stack.
                //3 – Print the maximum element in the stack.
                //4 – Print the minimum element in the stack.
                switch (queryNumInfo)
                {
                    case 1:
                        int x = queryNum[1];
                        query.Push(x);
                        break;
                    case 2:
                        query.Pop();
                        break;
                    case 3:
                        if (query.Any())
                        {
                            Console.WriteLine(query.Max());
                        }
                        break;
                    case 4:
                        if (query.Any())
                        {
                            Console.WriteLine(query.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", query));
        }
    }
}
