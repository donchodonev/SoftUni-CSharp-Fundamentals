using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(VowelCounter(text));
        }

        static int VowelCounter (string text)
        {
            char [] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vowelsCount = 0;

            foreach (var character in text)
            {
                foreach (var vowel in vowels)
                {
                    if (character.Equals(vowel))
                    {
                        vowelsCount++;
                    }
                }
            }
            return vowelsCount;
        }
    }
}
