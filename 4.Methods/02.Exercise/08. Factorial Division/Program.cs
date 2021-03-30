using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Factorial(number) / Factorial(secondNumber);

            Console.WriteLine($"{result:F2}");

        }

        static double Factorial (double number)
        {
            double numFactorial = number;

            for (double i = number - 1; i > 0; i--)
            {
                numFactorial *= i;
            }
            return numFactorial;
        }
    }
}
