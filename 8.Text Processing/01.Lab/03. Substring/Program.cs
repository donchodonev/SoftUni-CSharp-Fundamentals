using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLowerInvariant();
            string secondString = Console.ReadLine().ToLowerInvariant();

            int index = secondString.IndexOf(firstString);

            while (index != -1)
            {
                secondString = secondString.Remove(index, firstString.Length);
                index = secondString.IndexOf(firstString);
            }

            Console.WriteLine(secondString);

        }
    }
}
