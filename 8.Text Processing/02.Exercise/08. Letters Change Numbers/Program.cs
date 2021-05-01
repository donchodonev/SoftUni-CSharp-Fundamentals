using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //we substract these values depending on letter to get letter position in the English alphabet

            decimal lowerCase = 96;
            decimal upperCase = 64;
            decimal sum = 0;

            foreach (var item in text)
            {
                char firstChar = item[0];

                decimal firstCharNumValue = (decimal)firstChar;

                char lastChar = item[item.Length - 1];

                decimal lastCharNumValue = (decimal)lastChar;

                decimal number = decimal.Parse(item.Substring(1, item.Length - 2).ToString());

                //first letter logic

                if (char.IsUpper(firstChar))
                {
                    decimal posInAlphabet = firstCharNumValue - 64;
                    sum += (number / posInAlphabet);
                }
                else if (char.IsLower(firstChar))
                {
                    decimal posInAlphabet = firstCharNumValue - 96;
                    sum += (number * posInAlphabet);
                }

                //second letter logic

                if (char.IsUpper(lastChar))
                {
                    decimal posInAlphabet = lastCharNumValue - 64;
                    sum -= posInAlphabet;
                }
                else if (char.IsLower(lastChar))
                {
                    decimal posInAlphabet = lastCharNumValue - 96;
                    sum += posInAlphabet;
                }
            }
            //print
            Console.WriteLine($"{sum:F2}");
        }
    }
}
