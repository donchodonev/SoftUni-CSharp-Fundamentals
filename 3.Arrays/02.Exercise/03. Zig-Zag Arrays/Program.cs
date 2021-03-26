using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] oddNumPosArray = new int[n];
            int[] evenNumPosArray = new int[n];
            int posCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)
                {
                    oddNumPosArray[posCounter] = nums[0];
                    evenNumPosArray[posCounter] = nums[1];
                    posCounter++;
                }
                else
                {
                    oddNumPosArray[posCounter] = nums[1];
                    evenNumPosArray[posCounter] = nums[0];
                    posCounter++;
                }
            }

            foreach (var item in oddNumPosArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            foreach (var item in evenNumPosArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}