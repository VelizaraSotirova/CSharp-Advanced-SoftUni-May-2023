﻿using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person()
                {
                    Name = personInfo[0],
                    Age = int.Parse(personInfo[1]),
                    Town = personInfo[2]
                };

                people.Add(person);
            }

            int compareIndex = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = people[compareIndex];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}
