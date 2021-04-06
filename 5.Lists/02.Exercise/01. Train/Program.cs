using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string [] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                if (input.Length >= 2)
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    int numInput = int.Parse(input[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + numInput <= wagonCapacity)
                        {
                            wagons[i] += numInput;
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(' ',wagons));
        }
    }
}
