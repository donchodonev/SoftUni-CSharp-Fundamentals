using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine()
                .ToLower()//since the exercise says the program must be case insensitive
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in inputText)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount.Add(word, 1);
                }
            }

            foreach (var item in wordsCount)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
