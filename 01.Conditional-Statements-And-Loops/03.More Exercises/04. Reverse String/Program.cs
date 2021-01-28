using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var inputStringCharArray = inputString.ToCharArray();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputStringCharArray[i]);
            }
        }
    }
}
