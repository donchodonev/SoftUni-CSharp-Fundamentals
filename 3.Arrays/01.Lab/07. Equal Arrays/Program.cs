using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool arrAreIdentical = true;
            int indexOfInequality = 0;
            int arraySum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] == arr2[i])
                {
                    arrAreIdentical = true;
                    arraySum += arr1[i];
                }
                else
                {
                    arrAreIdentical = false;
                    indexOfInequality = i;
                    break;
                }

            }
            if (arrAreIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexOfInequality} index");
            }
        }
    }
}
