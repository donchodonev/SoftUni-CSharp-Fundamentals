using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string charSequence = "";
            //get chars and make a string
            for (int i = 0; i < 3; i++)
            {
                charSequence += char.Parse(Console.ReadLine());
            }
            
            //reverse the string and print chars with space inbetween them
            for (int i = charSequence.Length - 1; i >= 0; i--)
            {
                Console.Write(charSequence[i]);
                Console.Write(' ');
            }
        }
    }
}
