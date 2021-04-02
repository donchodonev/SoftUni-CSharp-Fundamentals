using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();

            MultiplicationSignCheck(num1, num2, num3);
        }

        static void MultiplicationSignCheck(string num1, string num2, string num3)
        {

            int minusSign = 0;


            if (num1 == "0" || num2 == "0" || num3 == "0")
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (num1.Contains('-'))
                {
                    minusSign++;
                }

                if (num2.Contains('-'))
                {
                    minusSign++;
                }

                if (num3.Contains('-'))
                {
                    minusSign++;
                }

                if (minusSign % 2 != 0 && minusSign != 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
        }
    }
}
