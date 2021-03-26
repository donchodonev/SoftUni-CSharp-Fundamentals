using System;
using System.Linq;
namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double[] roundedNumbers = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0 || numbers[i] == -0)
                {
                    roundedNumbers[i] = 0;
                }
                else
                {
                    roundedNumbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                }
                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
