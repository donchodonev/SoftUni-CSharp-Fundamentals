using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleColumns = int.Parse(Console.ReadLine());

            for (int i = 1; i < triangleColumns; i++)
            {
                PrintLine(1,i);
            }
            
            for (int i = triangleColumns; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
