using System;
using System.Text;
namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input));

                input = Console.ReadLine();
            }
        }

        static string IsPalindrome(string numberAsString)
        {
            string isPalindrome = "true";

            StringBuilder numReversed = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                numReversed.Append(numberAsString[i]);
            }

            if (!numberAsString.Equals(numReversed.ToString()))
            {
                isPalindrome = "false";
            }

            return isPalindrome;
        }
    }
}
