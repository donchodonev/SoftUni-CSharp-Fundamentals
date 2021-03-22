using System;

namespace _05.Print_Part_Of_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = startChar ; startChar <= endChar; i = ++startChar)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
