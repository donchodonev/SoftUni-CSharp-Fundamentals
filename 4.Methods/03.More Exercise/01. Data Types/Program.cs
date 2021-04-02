using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string input = Console.ReadLine();

            if (inputType == "int")
            {
                OutputByType(int.Parse(input));
            }
            else if (inputType == "real")
            {
                OutputByType(double.Parse(input));
            }
            else
            {
                OutputByType(input);
            }
        }

        static void OutputByType(int input)
        {
            Console.WriteLine(input * 2);
        }
        static void OutputByType(double input)
        {
            Console.WriteLine($"{input * 1.5:F2}");
        }
        static void OutputByType(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}