using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            foreach (var character in input)
            {
                output += ((char)(character + 3)).ToString();
            }

            Console.WriteLine(output);
        }
    }
}
