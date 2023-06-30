using System;
using System.Collections.Generic;

namespace T08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "PARTY")
                {
                    while (command != "END")
                    {
                        if (VIP.Contains(command))
                        {
                            VIP.Remove(command);
                        }
                        if (regular.Contains(command))
                        {
                            regular.Remove(command);
                        }
                        command = Console.ReadLine();
                    }
                }

                if (command == "END")
                {
                    break;
                }

                char firstChar = command[0];
                if (char.IsDigit(firstChar))
                {
                    VIP.Add(command);
                }
                else
                {
                    regular.Add(command);
                }

                command = Console.ReadLine();
            }

            count = VIP.Count + regular.Count;

            if (command == "END")
            {
                Console.WriteLine(count);
                foreach (var reservation in VIP)
                {
                    Console.WriteLine(reservation);
                }
                foreach (var reservation in regular)
                {
                    Console.WriteLine(reservation);
                }
            }
        }
    }
}
