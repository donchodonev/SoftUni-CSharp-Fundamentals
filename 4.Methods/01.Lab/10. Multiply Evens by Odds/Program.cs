using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMultipleOfEvenAndOdds(Console.ReadLine()));
        }

        static int GetSumOfEvenDigits(string numberAsString)
        {

            int sumOfEvenDigits = 0;

            foreach (var item in numberAsString)
            {
                if (item == '-')
                {
                    continue;
                }
                else if (int.Parse(item.ToString()) % 2 == 0)
                {
                    sumOfEvenDigits += int.Parse(item.ToString());
                } 
            }

            return sumOfEvenDigits;
        }

        static int GetSumOfOddDigits(string numberAsString)
        {

            int sumOfOddDigits = 0;

            foreach (var item in numberAsString)
            {
                if (item == '-')
                {
                    continue;
                }
                else if (int.Parse(item.ToString()) % 2 != 0)
                {
                    sumOfOddDigits += int.Parse(item.ToString());
                }
            }

            return sumOfOddDigits;
        }

        static int GetMultipleOfEvenAndOdds (string numberAsText)
        {

            int sumOfEvenNumbers = GetSumOfEvenDigits(numberAsText);
            int sumOfOddNumbers = GetSumOfOddDigits(numberAsText);

            int result = sumOfEvenNumbers * sumOfOddNumbers;

            return result;
        }
    } 

}
