using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            while (inputNum % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                inputNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(inputNum)}");
        }
    }
}
