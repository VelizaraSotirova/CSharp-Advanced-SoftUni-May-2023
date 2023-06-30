using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggerNames = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmdInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vloggerName = cmdInfo[0];
                string action = cmdInfo[1];

                if (action == "joined")
                {
                    if (!vloggerNames.ContainsKey(vloggerName))
                    {
                        vloggerNames.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        vloggerNames[vloggerName].Add("followers", new HashSet<string>());
                        vloggerNames[vloggerName].Add("following", new HashSet<string>());
                    }
                }

                else if (action == "followed")
                {
                    string followedVlogger = cmdInfo[2];
                    if (vloggerName != followedVlogger && vloggerNames.ContainsKey(vloggerName) && vloggerNames.ContainsKey(followedVlogger))
                    {
                        vloggerNames[vloggerName]["following"].Add(followedVlogger);
                        vloggerNames[followedVlogger]["followers"].Add(vloggerName);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerNames.Count} vloggers in its logs.");

            int number = 1;
            foreach (var vlogger in vloggerNames
                .OrderByDescending(v => v.Value["followers"].Count)
                .ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }
        }
    }
}
