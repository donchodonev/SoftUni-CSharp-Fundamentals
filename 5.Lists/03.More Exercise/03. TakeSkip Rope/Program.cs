using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> digits = new List<int>(15);
            List<string> characters = new List<string>(35);

            foreach (var item in input)
            {
                int number;

                bool isDigit = Int32.TryParse(item.ToString(), out number);

                if (isDigit)
                {
                    digits.Add(number);
                }
                else
                {
                    characters.Add(item.ToString());
                }
            }

            List<int> takeEven = new List<int>(10);
            List<int> splitOdd = new List<int>(10);

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeEven.Add(digits[i]);
                }
                else
                {
                    splitOdd.Add(digits[i]);
                }
            }
            List<string> characters2 = new List<string>(30);

            string resultString = string.Empty;

            int splitValue = 0;
            int takeValue = 0;
            for (int i = 0; i < splitOdd.Count; i++)

            {
                splitValue = splitOdd[i];
                takeValue = takeEven[i];

                characters2 = characters.Take(takeValue).ToList();
                splitValue += takeValue;
                characters = characters.Skip(splitValue).ToList();

                foreach (var item in characters2)
                {
                    resultString += item.ToString();
                }
            }

            Console.WriteLine(resultString);

        }
    }
}
