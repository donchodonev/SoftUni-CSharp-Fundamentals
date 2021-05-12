using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            // index 0 = capital letters
            // index 1 = letter asci code and WHOLE word length separated by ':'
            // index 2 = words separated by spaces

            Regex capitalLetters = new Regex(@"([\#$%\*&])[A-Z]+(\1)");

            Regex colonSeparatedNums = new Regex(@"(?<ascii>\d\d):(?<length>\d\d)");

            Regex filteredWords = new Regex(@"\b [A-Z][^ ]+");

            char[] capitalLettersArray = capitalLetters
                .Match(input[0]).Value
                .Trim(capitalLetters
                .Match(input[0]).Value[0])
                .ToCharArray();

            Dictionary<char, int> kvp = new Dictionary<char, int>();

            foreach (Match item in colonSeparatedNums.Matches(input[1]))
            {
                if (capitalLettersArray.Contains((char)int.Parse(item.Groups["ascii"].Value)))
                {
                    if (!kvp.ContainsKey((char)int.Parse(item.Groups["ascii"].Value)))
                    {
                        kvp.Add((char)int.Parse(item.Groups["ascii"].Value), int.Parse(item.Groups["length"].Value) + 1);
                    }
                }
            }

            string[] words = filteredWords
                .Matches(input[2])
                .Select(x => x.Value.TrimStart(' '))
                .ToArray();

            for (int i = 0; i < capitalLettersArray.Length; i++)
            {
                foreach (var word in words)
                {
                    if (word[0] == capitalLettersArray[i] && word.Length == kvp[capitalLettersArray[i]])
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
