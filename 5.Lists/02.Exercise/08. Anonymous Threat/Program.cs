using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            string[] command = Console.ReadLine().Split().ToArray();


            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    input = Merge(startIndex, endIndex, input);
                }
                else if (command[0] == "divide")
                {
                    int elementIndex = int.Parse(command[1]);
                    int substringsCount = int.Parse(command[2]);
                    input = Divide(elementIndex, substringsCount, input);
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(' ', input));
        }

        static List<string> Merge(int startIndex, int endIndex, List<string> listOfStrings)
        {

            if (startIndex < 0 || startIndex > listOfStrings.Count - 1)
            {
                startIndex = 0;
            }

            if (endIndex > listOfStrings.Count - 1 || endIndex < startIndex)
            {
                endIndex = listOfStrings.Count - 1;
            }

            string sumOfStrings = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                sumOfStrings += listOfStrings[i];
            }

            listOfStrings.RemoveRange(startIndex, endIndex - startIndex + 1);
            listOfStrings.Insert(startIndex, sumOfStrings);

            return listOfStrings;
        }

        static List<string> Divide(int elementIndex, int substringCount, List<string> listOfStrings)
        {

            string substring = listOfStrings[elementIndex];
            int pieceToSplitTo = substring.Length / substringCount;
            List<string> result = new List<string>(10);

            for (int i = 0; i < substring.Length; i += pieceToSplitTo)
            {
                result.Add(substring.Substring(i, pieceToSplitTo));
            }

            if (result[result.Count - 1].Length < result[result.Count - 1].Length)
            {
                result[result.Count - 2] += result[result.Count - 1];
                result.RemoveAt(result.Count - 1);
            }

            else if (result[result.Count - 1].Length == result[result.Count - 2].Length && listOfStrings[elementIndex].Length % substringCount != 0)
            {
                result[result.Count - 2] += result[result.Count - 1];
                result.RemoveAt(result.Count - 1);
            }

            string finalString = string.Empty;

            foreach (var item in result)
            {
                finalString = string.Join(' ', result);
            }

            listOfStrings.RemoveAt(elementIndex);
            listOfStrings.Insert(elementIndex, finalString);

            return listOfStrings;
        }
    }
}
