using System;
using System.Linq;
namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedInput = string.Empty;

            while (input != "end")
            {
                reversedInput = string.Empty;

                foreach (var character in input.Reverse())
                {
                    reversedInput += character.ToString();
                }
                Console.WriteLine($"{input} = {reversedInput}");
                input = Console.ReadLine();
            }
        }
    }
}
