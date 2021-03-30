using System;
using System.Text;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(MidCharsPrint(input));
        }
        
        static string MidCharsPrint (string text)
        {

            StringBuilder returnString = new StringBuilder();

            if (text.Length % 2 != 0)
            {
                returnString.Append(text[text.Length / 2]);
            }
            else
            {
                returnString.Append(text[(text.Length / 2) - 1]);
                returnString.Append(text[text.Length / 2]);
            }

            return returnString.ToString();

        }
    }
}
