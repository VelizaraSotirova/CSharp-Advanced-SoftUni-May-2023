using System;
using System.Collections.Generic;

namespace T08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var item in parenthesis)
            {
                switch (item)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(item);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
