﻿using System;
using System.Collections.Generic;

namespace T01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                uniqueUsernames.Add(username);
            }

            foreach (var username in uniqueUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
