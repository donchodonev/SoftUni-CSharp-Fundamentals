using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            PrintSmallestNum(number, secondNumber, thirdNumber);
        }

        static void PrintSmallestNum (int number, int secondNumber, int thirdNumber)
        {
            if (number <= secondNumber && number <= thirdNumber)
            {
                Console.WriteLine(number);
            }
            else if (secondNumber <= number && secondNumber <= thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
