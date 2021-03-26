using System;
using System.Linq;
namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < numArray.Length; i++)
            {
                bool isBigger = true;

                for (int v = i + 1; v < numArray.Length; v++)
                {
                    if (numArray[i] <= numArray[v])
                    {
                        isBigger = false;
                    }
                }

                if (isBigger)
                {
                    Console.Write(numArray[i] + " ");
                }
            }
        }
    }
}

