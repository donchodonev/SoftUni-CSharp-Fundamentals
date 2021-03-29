using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeInput = double.Parse(Console.ReadLine());

            if (gradeInput >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
