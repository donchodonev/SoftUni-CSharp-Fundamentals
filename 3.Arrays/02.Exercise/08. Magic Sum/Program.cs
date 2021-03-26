using System;
using System.Linq;
namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            int magicNum = int.Parse(Console.ReadLine());
            string magicPairs = "";
            for (int i = 0; i < input.Length; i++)
            {
                for (int v = i + 1; v < input.Length; v++)
                {
                    if (input[i] + input[v] == magicNum)
                    {
                        magicPairs += (input[i].ToString() + " " + input[v].ToString() + " ");
                    }
                }
            }
            string[] magicPairsArr = magicPairs.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();


            for (int i = 0; i < magicPairsArr.Length; i+=2)
            {
                Console.WriteLine($"{magicPairsArr[i]} {magicPairsArr[i+1]}");
            }
        }
    }
}
