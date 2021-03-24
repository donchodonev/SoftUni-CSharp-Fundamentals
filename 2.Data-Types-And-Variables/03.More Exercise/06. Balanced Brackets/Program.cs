using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int openBrackets = 0;

            int closingBrackets = 0;


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                char openBracket = '(';
                char closedBracket = ')';

                if (input.Contains(openBracket))
                {
                    openBrackets++;
                }

                if (input.Contains(closedBracket))
                {
                    closingBrackets++;

                    if (openBrackets - closingBrackets != 0)
                    {
                        break;
                    }
                }

            }
            if (openBrackets != closingBrackets)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
