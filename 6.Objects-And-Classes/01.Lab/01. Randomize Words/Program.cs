using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random random = new Random();

            int index = random.Next(0, words.Count);

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item) ;
            }

        }
    }
}
