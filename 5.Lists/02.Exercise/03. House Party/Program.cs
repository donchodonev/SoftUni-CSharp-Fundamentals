using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>(4);

            for (int i = 0; i < n; i++)
            {
                bool nameIsOnTheList = false;

                List<string> input = Console.ReadLine().Split().ToList();

                string name = input[0];

                if (names.Contains(name))
                {
                    nameIsOnTheList = true;
                }

                if (input.Count == 3)
                {
                    if (nameIsOnTheList)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else
                {
                    if (nameIsOnTheList)
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
