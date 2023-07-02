﻿namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int count = 0;

                StringBuilder sb = new StringBuilder();
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversedWords = ReverseWords(replacedSymbols);
                        sb.Append(reversedWords);
                    }
                    count++;
                }

                return sb.ToString();
            }
        }

        private static string ReplaceSymbols(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };
            foreach(char symbol in symbolsToReplace)
            {
                sb = sb.Replace(symbol, '@');
            }

            return sb.ToString();
        }

        private static string ReverseWords(string words)
        {
            string[] reversedWords = words
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", reversedWords);
        }
    }
}
