using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharactersInRange(firstChar, secondChar);
        }
        static void CharactersInRange (char firstChar, char secondChar)
        {
            int startIndex = (int)Math.Min(firstChar, secondChar);
            int endIndex = (int)Math.Max(firstChar, secondChar);

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
