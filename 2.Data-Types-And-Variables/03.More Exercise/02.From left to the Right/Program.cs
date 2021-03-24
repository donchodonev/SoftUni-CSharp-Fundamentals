using System;

namespace _02.From_left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
            {
                long num1Value = 0L;
                long num2Value = 0L;

                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                //these two variables are not needed but make the code more readable
                string num1 = input[0];
                string num2 = input[1];

                long leftNumber = long.Parse(num1);
                long rightNumber = long.Parse(num2);

                for (int k = 0; k < num1.Length; k++)
                {
                    bool isDigit = long.TryParse(num1[k].ToString(), out long digit);
                    num1Value += digit;
                }

                for (int v = 0; v < num2.Length; v++)
                {
                    bool isDigit = long.TryParse(num2[v].ToString(), out long digit);
                    num2Value += digit;
                }

                if (leftNumber > rightNumber)
                {
                    Console.WriteLine(num1Value);
                }
                else
                {
                    Console.WriteLine(num2Value);
                }
            }
        }
    }
}
