using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }

            int wagonsSum = 0;

            foreach (var item in wagons)
            {
                Console.Write($"{item} ");
                wagonsSum += item;
            }

            Console.WriteLine();
            Console.WriteLine(wagonsSum);
        }
    }
}
