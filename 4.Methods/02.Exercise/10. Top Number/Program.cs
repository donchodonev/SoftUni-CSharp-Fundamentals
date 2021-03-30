using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());

            for (int i = 1; i < numInput; i++)
            {
                if (SumOfDigDivBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigDivBy8 (int number)
        {
            bool isDivisible = false;

            int numDigitSum = 0;

            foreach (var item in number.ToString())
            {
                numDigitSum += int.Parse(item.ToString());
            }

            if (numDigitSum % 8 == 0)
            {
                isDivisible = true;
            }

            return isDivisible;
        }

        static bool HasOddDigit (int number)
        {
            bool hasOddDigit = false;

            foreach (var item in number.ToString())
            {
                if (int.Parse(item.ToString()) % 2 != 0)
                {
                    hasOddDigit = true;
                    break;
                }
            }
            return hasOddDigit;
        }
    }
}
