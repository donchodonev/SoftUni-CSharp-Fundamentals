using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            MatrixCreator(input);
        }

        static void MatrixCreator (int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int n = 0; n < num; n++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
