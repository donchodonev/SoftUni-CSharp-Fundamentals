using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {

                    output.Append(input[i]);

                    break;
                }
                if (input[i] != input[i + 1])
                {
                    output.Append(input[i].ToString());
                }
            }

            Console.WriteLine(output);
        }
    }
}
