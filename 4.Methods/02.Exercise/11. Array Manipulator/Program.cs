using System;
using System.Linq;
namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string commandInput = Console.ReadLine();

            while (commandInput != "end")
            {

                if (commandInput.Contains("exchange"))
                {
                    int arraySplitIndex = int.Parse(commandInput.Last().ToString());
                    if (arraySplitIndex > inputArray.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        inputArray = ExchangePlaces(inputArray, arraySplitIndex);
                    }
                }

                switch (commandInput)
                {
                    case "max even":
                        MaxEven(inputArray);
                        break;
                    case "max odd":
                        MaxOdd(inputArray);
                        break;
                    case "min odd":
                        MinOdd(inputArray);
                        break;
                    case "min even":
                        MinEven(inputArray);
                        break;
                }

                commandInput = Console.ReadLine();
            }
        }

        static int[] ExchangePlaces(int[] intArray, int index)
        {
            int[] finishedArray = new int[intArray.Length];

            int finishedArrayIndexToFill = 0;

            for (int i = index + 1; i < intArray.Length; i++)
            {
                finishedArray[finishedArrayIndexToFill] = intArray[i];
                finishedArrayIndexToFill++;

            }

            for (int v = 0; v < index + 1; v++)
            {
                finishedArray[finishedArrayIndexToFill] = intArray[v];
                finishedArrayIndexToFill++;
            }

            return finishedArray;
        }

        static void MaxEven(int[] intArray)
        {
            int largestEvenNum = 0;
            int indexOfLargestEvenNum = 0;
            bool maxEvenExists = false;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    if (largestEvenNum <= intArray[i])
                    {
                        indexOfLargestEvenNum = i;
                        maxEvenExists = true;
                    }
                }
            }

            if (maxEvenExists)
            {
                Console.WriteLine(indexOfLargestEvenNum);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MaxOdd(int[] intArray)
        {
            int largestOddNum = 0;
            int indexOfLargestOddNum = 0;
            bool maxOddExists = false;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {

                    if (largestOddNum <= intArray[i])
                    {
                        indexOfLargestOddNum = i;
                        largestOddNum = intArray[i];
                    }

                    maxOddExists = true;
                }
            }

            if (maxOddExists)
            {
                Console.WriteLine(indexOfLargestOddNum);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MinEven(int[] intArray)

        {

            int smallestEvenNum = 0;
            int indexOfSmallestEvenNum = 0;
            bool minEvenExists = false;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    if (smallestEvenNum >= intArray[i])
                    {
                        smallestEvenNum = intArray[i];
                        indexOfSmallestEvenNum = i;
                    }
                    minEvenExists = true;
                }
            }

            if (minEvenExists)
            {
                Console.WriteLine(indexOfSmallestEvenNum);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MinOdd(int[] intArray)

        {

            int smallestOddNum = 0;
            int indexOfSmallestOddNum = 0;
            bool minOddExists = false;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    if (smallestOddNum >= intArray[i])
                    {
                        smallestOddNum = intArray[i];
                        indexOfSmallestOddNum = i;
                    }
                    minOddExists = true;
                }
            }

            if (minOddExists)
            {
                Console.WriteLine(indexOfSmallestOddNum);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}

