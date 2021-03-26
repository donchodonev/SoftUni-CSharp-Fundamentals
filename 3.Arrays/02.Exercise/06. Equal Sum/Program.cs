using System;
using System.Linq;
namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (numArr.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {

                bool indexDoesExist = false;
                int magicIndex = 0;
                for (int i = 0; i < numArr.Length; i++)
                {
                    int leftSideSum = 0;
                    int rightSideSum = 0;

                    for (int v = i + 1; v < numArr.Length; v++)
                    {
                        rightSideSum += numArr[v];
                    }
                    for (int c = i - 1; c >= 0; c--)
                    {
                        leftSideSum += numArr[c];
                    }

                    if (leftSideSum - rightSideSum == 0)
                    {
                        indexDoesExist = true;
                        magicIndex = i;
                        break;
                    }
                }

                if (indexDoesExist)
                {
                    Console.WriteLine(magicIndex);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
