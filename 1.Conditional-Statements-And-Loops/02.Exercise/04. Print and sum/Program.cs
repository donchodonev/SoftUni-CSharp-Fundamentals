using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int numSum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
                numSum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {numSum}");
        }
    }
}
