using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double toThePowerOf = double.Parse(Console.ReadLine());

            Console.WriteLine($"{ToThePowerOf(num,toThePowerOf)}");

        }

        static double ToThePowerOf (double num, double power)
        {
            double result = Math.Pow(num,power);
            return result;
        }
    }
}
