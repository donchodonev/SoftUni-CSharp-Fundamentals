using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string charSequence = "";
            for (int i = 0; i < 3; i++)
            {
                charSequence += char.Parse(Console.ReadLine());
            }
            Console.WriteLine(charSequence);
        }
    }
}
