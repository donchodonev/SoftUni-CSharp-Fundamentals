using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstChar = Console.ReadLine().ToCharArray();
            char[] secondChar = Console.ReadLine().ToCharArray();

            string randomString = Console.ReadLine();

            int startIndex = firstChar[0];
            int endIndex = secondChar[0];

            int sum = 0;

            foreach (var character in randomString)
            {
                if (character > startIndex && character < endIndex)
                {
                    sum += character;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
