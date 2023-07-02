﻿namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string currLine = lines[i];
                int lettersCount = currLine.Count(char.IsLetter);
                int punctSymbolsCount = currLine.Count(char.IsPunctuation);
                sb.AppendLine($"Line {i + 1}: {currLine} ({lettersCount})({punctSymbolsCount})");
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
