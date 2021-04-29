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
                while (char.IsDigit(symbol))
                {
                    index = input.IndexOf(symbol);
                    if (index != -1)
                    {
                        digits.Append(symbol.ToString());
                        input = input.Remove(index,1);
                        continue;
                    }
                    break;
                }
                while (char.IsLetter(symbol))
                {
                    index = input.IndexOf(symbol);

                    if (index != -1)
                    {
                        letters.Append(symbol.ToString());
                        input = input.Remove(input.IndexOf(symbol),1);
                        continue;
                    }
                    break;
                }
                while (!char.IsLetterOrDigit(symbol))
                {
                    index = input.IndexOf(symbol);

                    if (index != -1)
                    {
                        otherChars.Append(symbol.ToString());
                        input = input.Remove(input.IndexOf(symbol),1);
                        continue;
                    }
                    break;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
