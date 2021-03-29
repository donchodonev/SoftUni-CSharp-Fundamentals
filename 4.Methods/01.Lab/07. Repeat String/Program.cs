using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine($"{RepeatString(text, repeatCount)}");
        }

        private static StringBuilder RepeatString (string text, int repeatCount)
        {

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < repeatCount; i++)
            {
                result.Append(text);
            }

            return result;
        }
    }
}
