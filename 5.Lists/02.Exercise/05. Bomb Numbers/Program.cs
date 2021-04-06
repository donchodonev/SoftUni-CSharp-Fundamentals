using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombProp = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();



            int bomb = bombProp[0];
            int bombPower = bombProp[1];

            while (true)
            {
                int bombIndex = numbers.FindIndex(n => n == bomb);

                int startIndex = bombIndex - bombPower;
                int endIndex = bombIndex + bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex >= numbers.Count - 1)
                {
                    endIndex = numbers.Count - 1;
                }

                numbers.RemoveRange(startIndex, endIndex - startIndex + 1);

                bombIndex = numbers.FindIndex(n => n == bomb);

                if (bombIndex < 0)
                {
                    break;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
