using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> chars = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString();

                if (character.Equals(" "))
                {
                    continue;
                }

                if (chars.ContainsKey(character))
                {
                    chars[character]++;
                }
                else
                {
                    chars.Add(character, 1);
                }
            }

            foreach (var character in chars)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
