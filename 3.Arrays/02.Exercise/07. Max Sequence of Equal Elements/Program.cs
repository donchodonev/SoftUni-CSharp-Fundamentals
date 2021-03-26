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

            // check if input is just 1 num, if not - proceed
            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                string longestSequence = "";
                // run a check for the longest sequence of numbers
                for (int i = 0; i < input.Length; i++)
                {
                    string currentLongestEqualElementsSequence = "";
                    int currentLongest = 0;

                    for (int v = i + 1; v < input.Length; v++)
                    {
                        if (input[i] == input[v])
                        {
                            currentLongest++;
                            currentLongestEqualElementsSequence += input[v];
                        }
                        else // if no sequence if found - break
                        {
                            break;
                        }
                    }
                    //if newly found sequence is larger than the last know largest sequence
                    if (currentLongestEqualElementsSequence.Length > longestSequence.Length)
                    {
                        longestSequence = currentLongestEqualElementsSequence;
                    }

                }
                //check if no sequences are found, again
                if (longestSequence.Length == 0)
                {
                    Console.WriteLine(input[0]);
                }
                else // else append 1 more time the sequence symbol to complete the array
                {
                    longestSequence = longestSequence + longestSequence[0];
                }

                //conversion and printing of longest sequence array

                int[] result = new int[longestSequence.Length];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = int.Parse(longestSequence[i].ToString());
                }

                Console.Write(String.Join(" ", result));
            }
        }
    }
}
