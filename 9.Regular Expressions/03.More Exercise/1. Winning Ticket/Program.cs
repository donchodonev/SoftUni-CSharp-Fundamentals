using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\@#$^]{6,10}";

            string[] tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var t in tickets)
            {
                Match ticket = Regex.Match(t, pattern);

                if (t.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftSide = t.Substring(0, 10);
                string rightSide = t.Substring(10, 10);

                Match leftSideMatch = Regex.Match(leftSide, pattern);
                Match rightSideMatch = Regex.Match(rightSide, pattern);

                if (!leftSideMatch.Success || !rightSideMatch.Success)
                {
                    Console.WriteLine($"ticket \"{t}\" - no match");
                    continue;
                }

                Dictionary<char, int> leftSideCharCounter = new Dictionary<char, int>();
                Dictionary<char, int> rightSideCharCounter = new Dictionary<char, int>();

                foreach (var character in leftSideMatch.Value)
                {
                    if (leftSideCharCounter.ContainsKey(character))
                    {
                        leftSideCharCounter[character]++;
                    }
                    else
                    {
                        leftSideCharCounter.Add(character, 1);
                    }
                }

                foreach (var character in rightSideMatch.Value)
                {
                    if (rightSideCharCounter.ContainsKey(character))
                    {
                        rightSideCharCounter[character]++;
                    }
                    else
                    {
                        rightSideCharCounter.Add(character, 1);
                    }
                }

                //sort by count

                leftSideCharCounter = leftSideCharCounter
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, y => y.Value);

                rightSideCharCounter = rightSideCharCounter
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, y => y.Value);

                //get char symbol and it's count from each side of the string

                char leftSideSymbol = leftSideCharCounter.Keys.First();
                int leftSideSymbolCount = leftSideCharCounter.Values.First();

                char rightSideSymbol = rightSideCharCounter.Keys.First();
                int rightSideSymbolCount = rightSideCharCounter.Values.First();

                int minCount = Math.Min(leftSideSymbolCount, rightSideSymbolCount);

                //print

                if (leftSideSymbol == rightSideSymbol)
                {
                    if (minCount >= 6 && minCount <= 9)
                    {
                        Console.WriteLine($"ticket \"{t}\" - {minCount}{rightSideSymbol}");
                    }
                    else if (minCount == 10)
                    {
                        Console.WriteLine($"ticket \"{t}\" - {minCount}{rightSideSymbol} Jackpot!");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{t}\" - no match");
                    continue;
                }
            }
        }
    }
}
