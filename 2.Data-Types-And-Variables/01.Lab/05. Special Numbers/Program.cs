using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;


                    numSum += num % 10;
                    num -= num % 10;
                    numSum += num / 10;
                    num -= num / 10;

                if (numSum == 5 || numSum == 7 || numSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                numSum = 0;
            }
        }
    }
}
