using System;
using System.Text;
using System.Linq;
namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherChars = new StringBuilder();
            int index = 0;

            foreach (var symbol in input)
            {
                index = input.IndexOf(symbol);

                if (char.IsDigit(symbol))
                {
                    if (index != -1)
                    {
                        digits.Append(symbol.ToString());
                    }
                }
                if (char.IsLetter(symbol))
                {
                    if (index != -1)
                    {
                        letters.Append(symbol.ToString());
                    }
                }
                if (!char.IsLetterOrDigit(symbol))
                {
                    if (index != -1)
                    {
                        otherChars.Append(symbol.ToString());
                    }
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
