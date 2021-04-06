using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

            List<int> inputTwo = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

            int newListTotalCount = inputOne.Count + inputTwo.Count;

            List<int> result = new List<int>(newListTotalCount);

            for (int i = 0, v = 0, c = 0; i <= result.Capacity; i++)
            {
                if (i % 2 == 0 && v < inputOne.Count || v < inputOne.Count && c == inputTwo.Count)
                {
                    result.Add(inputOne[v]);
                    v++;
                }
                if (i % 2 != 0 && c < inputTwo.Count || v == inputOne.Count && c < inputTwo.Count)
                {
                    result.Add(inputTwo[c]);
                    c++;
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
