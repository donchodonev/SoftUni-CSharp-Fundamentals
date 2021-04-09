using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> time = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double sumLeft = 0.0;
            double rightSum = 0.0;

            for (int i = 0; i < time.Count / 2; i++)
            {

                if (time[i] == 0)
                {
                    sumLeft *= 0.8;
                }
                else
                {
                    sumLeft += time[i];
                }
            }

            for (int v = time.Count - 1; v > time.Count / 2; v--)
            {
                if (time[v] == 0)
                {
                    rightSum *= 0.8;
                }
                else
                {
                    rightSum += time[v];
                }
            }

            if (sumLeft < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
