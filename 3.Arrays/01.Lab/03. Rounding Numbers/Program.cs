using System;
using System.Linq;
namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double num = numbers[i];
                double roundedNumber = Math.Round(num, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{Convert.ToDecimal(num)} => {Convert.ToDecimal(roundedNumber)}");
            }
        }
    }
}