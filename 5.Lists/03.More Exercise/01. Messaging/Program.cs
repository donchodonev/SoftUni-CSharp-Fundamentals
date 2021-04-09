using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsText = Console.ReadLine()
                .Split()
                .ToList();

            string text = Console.ReadLine();

            string finalMessage = string.Empty;

            foreach (var number in numbersAsText)
            {
                int numValue = 0;

                for (int i = 0; i < number.Length; i++)
                {
                    numValue += int.Parse(number[i].ToString());
                }

                while (numValue > text.Length)
                {
                    numValue -= text.Length;
                }

                finalMessage += text[numValue].ToString();
                text = text.Remove(numValue, 1);
            }
            Console.WriteLine(finalMessage);
        }
    }
}
