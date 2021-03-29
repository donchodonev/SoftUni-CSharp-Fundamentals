using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            if (inputType == "int")
            {
                int input = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine((GetMax(input, secondInput)));
            }
            else if (inputType == "char")
            {
                char input = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(input, secondInput));
            }
            else
            {
                string input = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(input, secondInput));
            }
        }

        static string GetMax(string firstString, string secondString)
        {

            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static int GetMax(int firstInt, int secondInt)
        {
            return Math.Max(firstInt, secondInt);
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if ((int)firstChar > (int)secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}
