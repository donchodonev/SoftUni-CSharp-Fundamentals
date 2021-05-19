using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            int counter = 0;

            int longestCount = 0;

            string num = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;

                    if (counter > longestCount)
                    {
                        longestCount = counter;
                        num = input[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= longestCount; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
