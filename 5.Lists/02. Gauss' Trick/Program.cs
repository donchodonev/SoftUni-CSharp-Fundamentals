using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int originalCount = input.Count;

            for (int i = 0; i < originalCount / 2; i++)
            {
                input[i] += input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
            }

            Console.WriteLine(string.Join(' ', input));

        }
    }
}
