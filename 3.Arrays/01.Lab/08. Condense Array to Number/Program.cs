using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensedArrValue = new int[numArr.Length - 1];

            if (numArr.Length == 1)
            {
                Console.WriteLine(numArr[0]);
            }
            else
            {
                for (int i = 0; i < condensedArrValue.Length; i++)
                {

                    int counter = 1;

                    for (int k = 0; k < numArr.Length - counter; k++)
                    {
                        condensedArrValue[k] = numArr[k] + numArr[k + 1];
                    }

                    for (int v = 0; v < condensedArrValue.Length; v++)
                    {
                        numArr[v] = condensedArrValue[v];
                    }

                    counter++;
                }
                Console.WriteLine(condensedArrValue[0]);
            }
        }
    }
}
