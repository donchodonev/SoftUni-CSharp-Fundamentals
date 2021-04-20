using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            int[] sorted = input.OrderByDescending(x => x).ToArray();

            if (sorted.Length < 3)
            {
                Console.Write(string.Join(' ', sorted));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
        }
    }
}
