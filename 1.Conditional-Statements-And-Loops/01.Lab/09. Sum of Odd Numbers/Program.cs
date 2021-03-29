using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumCap = int.Parse(Console.ReadLine());
            int sumOfOddNumbers = 0;
            int oddNum = 1;
            for (int i = 1; i <= oddNumCap; i++)
            {
                sumOfOddNumbers += oddNum;
                Console.WriteLine(oddNum);
                oddNum += 2;
            }
            Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}
