using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger number2 = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(number * number2);

        }
    }
}
