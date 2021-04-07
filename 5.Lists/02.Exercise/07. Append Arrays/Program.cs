using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            List<string> numbers = new List<string>();


            foreach (var item in input)
            {
                string[] numbersToAdd = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var num in numbersToAdd)
                {
                    numbers.Add(num);
                }
            }
            Console.WriteLine(string.Join(' ',numbers));
        }
    }
}
