﻿using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTribonacciNums(input);
        }

        static void PrintTribonacciNums(int input)
        {

            int firstNum = 1;
            int secondNum = 1;
            int thirdNum = 2;

            if (input == 1)
            {
                Console.Write(firstNum + " ");
            }
            if (input == 2)
            {
                Console.Write(firstNum + " ");
                Console.Write(secondNum + " ");
            }
            if (input == 3)
            {
                Console.Write(firstNum + " ");
                Console.Write(secondNum + " ");
                Console.Write(thirdNum + " ");
            }


            for (int i = 4; i <= input; i++)
            {
                if (i == 4)
                {
                    Console.Write(firstNum + " ");
                    Console.Write(secondNum + " ");
                    Console.Write(thirdNum + " ");
                }
                int printNum = firstNum + secondNum + thirdNum;
                Console.Write($"{printNum} ");
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = printNum;
            }
        }
    }
}